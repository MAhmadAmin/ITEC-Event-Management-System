using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEC_Event_Management_System.BL;
using MySql.Data.MySqlClient;

namespace ITEC_Event_Management_System.DL
{

    public static class CommitteeMemberDL
    {
        public static List<CommitteeMember> GetAllCommitteeMembers()
        {
            List<CommitteeMember> members = new List<CommitteeMember>();

            string query = "SELECT * FROM Committee_members";

            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);

            while (reader.Read())
            {
                int committeeId = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                int roleId = reader.IsDBNull(reader.GetOrdinal("role_id")) ? -1 : reader.GetInt32("role_id");

                members.Add(new CommitteeMember(reader.GetInt32("member_id"), committeeId, reader.GetString("name"), roleId));
            }

            return members;
        }

        public static int StoreMember(CommitteeMember member)
        {
            string committeeIDValue = member.committeeID == -1 ? "Null" : member.committeeID.ToString();
            string roleIDValue = member.roleID == -1 ? "Null" : member.roleID.ToString();
            string query = $"INSERT INTO Committee_members (committee_id, name, role_id) VALUES ({committeeIDValue}, '{member.name}', {roleIDValue})";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        public static CommitteeMember GetMemberByID(int id)
        {
            string query = $"SELECT * FROM Committee_members WHERE member_id = {id}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                int committeeId = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                int roleId = reader.IsDBNull(reader.GetOrdinal("role_id")) ? -1 : reader.GetInt32("role_id");
                return new CommitteeMember(reader.GetInt32("member_id"), committeeId, reader.GetString("name"), roleId);
            }
            return null;
        }

        public static int UpdateMember(CommitteeMember member)
        {
            string checkQuery = $"SELECT * FROM Committee_members WHERE member_id = {member.ID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(checkQuery);
            if (reader.Read())
            {
                string committeeIDValue = member.committeeID == -1 ? "Null" : member.committeeID.ToString();
                string roleIDValue = member.roleID == -1 ? "Null" : member.roleID.ToString();
                if (string.IsNullOrWhiteSpace(member.name))
                    member.name = reader.GetString("name");
                string query = $"UPDATE Committee_members SET committee_id = {committeeIDValue}, name = '{member.name}', role_id = {roleIDValue} WHERE member_id = {member.ID}";
                return DatabaseHelper.Instance.ExecuteQuery(query);
            }
            return 0;
        }

        public static int DeleteMember(int ID)
        {
            string query = $"DELETE FROM Committee_members WHERE member_id = {ID}";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        public static List<CommitteeMember> GetMembersByCommitteeID(int committeeID)
        {
            List<CommitteeMember> members = new List<CommitteeMember>();
            string query = $"SELECT * FROM Committee_members WHERE committee_id = {committeeID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int roleId = reader.IsDBNull(reader.GetOrdinal("role_id")) ? -1 : reader.GetInt32("role_id");
                members.Add(new CommitteeMember(reader.GetInt32("member_id"), committeeID, reader.GetString("name"), roleId));
            }
            return members;
        }

        public static List<CommitteeMember> GetMembersByRoleID(int roleID)
        {
            List<CommitteeMember> members = new List<CommitteeMember>();
            string query = $"SELECT * FROM Committee_members WHERE role_id = {roleID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int committeeId = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                members.Add(new CommitteeMember(reader.GetInt32("member_id"), committeeId, reader.GetString("name"), roleID));
            }
            return members;
        }

        public static List<CommitteeMember> GetMembersByName(string name)
        {
            List<CommitteeMember> members = new List<CommitteeMember>();
            string query = $"SELECT * FROM Committee_members WHERE name LIKE '%{name}%'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int committeeId = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                int roleId = reader.IsDBNull(reader.GetOrdinal("role_id")) ? -1 : reader.GetInt32("role_id");
                members.Add(new CommitteeMember(reader.GetInt32("member_id"), committeeId, reader.GetString("name"), roleId));
            }
            return members;
        }

        public static List<CommitteeMember> GetMembersByNullCommitteeID()
        {
            List<CommitteeMember> members = new List<CommitteeMember>();
            string query = $"SELECT * FROM Committee_members WHERE committee_id IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int roleId = reader.IsDBNull(reader.GetOrdinal("role_id")) ? -1 : reader.GetInt32("role_id");
                members.Add(new CommitteeMember(reader.GetInt32("member_id"), -1, reader.GetString("name"), roleId));
            }
            return members;
        }

        public static List<CommitteeMember> GetMembersByNullRoleID()
        {
            List<CommitteeMember> members = new List<CommitteeMember>();
            string query = $"SELECT * FROM Committee_members WHERE role_id IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int committeeId = reader.IsDBNull(reader.GetOrdinal("committee_id")) ? -1 : reader.GetInt32("committee_id");
                members.Add(new CommitteeMember(reader.GetInt32("member_id"), committeeId, reader.GetString("name"), -1));
            }
            return members;
        }
    }
}
