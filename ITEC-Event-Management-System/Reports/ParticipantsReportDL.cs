using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.Reports
{
    static public class ParticipantsReportDL
    {
        static public List<ParticipantClass> GetByITECID(int ID)
        {
            string query = $"SELECT * FROM Participants WHERE itec_id = {ID}";
            var reader = DatabaseHelper.Instance.getData(query);

            List<ParticipantClass> participants = new List<ParticipantClass>();
            while (reader.Read())
            {
                ParticipantClass participant = new ParticipantClass();
                participant.ID = reader.GetInt32("participant_id");
                participant.ITECID = reader.IsDBNull(reader.GetOrdinal("itec_id")) ? -1 : reader.GetInt32("itec_id");
                participant.name = reader.GetString("name");
                participant.email = reader.IsDBNull(reader.GetOrdinal("email")) ? "NULL" : reader.GetString("email");
                participant.contact = reader.IsDBNull(reader.GetOrdinal("contact")) ? "NULL" : reader.GetString("contact");
                participant.institute = reader.IsDBNull(reader.GetOrdinal("institute")) ? "NULL" : reader.GetString("institute");
                participant.roleID = reader.IsDBNull(reader.GetOrdinal("role_id")) ? -1 : reader.GetInt32("role_id");
                participants.Add(participant);
            }
            return participants;
        }

        static public List<ParticipantClass> GetByRoleID(int ID)
        {
            string query = $"SELECT * FROM Participants WHERE role_id = {ID}";
            var reader = DatabaseHelper.Instance.getData(query);

            List<ParticipantClass> participants = new List<ParticipantClass>();
            while (reader.Read())
            {
                ParticipantClass participant = new ParticipantClass();
                participant.ID = reader.GetInt32("participant_id");
                participant.ITECID = reader.IsDBNull(reader.GetOrdinal("itec_id")) ? -1 : reader.GetInt32("itec_id");
                participant.name = reader.GetString("name");
                participant.email = reader.IsDBNull(reader.GetOrdinal("email")) ? "NULL" : reader.GetString("email");
                participant.contact = reader.IsDBNull(reader.GetOrdinal("contact")) ? "NULL" : reader.GetString("contact");
                participant.institute = reader.IsDBNull(reader.GetOrdinal("institute")) ? "NULL" : reader.GetString("institute");
                participant.roleID = reader.IsDBNull(reader.GetOrdinal("role_id")) ? -1 : reader.GetInt32("role_id");
                participants.Add(participant);
            }
            return participants;
        }

        static public List<ParticipantClass> GetByEventID(int ID)
        {
            string query = $"SELECT DISTINCT p.participant_id, p.itec_id, p.name, p.email, p.contact, p.institute, p.role_id FROM event_participants e INNER JOIN participants p ON e.participant_id = p.participant_id WHERE e.event_id = {ID}";
            var reader = DatabaseHelper.Instance.getData(query);

            List<ParticipantClass> participants = new List<ParticipantClass>();
            while (reader.Read())
            {
                ParticipantClass participant = new ParticipantClass();
                participant.ID = reader.GetInt32("participant_id");
                participant.ITECID = reader.IsDBNull(reader.GetOrdinal("itec_id")) ? -1 : reader.GetInt32("itec_id");
                participant.name = reader.GetString("name");
                participant.email = reader.IsDBNull(reader.GetOrdinal("email")) ? "NULL" : reader.GetString("email");
                participant.contact = reader.IsDBNull(reader.GetOrdinal("contact")) ? "NULL" : reader.GetString("contact");
                participant.institute = reader.IsDBNull(reader.GetOrdinal("institute")) ? "NULL" : reader.GetString("institute");
                participant.roleID = reader.IsDBNull(reader.GetOrdinal("role_id")) ? -1 : reader.GetInt32("role_id");
                participants.Add(participant);
            }
            return participants;
        }
    }
}
