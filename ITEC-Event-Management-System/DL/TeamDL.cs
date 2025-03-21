using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ITEC_Event_Management_System.BL;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.IO;

namespace ITEC_Event_Management_System.DL
{
    static public class TeamDL
    {
        static public int StoreTeam(Team team)
        {
            string eventID = team.EventID == -1 ? "NULL" : team.EventID.ToString();
            string query = $"INSERT INTO Teams (event_ID, team_Name) VALUES ({eventID}, '{team.Name}')";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public List<Team> GetAllTeams()
        {
            List<Team> teams = new List<Team>();
            string query = "SELECT * FROM Teams";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int eventID = reader.IsDBNull(1) ? -1 : reader.GetInt32(1);
                string name = reader.GetString(2);
                teams.Add(new Team(id, eventID, name));
            }
            reader.Close();
            return teams;
        }

        static public Team GetTeamByID(int id)
        {
            string query = $"SELECT * FROM Teams WHERE team_ID = {id}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                int eventID = reader.IsDBNull(1) ? -1 : reader.GetInt32(1);
                string name = reader.GetString(2);
                reader.Close();

                return new Team(id, eventID, name);
            }
            else
                return null;
        }

        static public int DeleteTeam(int id)
        {
            string query = $"DELETE FROM Teams WHERE team_ID = {id}";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public int UpdateTeam(Team team)
        {
            string checkQuery = $"SELECT * FROM Teams WHERE team_ID = {team.ID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(checkQuery);
            if (!reader.Read())
            {
                reader.Close();
                return -1;
            }

            string eventID = team.EventID == -1 ? "NULL" : team.EventID.ToString();
            string teamName = string.IsNullOrEmpty(team.Name) ? $"{reader["team_name"].ToString()}" : team.Name;
            string query = $"UPDATE Teams SET event_ID = {eventID}, team_Name = '{teamName}' WHERE team_ID = {team.ID}";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public List<Team> GetTeamsByNameLike(string teamName)
        {
            List<Team> teams = new List<Team>();

            string query = $"SELECT * From Teams WHERE team_name LIKE '%{teamName}%'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int eventID = reader.IsDBNull(1) ? -1 : reader.GetInt32(1);
                string name = reader.GetString(2);
                teams.Add(new Team(id, eventID, name));
            }
            reader.Close();
            return teams;
        }

        static public List<Team> GetTeamsByEventID(int searchEventID)
        {
            List<Team> teams = new List<Team> ();

            string query = $"SELECT * FROM Teams WHERE event_ID = {searchEventID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);

            while(reader.Read())
            {
                int id = reader.GetInt32(0);
                int eventID = reader.IsDBNull(1) ? -1 : reader.GetInt32(1);
                string name = reader.GetString(2);
                teams.Add(new Team(id, eventID, name));
            }
            reader.Close();
            return teams;
        }

        static public List<Team> GetTeamsByEventIDNull()
        {
            List<Team> teams = new List<Team>();

            string query = "SELECT * FROM Teams WHERE event_ID IS NULL";

            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int eventID = reader.IsDBNull(1) ? -1 : reader.GetInt32(1);
                string name = reader.GetString(2);
                teams.Add(new Team(id, eventID, name));
            }
            reader.Close();
            return teams;
        }
    }
}
