using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEC_Event_Management_System.BL;
using MySql.Data.MySqlClient;

namespace ITEC_Event_Management_System.DL
{
    static public class ParticipantDL
    {
        static public List<Participant> GetAllParticipants()
        {
            List<Participant> participants = new List<Participant>();

            string query = "SELECT * FROM Participants";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while(reader.Read())
            {
                int ITECID = reader.IsDBNull(reader.GetOrdinal("itec_id")) ? -1 : reader.GetOrdinal("itec_id");
                string contact = reader.IsDBNull(reader.GetOrdinal("contact")) ? null : reader.GetString(reader.GetOrdinal("contact"));
                string institute = reader.IsDBNull(reader.GetOrdinal("institute")) ? null : reader.GetString(reader.GetOrdinal("institute"));
                int roleID = reader.IsDBNull(reader.GetOrdinal("role_id")) ? -1 : reader.GetOrdinal("role_id");

                participants.Add(new Participant(reader.GetInt32("participant_id"), ITECID, reader.GetString("name"), reader.GetString("email"), contact, institute, roleID));
            }
            reader.Close();
            return participants;
        }
    }
}
