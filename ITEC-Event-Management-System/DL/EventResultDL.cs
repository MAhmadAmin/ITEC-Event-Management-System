using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEC_Event_Management_System.BL;

namespace ITEC_Event_Management_System.DL
{
    static public class EventResultDL
    {
        static public int StoreEventResult(EventResult result)
        {
            string eventID = result.EventID == -1 ? "NULL" : $"{result.EventID}";
            string participantID = result.ParticipantID == -1 ? "NULL" : $"{result.ParticipantID}";
            string teamID = result.TeamID == -1 ? "NULL" : $"{result.TeamID}";
            string position = result.Position == -1 ? "NULL" : $"{result.Position}";
            string score = result.Score == -1f ? "NULL" : $"{result.Score}";
            string remarks = string.IsNullOrEmpty(result.Remarks) ? "NULL" : $"'{result.Remarks}'";

            string query = $"INSERT INTO event_results (event_id, participant_id, team_id, position, score, remarks) VALUES ({eventID}, {participantID}, {teamID}, {position}, {score}, {remarks})";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public List<EventResult> GetAllEventResults()
        {
            List<EventResult> results = new List<EventResult>();
            string query = "SELECT * FROM event_results";
            var reader = DatabaseHelper.Instance.getData(query);

            while (reader.Read())
            {
                int resultID = reader.GetInt32("result_id");
                int eventID = reader.IsDBNull(reader.GetOrdinal("event_id")) ? -1 : reader.GetInt32("event_id");
                int participantID = reader.IsDBNull(reader.GetOrdinal("participant_id")) ? -1 : reader.GetInt32("participant_id");
                int teamID = reader.IsDBNull(reader.GetOrdinal("team_id")) ? -1 : reader.GetInt32("team_id");
                int position = reader.IsDBNull(reader.GetOrdinal("position")) ? -1 : reader.GetInt32("position");
                float score = reader.IsDBNull(reader.GetOrdinal("score")) ? -1 : reader.GetFloat("score");
                string remarks = reader.IsDBNull(reader.GetOrdinal("remarks")) ? "" : reader.GetString("remarks");
                results.Add(new EventResult(resultID, eventID, participantID, teamID, position, score, remarks));
            }
            reader.Close();
            return results;
        }

        static public EventResult GetEventResultByID(int ID)
        {
            string query = $"SELECT * FROM event_results WHERE result_id = {ID}";
            var reader = DatabaseHelper.Instance.getData(query);

            if (reader.Read())
            {
                int eventID = reader.IsDBNull(reader.GetOrdinal("event_id")) ? -1 : reader.GetInt32("event_id");
                int participantID = reader.IsDBNull(reader.GetOrdinal("participant_id")) ? -1 : reader.GetInt32("participant_id");
                int teamID = reader.IsDBNull(reader.GetOrdinal("team_id")) ? -1 : reader.GetInt32("team_id");
                int position = reader.IsDBNull(reader.GetOrdinal("position")) ? -1 : reader.GetInt32("position");
                float score = reader.IsDBNull(reader.GetOrdinal("score")) ? -1 : reader.GetFloat("score");
                string remarks = reader.IsDBNull(reader.GetOrdinal("remarks")) ? "" : reader.GetString("remarks");

                EventResult result = new EventResult(ID, eventID, participantID, teamID, position, score, remarks);
                reader.Close();
                return result;
            }
            else
                return null;
        }

        static public int DeleteEventResult(int ID)
        {
            string query = $"DELETE FROM event_results WHERE result_id = {ID}";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public int UpdateEventResult(EventResult result)
        {
            string query = $"UPDATE event_results SET event_id = {result.EventID}, participant_id = {result.ParticipantID}, team_id = {result.TeamID}, position = {result.Position}, score = {result.Score}, remarks = '{result.Remarks}' WHERE result_id = {result.ResultID}";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public List<EventResult> GetEventResultsByEventID(int ID)
        {
            string query = $"SELECT * FROM event_results WHERE event_id = {ID}";
            return GetEventResultsByQuery(query);
        }

        static public List<EventResult> GetEventResultsByNullEventID()
        {
            string query = "SELECT * FROM event_results WHERE event_id IS NULL";
            return GetEventResultsByQuery(query);
        }

        static public List<EventResult> GetEventResultsByParticipantID(int ID)
        {
            string query = $"SELECT * FROM event_results WHERE participant_id = {ID}";
            return GetEventResultsByQuery(query);
        }

        static public List<EventResult> GetEventResultsByNullParticipantID()
        {
            string query = "SELECT * FROM event_results WHERE participant_id IS NULL";
            return GetEventResultsByQuery(query);
        }

        static public List<EventResult> GetEventResultsByTeamID(int ID)
        {
            string query = $"SELECT * FROM event_results WHERE team_id = {ID}";
            return GetEventResultsByQuery(query);
        }

        static public List<EventResult> GetEventResultsByNullTeamID()
        {
            string query = "SELECT * FROM event_results WHERE team_id IS NULL";
            return GetEventResultsByQuery(query);
        }

        static public List<EventResult> GetEventResultsByPosition(int position)
        {
            string query = $"SELECT * FROM event_results WHERE position = {position}";
            return GetEventResultsByQuery(query);
        }

        static public List<EventResult> GetEventResultsByNullPosition()
        {
            string query = "SELECT * FROM event_results WHERE position IS NULL";
            return GetEventResultsByQuery(query);
        }

        static public List<EventResult> GetEventResultsByScore(float score)
        {
            string query = $"SELECT * FROM event_results WHERE score = {score}";
            return GetEventResultsByQuery(query);
        }

        static public List<EventResult> GetEventResultsByNullScore()
        {
            string query = "SELECT * FROM event_results WHERE score IS NULL";
            return GetEventResultsByQuery(query);
        }

        static public List<EventResult> GetEventResultsByRemarks(string remark)
        {
            string query = $"SELECT * FROM event_results WHERE remarks LIKE '%{remark}%'";
            return GetEventResultsByQuery(query);
        }

        static public List<EventResult> GetEventResultsByNullRemarks()
        {
            string query = "SELECT * FROM event_results WHERE remarks IS NULL";
            return GetEventResultsByQuery(query);
        }

        static private List<EventResult> GetEventResultsByQuery(string query)
        {
            List<EventResult> results = new List<EventResult>();
            var reader = DatabaseHelper.Instance.getData(query);

            while (reader.Read())
            {
                int resultID = reader.GetInt32("result_id");
                int eventID = reader.IsDBNull(reader.GetOrdinal("event_id")) ? -1 : reader.GetInt32("event_id");
                int participantID = reader.IsDBNull(reader.GetOrdinal("participant_id")) ? -1 : reader.GetInt32("participant_id");
                int teamID = reader.IsDBNull(reader.GetOrdinal("team_id")) ? -1 : reader.GetInt32("team_id");
                int position = reader.IsDBNull(reader.GetOrdinal("position")) ? -1 : reader.GetInt32("position");
                float score = reader.IsDBNull(reader.GetOrdinal("score")) ? -1 : reader.GetFloat("score");
                string remarks = reader.IsDBNull(reader.GetOrdinal("remarks")) ? "" : reader.GetString("remarks");

                results.Add(new EventResult(resultID, eventID, participantID, teamID, position, score, remarks));
            }
            reader.Close();
            return results;
        }


    }
}
