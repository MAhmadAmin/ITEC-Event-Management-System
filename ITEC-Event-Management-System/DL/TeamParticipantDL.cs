using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEC_Event_Management_System.BL;
using MySql.Data.MySqlClient;

namespace ITEC_Event_Management_System.DL
{
    static public class TeamParticipantDL
    {
        static public int StoreTeamParticipant(TeamParticipant teamParticipant)
        {
            string checkQuery = $"SELECT * FROM team_participants WHERE team_id = {teamParticipant.TeamID} AND participant_id = {teamParticipant.ParticipantID}";
            MySqlDataReader checkReader =  DatabaseHelper.Instance.getData(checkQuery);
            if (!checkReader.Read())
            {
                string query = $"INSERT INTO team_participants (Team_ID, Participant_ID) VALUES ({teamParticipant.TeamID}, {teamParticipant.ParticipantID})";
                int result = DatabaseHelper.Instance.ExecuteQuery(query);
                return result;
            }
            else
                return -1;
        }

        static public List<TeamParticipant> GetAllTeamParticipants()
        {
            List<TeamParticipant > teamParticipants = new List<TeamParticipant>();  

            string query = "SELECT * FROM team_participants";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while(reader.Read())
            {
                teamParticipants.Add(new TeamParticipant(reader.GetInt32("team_id"), reader.GetInt32("participant_id")));
            }
            reader.Close();
            return teamParticipants;
        }

        static public TeamParticipant GetTeamParticipant(TeamParticipant participant)
        {
            string query = $"SELECT * FROM team_participants WHERE team_id = {participant.TeamID} AND participant_id = {participant.ParticipantID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                return new TeamParticipant(reader.GetInt32("team_id"), reader.GetInt32("participant_id"));

            }
            else
                return null;
        }

        static public List<TeamParticipant> GetTeamParticipantsByTeamID(int teamID)
        {
            List<TeamParticipant> teamParticipants = new List<TeamParticipant>();

            string query = $"SELECT * FROM team_participants WHERE team_ID = {teamID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                teamParticipants.Add(new TeamParticipant(reader.GetInt32("team_id"), reader.GetInt32("participant_id")));
            }
            reader.Close();
            return teamParticipants;
        }

        static public List<TeamParticipant> GetTeamParticipantsByNullTeamID()
        {
            List<TeamParticipant> teamParticipants = new List<TeamParticipant>();

            string query = "SELECT * FROM team_participants WHERE team_ID IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                teamParticipants.Add(new TeamParticipant(reader.GetInt32("team_id"), reader.GetInt32("participant_id")));
            }
            reader.Close();
            return teamParticipants;
        }

        static public List<TeamParticipant> GetTeamParticipantsByParticipantID(int participantID)
        {
            List<TeamParticipant> teamParticipants = new List<TeamParticipant>();

            string query = $"SELECT * FROM team_participants WHERE participant_id = {participantID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                teamParticipants.Add(new TeamParticipant(reader.GetInt32("team_id"), reader.GetInt32("participant_id")));
            }
            reader.Close();
            return teamParticipants;
        }

        static public List<TeamParticipant> GetTeamParticipantsByNullParticipantID()
        {
            List<TeamParticipant> teamParticipants = new List<TeamParticipant>();

            string query = "SELECT * FROM team_participants WHERE participant_id IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                teamParticipants.Add(new TeamParticipant(reader.GetInt32("team_id"), reader.GetInt32("participant_id")));
            }
            reader.Close();
            return teamParticipants;
        }

        static public int DeleteParticipant(TeamParticipant teamParticipant)
        {
            string checkQuery = $"SELECT * FROM team_participants WHERE team_id = {teamParticipant.TeamID} AND participant_id = {teamParticipant.ParticipantID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(checkQuery);
            if (reader.Read())
            {
                string query = $"DELETE FROM team_participants WHERE team_id = {teamParticipant.TeamID} AND participant_id = {teamParticipant.ParticipantID}";
                return DatabaseHelper.Instance.ExecuteQuery(query);
            }
            else
                return -1;
        }
    }
}
