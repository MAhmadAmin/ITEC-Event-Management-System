using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEC_Event_Management_System.BL;
using MySql.Data.MySqlClient;

namespace ITEC_Event_Management_System.DL
{
    static public class DutyDL
    {
        static public int StoreDuty(Duty duty)
        {
            string committeeID = duty.CommitteeID == -1 ? "NULL" : duty.CommitteeID.ToString();
            string taskDescription = string.IsNullOrWhiteSpace(duty.TaskDescription) ? "NULL" : $"'{duty.TaskDescription.ToString()}'";
            string statusID = duty.StatusID == -1 ? "NULL" : $"'{duty.StatusID.ToString()}'";

            string query = $"INSERT INTO duties (committee_id, assigned_to, task_description, deadline, status_id) VALUES ({committeeID}, '{duty.AssignedTo}', {taskDescription}, '{duty.Deadline.ToString("yyyy-MM-dd")}', {statusID} )";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public List<Duty> GetAllDuties()
        {
            List<Duty> duties = new List<Duty>();
            string query = "SELECT * FROM duties";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                string taskDescription = reader.IsDBNull(reader.GetOrdinal("task_description")) ? null : reader.GetString("task_description");
                int statusID = reader.IsDBNull(reader.GetOrdinal("status_id")) ? -1 : reader.GetInt32("status_id");

                duties.Add(new Duty(reader.GetInt32(0), committeeID, reader.GetString("assigned_to"), taskDescription, reader.GetDateTime("deadline"), statusID));
            }
            return duties;
        }
        static public int DeleteDuty(int ID)
        {
            string query = $"DELETE FROM duties WHERE duty_id = {ID}";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public int UpdateDuty(Duty duty)
        {
            string checkQuery = $"SELECT * FROM duties";
            MySqlDataReader checkReader = DatabaseHelper.Instance.getData(checkQuery);
            if (checkReader.Read())
            {
                string committeeID = duty.CommitteeID == -1 ? "NULL" : duty.CommitteeID.ToString();
                string taskDescription = string.IsNullOrWhiteSpace(duty.TaskDescription) ? "NULL" : $"'{duty.TaskDescription}'";
                string statusID = duty.StatusID == -1 ? "NULL" : $"'{duty.StatusID}'";

                string query = $"UPDATE duties SET committee_id = {committeeID}, assigned_to = '{duty.AssignedTo}', task_description = {taskDescription}, deadline = '{duty.Deadline.ToString("yyyy-MM-dd")}', status_id = {statusID} WHERE duty_id = {duty.ID}";
                return DatabaseHelper.Instance.ExecuteQuery(query);
            }
            else
                return -1;

        }

        static public Duty GetDutyByID(int ID)
        {
            string query = $"SELECT * FROM duties WHERE duty_id = {ID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                string taskDescription = reader.IsDBNull(reader.GetOrdinal("task_description")) ? null : reader.GetString("task_description");
                int statusID = reader.IsDBNull(reader.GetOrdinal("status_id")) ? -1 : reader.GetInt32("status_id");

                return new Duty(reader.GetInt32("duty_id"), committeeID, reader.GetString("assigned_to"), taskDescription, reader.GetDateTime("deadline"), statusID);
            }
            return null;
        }

        static public List<Duty> GetDutiesByCommitteeID(int ID)
        {
            List<Duty> duties = new List<Duty>();
            string query = $"SELECT * FROM duties WHERE committee_id = {ID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                string taskDescription = reader.IsDBNull(reader.GetOrdinal("task_description")) ? null : reader.GetString("task_description");
                int statusID = reader.IsDBNull(reader.GetOrdinal("status_id")) ? -1 : reader.GetInt32("status_id");

                duties.Add(new Duty(reader.GetInt32("duty_id"), committeeID, reader.GetString("assigned_to"), taskDescription, reader.GetDateTime("deadline"), statusID));
            }
            return duties;
        }

        static public List<Duty> GetDutiesByNullCommitteeID()
        {
            List<Duty> duties = new List<Duty>();
            string query = "SELECT * FROM duties WHERE committee_id IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                string taskDescription = reader.IsDBNull(reader.GetOrdinal("task_description")) ? null : reader.GetString("task_description");
                int statusID = reader.IsDBNull(reader.GetOrdinal("status_id")) ? -1 : reader.GetInt32("status_id");

                duties.Add(new Duty(reader.GetInt32("duty_id"), committeeID, reader.GetString("assigned_to"), taskDescription, reader.GetDateTime("deadline"), statusID));
            }
            return duties;
        }

        static public List<Duty> GetDutiesByAssignedTo(string assignedTo)
        {
            List<Duty> duties = new List<Duty>();
            string query = $"SELECT * FROM duties WHERE assigned_to = '{assignedTo}'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                string taskDescription = reader.IsDBNull(reader.GetOrdinal("task_description")) ? null : reader.GetString("task_description");
                int statusID = reader.IsDBNull(reader.GetOrdinal("status_id")) ? -1 : reader.GetInt32("status_id");

                duties.Add(new Duty(reader.GetInt32("duty_id"), committeeID, reader.GetString("assigned_to"), taskDescription, reader.GetDateTime("deadline"), statusID));
            }
            return duties;
        }

        static public List<Duty> GetDutiesByDescriptionLike(string description)
        {
            List<Duty> duties = new List<Duty>();
            string query = $"SELECT * FROM duties WHERE task_description LIKE '%{description}%'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                string taskDescription = reader.IsDBNull(reader.GetOrdinal("task_description")) ? null : reader.GetString("task_description");
                int statusID = reader.IsDBNull(reader.GetOrdinal("status_id")) ? -1 : reader.GetInt32("status_id");

                duties.Add(new Duty(reader.GetInt32("duty_id"), committeeID, reader.GetString("assigned_to"), taskDescription, reader.GetDateTime("deadline"), statusID));
            }
            return duties;
        }

        static public List<Duty> GetDutiesByNullDescription()
        {
            List<Duty> duties = new List<Duty>();
            string query = "SELECT * FROM duties WHERE task_description IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                string taskDescription = reader.IsDBNull(reader.GetOrdinal("task_description")) ? null : reader.GetString("task_description");
                int statusID = reader.IsDBNull(reader.GetOrdinal("status_id")) ? -1 : reader.GetInt32("status_id");

                duties.Add(new Duty(reader.GetInt32("duty_id"), committeeID, reader.GetString("assigned_to"), taskDescription, reader.GetDateTime("deadline"), statusID));
            }
            return duties;
        }

        static public List<Duty> GetDutiesByStatusID(int ID)
        {
            List<Duty> duties = new List<Duty>();
            string query = $"SELECT * FROM duties WHERE status_id = {ID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                string taskDescription = reader.IsDBNull(reader.GetOrdinal("task_description")) ? null : reader.GetString("task_description");
                int statusID = reader.IsDBNull(reader.GetOrdinal("status_id")) ? -1 : reader.GetInt32("status_id");

                duties.Add(new Duty(reader.GetInt32("duty_id"), committeeID, reader.GetString("assigned_to"), taskDescription, reader.GetDateTime("deadline"), statusID));
            }
            return duties;
        }

        static public List<Duty> GetDutiesByNullStatusID()
        {
            List<Duty> duties = new List<Duty>();
            string query = "SELECT * FROM duties WHERE status_id IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                string taskDescription = reader.IsDBNull(reader.GetOrdinal("task_description")) ? null : reader.GetString("task_description");
                int statusID = reader.IsDBNull(reader.GetOrdinal("status_id")) ? -1 : reader.GetInt32("status_id");

                duties.Add(new Duty(reader.GetInt32("duty_id"), committeeID, reader.GetString("assigned_to"), taskDescription, reader.GetDateTime("deadline"), statusID));
            }
            return duties;
        }

        static public List<Duty> GetDutiesByDate(DateTime date)
        {
            List<Duty> duties = new List<Duty>();
            string query = $"SELECT * FROM duties WHERE deadline = '{date.ToString("yyyy-MM-dd")}'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                string taskDescription = reader.IsDBNull(reader.GetOrdinal("task_description")) ? null : reader.GetString("task_description");
                int statusID = reader.IsDBNull(reader.GetOrdinal("status_id")) ? -1 : reader.GetInt32("status_id");

                duties.Add(new Duty(reader.GetInt32("duty_id"), committeeID, reader.GetString("assigned_to"), taskDescription, reader.GetDateTime("deadline"), statusID));
            }
            return duties;
        }
    }
}
