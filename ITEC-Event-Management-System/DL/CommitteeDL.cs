using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITEC_Event_Management_System.BL;
using MySql.Data.MySqlClient;

namespace ITEC_Event_Management_System.DL
{
    static public class CommitteeDL
    {
        static public List<Committee> GetAllCommittees()
        {
            List<Committee> committees = new List<BL.Committee>();
            string query = "SELECT * FROM Committees";
            
            var reader = DatabaseHelper.Instance.getData(query);

                while (reader.Read())
                {
                    int itecId = reader.IsDBNull(reader.GetOrdinal("itec_id")) ? -1 : reader.GetInt32("itec_id");
                    Committee committee = new Committee(reader.GetInt32("committee_id"), itecId, reader.GetString("committee_name"));
                    committees.Add(committee);
                }
            
            return committees;
        }

        static public int StoreCommittee(Committee committee)
        {
            string ITECIDValue = committee.ITECID == -1 ? "Null" : committee.ITECID.ToString();
            string query = $"INSERT INTO Committees (itec_id, committee_name) VALUES ({ITECIDValue}, '{committee.Name}')";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public int UpdateCommittee(Committee committee)
        {
            string checkQuery = $"SELECT * FROM Committees WHERE committee_id = {committee.ID}";
            var reader = DatabaseHelper.Instance.getData(checkQuery);

            if (reader.Read())
            {
                string ITECIDValue = committee.ITECID == -1 ? "Null" : committee.ITECID.ToString();
                if (string.IsNullOrWhiteSpace(committee.Name))
                    committee.Name = reader.GetString("committee_name");

                string query = $"UPDATE Committees SET itec_id = {ITECIDValue}, committee_name = '{committee.Name}' WHERE committee_id = {committee.ID}";
                return DatabaseHelper.Instance.ExecuteQuery(query);
            }

            return 0;
        }

        static public int DeleteCommittee(int committeeID)
        {
            string query = $"DELETE FROM Committees WHERE committee_id = {committeeID}";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public Committee GetCommitteeByID(int committeeID)
        {
            string query = $"SELECT * FROM Committees WHERE committee_id = {committeeID}";
            var reader = DatabaseHelper.Instance.getData(query);

            if (reader.HasRows)
            {
                reader.Read();
                return new Committee(reader.GetInt32("committee_id"), reader.IsDBNull(reader.GetOrdinal("itec_id")) ? -1 : reader.GetInt32("itec_id"), reader.GetString("committee_name"));
            }
            else
            {
                return null;
            }
        }

        static public List<Committee> GetCommitteeByITECID(int itecID)
        {
            List<Committee> committees = new List<BL.Committee>();
            string query = $"SELECT * FROM Committees WHERE itec_id = {itecID}";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                Committee committee = new Committee(reader.GetInt32("committee_id"), reader.IsDBNull(reader.GetOrdinal("itec_id")) ? -1 : reader.GetInt32("itec_id"), reader.GetString("committee_name"));
                committees.Add(committee);
            }
            return committees;
        }

        static public List<Committee> GetCommitteeBYNULLITECID()
        {
            List<Committee> committees = new List<BL.Committee>();
            string query = $"SELECT * FROM Committees WHERE itec_id IS NULL";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                Committee committee = new Committee(reader.GetInt32("committee_id"), reader.IsDBNull(reader.GetOrdinal("itec_id")) ? -1 : reader.GetInt32("itec_id"), reader.GetString("committee_name"));
                committees.Add(committee);
            }
            return committees;
        }

        static public List<Committee> GetCommitteeByName(string name)
        {
            List<Committee> committees = new List<BL.Committee>();
            string query = $"SELECT * FROM Committees WHERE committee_name LIKE '%{name}%'";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                Committee committee = new Committee(reader.GetInt32("committee_id"), reader.IsDBNull(reader.GetOrdinal("itec_id")) ? -1 : reader.GetInt32("itec_id"), reader.GetString("committee_name"));
                committees.Add(committee);
            }
            return committees;
        }
    }
}
