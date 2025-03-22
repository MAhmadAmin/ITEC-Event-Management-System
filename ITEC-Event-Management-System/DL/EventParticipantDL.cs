using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEC_Event_Management_System.BL;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Tls;

namespace ITEC_Event_Management_System.DL
{
    static public class EventParticipantDL
    {
        static public int StoreEventParticipant(EventParticipant participant)
        {
            string eventID = participant.EventID == -1 ? "NULL" : $"{participant.EventID}";
            string participantID = participant.ParticipantID == -1 ? "NULL" : $"{participant.ParticipantID}";
            string paymentStatusID = participant.PaymentStatusID == -1 ? "NULL" : $"{participant.PaymentStatusID}";
            string feeAmount = participant.FeeAmount == -1 ? "NULL" : $"{participant.FeeAmount}";

            string query = $"INSERT INTO event_participants (event_id, participant_id, payment_status_id, fee_amount) VALUE ({eventID}, {participantID}, {paymentStatusID}, {feeAmount})";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public List<EventParticipant> GetAllEventParticipants()
        {
            List<EventParticipant> participants = new List<EventParticipant>();

            string query = "SELECT * FROM event_participants";
            var reader = DatabaseHelper.Instance.getData(query);

            while (reader.Read())
            {
                int eventID = reader.IsDBNull(reader.GetOrdinal("event_id")) ? -1 : reader.GetInt32("event_id");
                int participantID = reader.IsDBNull(reader.GetOrdinal("participant_id")) ? -1 : reader.GetInt32("participant_id");
                int paymentStatusID = reader.IsDBNull(reader.GetOrdinal("payment_status_id")) ? -1 : reader.GetInt32("payment_status_id");
                float feeAmount = reader.IsDBNull(reader.GetOrdinal("fee_amount")) ? -1 : reader.GetFloat("fee_amount");
                participants.Add(new EventParticipant(reader.GetInt32("registration_id"),eventID, participantID, paymentStatusID, feeAmount));
            }
            reader.Close();
            return participants;
        }

        static public EventParticipant GetEventParticipantByID(int ID)
        {
            string query = $"SELECT * FROM event_participants WHERE registration_id = {ID}";
            var reader = DatabaseHelper.Instance.getData(query);

            if (reader.Read())
            {
                int eventID = reader.IsDBNull(reader.GetOrdinal("event_id")) ? -1 : reader.GetInt32("event_id");
                int participantID = reader.IsDBNull(reader.GetOrdinal("participant_id")) ? -1 : reader.GetInt32("participant_id");
                int paymentStatusID = reader.IsDBNull(reader.GetOrdinal("payment_status_id")) ? -1 : reader.GetInt32("payment_status_id");
                float feeAmount = reader.IsDBNull(reader.GetOrdinal("fee_amount")) ? -1 : reader.GetFloat("fee_amount");
                EventParticipant participant = new EventParticipant(reader.GetInt32("registration_id"), eventID, participantID, paymentStatusID, feeAmount);
            
                reader.Close();
                return participant;
            }
            else
                return null;
        }  

        static public int DeleteEventParticipant(int ID)
        {
            string checkQuery = $"SELECT * FROM event_participants WHERE registration_id = {ID}";
            MySqlDataReader checkReader = DatabaseHelper.Instance.getData(checkQuery);
            if (checkReader.Read())
            {
                string query = $"DELETE FROM event_participants WHERE registration_id = {ID}";
                return DatabaseHelper.Instance.ExecuteQuery(query);
            }
            else 
                return -1;
        }

        static public int UpdateEventParticipant(EventParticipant participant)
        {
            string checkQuery = $"SELECT * FROM event_participants WHERE registration_id = {participant.RegistrationID}";
            MySqlDataReader checkReader = DatabaseHelper.Instance.getData(checkQuery);
            if (checkReader.Read())
            {
                string eventID = participant.EventID == -1 ? "NULL" : $"{participant.EventID}";
                string participantID = participant.ParticipantID == -1 ? "NULL" : $"{participant.ParticipantID}";
                string paymentStatusID = participant.PaymentStatusID == -1 ? "NULL" : $"{participant.PaymentStatusID}";
                string feeAmount = participant.FeeAmount == -1 ? "NULL" : $"{participant.FeeAmount}";

                string query = $"UPDATE event_participants SET event_id = {eventID}, participant_id = {participantID}, payment_status_id = {paymentStatusID}, fee_amount = {feeAmount} WHERE registration_id = {participant.RegistrationID}";
                return DatabaseHelper.Instance.ExecuteQuery(query);
            }
            else
                return -1;
        }
        static public List<EventParticipant> GetEventParticipantsByEventID(int ID)
        {
            string query = $"SELECT * FROM event_participants WHERE event_id = {ID}";
            return FetchEventParticipants(query);
        }

        static public List<EventParticipant> GetEventParticipantsByNullEventID()
        {
            string query = "SELECT * FROM event_participants WHERE event_id IS NULL";
            return FetchEventParticipants(query);
        }

        static public List<EventParticipant> GetEventParticipantsByParticipantID(int ID)
        {
            string query = $"SELECT * FROM event_participants WHERE participant_id = {ID}";
            return FetchEventParticipants(query);
        }

        static public List<EventParticipant> GetEventParticipantsByNullParticipantID()
        {
            string query = "SELECT * FROM event_participants WHERE participant_id IS NULL";
            return FetchEventParticipants(query);
        }

        static public List<EventParticipant> GetEventParticipantsByPaymentStatusID(int ID)
        {
            string query = $"SELECT * FROM event_participants WHERE payment_status_id = {ID}";
            return FetchEventParticipants(query);
        }

        static public List<EventParticipant> GetEventParticipantsByNullPaymentStatusID()
        {
            string query = "SELECT * FROM event_participants WHERE payment_status_id IS NULL";
            return FetchEventParticipants(query);
        }

        static public List<EventParticipant> GetEventParticipantsByFeeAmount(float amount)
        {
            string query = $"SELECT * FROM event_participants WHERE fee_amount = {amount}";
            return FetchEventParticipants(query);
        }

        static public List<EventParticipant> GetEventParticipantsByNullFeeAmount()
        {
            string query = "SELECT * FROM event_participants WHERE fee_amount IS NULL";
            return FetchEventParticipants(query);
        }

        private static List<EventParticipant> FetchEventParticipants(string query)
        {
            List<EventParticipant> participants = new List<EventParticipant>();
            var reader = DatabaseHelper.Instance.getData(query);

            while (reader.Read())
            {
                int eventID = reader.IsDBNull(reader.GetOrdinal("event_id")) ? -1 : reader.GetInt32("event_id");
                int participantID = reader.IsDBNull(reader.GetOrdinal("participant_id")) ? -1 : reader.GetInt32("participant_id");
                int paymentStatusID = reader.IsDBNull(reader.GetOrdinal("payment_status_id")) ? -1 : reader.GetInt32("payment_status_id");
                float feeAmount = reader.IsDBNull(reader.GetOrdinal("fee_amount")) ? -1 : reader.GetFloat("fee_amount");
                participants.Add(new EventParticipant(reader.GetInt32("registration_id"), eventID, participantID, paymentStatusID, feeAmount));
            }
            reader.Close();
            return participants;
        }

    }
}
