using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;

namespace ITEC_Event_Management_System.DL
{
    static public class EventDL
    {
        static public List<Event> GetAllEvents()
        {
            List<Event> events = new List<Event>();
            string query = "SELECT * FROM itec_events";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? "NULL" : reader.GetString("description");
                int ITECID = reader.IsDBNull(reader.GetOrdinal("ITEC_ID")) ? -1 : reader.GetInt32("ITEC_ID");
                int categoryID = reader.IsDBNull(reader.GetOrdinal("event_category_id")) ? -1 : reader.GetInt32("event_category_id");
                int venueID = reader.IsDBNull(reader.GetOrdinal("venue_ID")) ? -1 : reader.GetInt32("venue_ID");
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_ID")) ? -1 : reader.GetInt32("committee_ID");

                events.Add(new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), date, description, ITECID, categoryID, venueID, committeeID));
            }
            return events;
        }

        static public int StoreEvent(Event e)
        {
            string descriptionValue = string.IsNullOrWhiteSpace(e.description) ? "NULL" : $"'{e.description}'";
            string ITECIDValue = e.ITECID == -1 ? "Null" : e.ITECID.ToString();
            string categoryIDValue = e.categoryID == -1 ? "Null" : e.categoryID.ToString();
            string venueIDValue = e.venueID == -1 ? "Null" : e.venueID.ToString();
            string committeeIDValue = e.committeeID == -1 ? "Null" : e.committeeID.ToString();
            string query = $"INSERT INTO itec_events (event_name, event_date, description, ITEC_ID, event_category_id, venue_ID, committee_ID) VALUES ('{e.name}', '{e.date.ToString("yyyy-MM-dd")}', {descriptionValue}, {ITECIDValue}, {categoryIDValue}, {venueIDValue}, {committeeIDValue})";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public Event GetEventByID(int id)
        {
            string query = $"SELECT * FROM itec_events WHERE event_id = {id}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                DateTime date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? "NULL" : reader.GetString("description");
                int ITECID = reader.IsDBNull(reader.GetOrdinal("ITEC_ID")) ? -1 : reader.GetInt32("ITEC_ID");
                int categoryID = reader.IsDBNull(reader.GetOrdinal("event_category_id")) ? -1 : reader.GetInt32("event_category_id");
                int venueID = reader.IsDBNull(reader.GetOrdinal("venue_ID")) ? -1 : reader.GetInt32("venue_ID");
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_ID")) ? -1 : reader.GetInt32("committee_ID");
                return new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), date, description, ITECID, categoryID, venueID, committeeID);
            }
            return null;
        }

        public static int UpdateEvent(Event e)
        {
            string checkQuery = $"SELECT * FROM itec_events WHERE event_id = {e.ID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(checkQuery);
            if (!reader.Read())
            {
                return -1;
            }

            string nameValue = string.IsNullOrWhiteSpace(e.name) ? reader.GetString("event_name") : e.name;
            string descriptionValue = string.IsNullOrWhiteSpace(e.description) ? "NULL" : $"'{e.description}'";
            string ITECIDValue = e.ITECID == -1 ? "Null" : e.ITECID.ToString();
            string categoryIDValue = e.categoryID == -1 ? "Null" : e.categoryID.ToString();
            string venueIDValue = e.venueID == -1 ? "Null" : e.venueID.ToString();
            string committeeIDValue = e.committeeID == -1 ? "Null" : e.committeeID.ToString();
            string query = $"UPDATE itec_events SET event_name = '{nameValue}', event_date = '{e.date.ToString("yyyy-MM-dd")}', description = {descriptionValue}, ITEC_ID = {ITECIDValue}, event_category_id = {categoryIDValue}, venue_ID = {venueIDValue}, committee_ID = {committeeIDValue} WHERE event_id = {e.ID}";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        public static int DeleteEvent(int id)
        {
            string query = $"DELETE FROM itec_events WHERE event_id = {id}";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public List<Event> GetEventsByNameLike(string name)
        {
            List<Event> events = new List<Event>();
            string query = $"SELECT * FROM itec_events WHERE event_name LIKE '%{name}%'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");
                int ITECID = reader.IsDBNull(reader.GetOrdinal("ITEC_ID")) ? -1 : reader.GetInt32("ITEC_ID");
                int categoryID = reader.IsDBNull(reader.GetOrdinal("event_category_id")) ? -1 : reader.GetInt32("event_category_id");
                int venueID = reader.IsDBNull(reader.GetOrdinal("venue_ID")) ? -1 : reader.GetInt32("venue_ID");
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_ID")) ? -1 : reader.GetInt32("committee_ID");
                events.Add(new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), date, description, ITECID, categoryID, venueID, committeeID));
            }
            return events;
        }

        static public List<Event> GetEventsByDate(DateTime date)
        {
            List<Event> events = new List<Event>();
            string query = $"SELECT * FROM itec_events WHERE event_date = '{date.ToString("yyyy-MM-dd")}'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime eventDate = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");
                int ITECID = reader.IsDBNull(reader.GetOrdinal("ITEC_ID")) ? -1 : reader.GetInt32("ITEC_ID");
                int categoryID = reader.IsDBNull(reader.GetOrdinal("event_category_id")) ? -1 : reader.GetInt32("event_category_id");
                int venueID = reader.IsDBNull(reader.GetOrdinal("venue_ID")) ? -1 : reader.GetInt32("venue_ID");
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_ID")) ? -1 : reader.GetInt32("committee_ID");
                events.Add(new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), eventDate, description, ITECID, categoryID, venueID, committeeID));
            }
            return events;
        }

        static public List<Event> GetEventsByDescriptionLike(string description)
        {
            List<Event> events = new List<Event>();
            string query = $"SELECT * FROM itec_events WHERE description LIKE '%{description}%'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                string eventDescription = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");
                int ITECID = reader.IsDBNull(reader.GetOrdinal("ITEC_ID")) ? -1 : reader.GetInt32("ITEC_ID");
                int categoryID = reader.IsDBNull(reader.GetOrdinal("event_category_id")) ? -1 : reader.GetInt32("event_category_id");
                int venueID = reader.IsDBNull(reader.GetOrdinal("venue_ID")) ? -1 : reader.GetInt32("venue_ID");
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_ID")) ? -1 : reader.GetInt32("committee_ID");
                events.Add(new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), date, eventDescription, ITECID, categoryID, venueID, committeeID));
            }
            return events;
        }

        static public List<Event> GetEventsByNullDescription()
        {
            List<Event> events = new List<Event>();
            string query = $"SELECT * FROM itec_events WHERE description IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                int ITECID = reader.IsDBNull(reader.GetOrdinal("ITEC_ID")) ? -1 : reader.GetInt32("ITEC_ID");
                int categoryID = reader.IsDBNull(reader.GetOrdinal("event_category_id")) ? -1 : reader.GetInt32("event_category_id");
                int venueID = reader.IsDBNull(reader.GetOrdinal("venue_ID")) ? -1 : reader.GetInt32("venue_ID");
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_ID")) ? -1 : reader.GetInt32("committee_ID");
                events.Add(new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), date, null, ITECID, categoryID, venueID, committeeID));
            }
            return events;
        }

        static public List<Event> GetEventsByITECID(int ITECID)
        {
            List<Event> events = new List<Event>();
            string query = $"SELECT * FROM itec_events WHERE ITEC_ID = {ITECID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");
                int categoryID = reader.IsDBNull(reader.GetOrdinal("event_category_id")) ? -1 : reader.GetInt32("event_category_id");
                int venueID = reader.IsDBNull(reader.GetOrdinal("venue_ID")) ? -1 : reader.GetInt32("venue_ID");
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_ID")) ? -1 : reader.GetInt32("committee_ID");
                events.Add(new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), date, description, ITECID, categoryID, venueID, committeeID));
            }
            return events;
        }
        
        static public List<Event> GetEventsByNullITECID()
        {
            List<Event> events = new List<Event>();
            string query = $"SELECT * FROM itec_events WHERE ITEC_ID IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");
                int ITECID = reader.IsDBNull(reader.GetOrdinal("ITEC_ID")) ? -1 : reader.GetInt32("ITEC_ID");
                int categoryID = reader.IsDBNull(reader.GetOrdinal("event_category_id")) ? -1 : reader.GetInt32("event_category_id");
                int venueID = reader.IsDBNull(reader.GetOrdinal("venue_ID")) ? -1 : reader.GetInt32("venue_ID");
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_ID")) ? -1 : reader.GetInt32("committee_ID");
                events.Add(new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), date, description, ITECID, categoryID, venueID, committeeID));
            }
            return events;
        }

        static public List<Event> GetEventsByCategoryID(int categoryID)
        {
            List<Event> events = new List<Event>();
            string query = $"SELECT * FROM itec_events WHERE event_category_id = {categoryID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");
                int ITECID = reader.IsDBNull(reader.GetOrdinal("ITEC_ID")) ? -1 : reader.GetInt32("ITEC_ID");
                int venueID = reader.IsDBNull(reader.GetOrdinal("venue_ID")) ? -1 : reader.GetInt32("venue_ID");
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_ID")) ? -1 : reader.GetInt32("committee_ID");
                events.Add(new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), date, description, ITECID, categoryID, venueID, committeeID));
            }
            return events;
        }

        static public List<Event> GetEventsByNullCategoryID()
        {
            List<Event> events = new List<Event>();
            string query = $"SELECT * FROM itec_events WHERE event_category_id IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");
                int ITECID = reader.IsDBNull(reader.GetOrdinal("ITEC_ID")) ? -1 : reader.GetInt32("ITEC_ID");
                int venueID = reader.IsDBNull(reader.GetOrdinal("venue_ID")) ? -1 : reader.GetInt32("venue_ID");
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_ID")) ? -1 : reader.GetInt32("committee_ID");
                events.Add(new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), date, description, ITECID, -1, venueID, committeeID));
            }
            return events;
        }

        static public List<Event> GetEventsByVenueID(int venueID)
        {
            List<Event> events = new List<Event>();
            string query = $"SELECT * FROM itec_events WHERE venue_ID = {venueID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");
                int ITECID = reader.IsDBNull(reader.GetOrdinal("ITEC_ID")) ? -1 : reader.GetInt32("ITEC_ID");
                int categoryID = reader.IsDBNull(reader.GetOrdinal("event_category_id")) ? -1 : reader.GetInt32("event_category_id");
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_ID")) ? -1 : reader.GetInt32("committee_ID");
                events.Add(new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), date, description, ITECID, categoryID, venueID, committeeID));
            }
            return events;
        }

        static public List<Event> GetEventsByNullVenueID()
        {
            List<Event> events = new List<Event>();
            string query = $"SELECT * FROM itec_events WHERE venue_ID IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");
                int ITECID = reader.IsDBNull(reader.GetOrdinal("ITEC_ID")) ? -1 : reader.GetInt32("ITEC_ID");
                int categoryID = reader.IsDBNull(reader.GetOrdinal("event_category_id")) ? -1 : reader.GetInt32("event_category_id");
                int committeeID = reader.IsDBNull(reader.GetOrdinal("committee_ID")) ? -1 : reader.GetInt32("committee_ID");
                events.Add(new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), date, description, ITECID, categoryID, -1, committeeID));
            }
            return events;
        }

        static public List<Event> GetEventsByCommitteeID(int committeeID)
        {
            List<Event> events = new List<Event>();
            string query = $"SELECT * FROM itec_events WHERE committee_ID = {committeeID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");
                int ITECID = reader.IsDBNull(reader.GetOrdinal("ITEC_ID")) ? -1 : reader.GetInt32("ITEC_ID");
                int categoryID = reader.IsDBNull(reader.GetOrdinal("event_category_id")) ? -1 : reader.GetInt32("event_category_id");
                int venueID = reader.IsDBNull(reader.GetOrdinal("venue_ID")) ? -1 : reader.GetInt32("venue_ID");
                int committeeIDValue = reader.IsDBNull(reader.GetOrdinal("committee_ID")) ? -1 : reader.GetInt32("committee_ID");
                events.Add(new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), date, description, ITECID, categoryID, venueID, committeeIDValue));
            }
            return events;
        }

        static public List<Event> GetEventsByNullCommitteeID()
        {
            List<Event> events = new List<Event>();
            string query = $"SELECT * FROM itec_events WHERE committee_ID IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                DateTime date = reader.IsDBNull(reader.GetOrdinal("event_date")) ? new DateTime(0000, 00, 00) : reader.GetDateTime("event_date");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");
                int ITECID = reader.IsDBNull(reader.GetOrdinal("ITEC_ID")) ? -1 : reader.GetInt32("ITEC_ID");
                int categoryID = reader.IsDBNull(reader.GetOrdinal("event_category_id")) ? -1 : reader.GetInt32("event_category_id");
                int venueID = reader.IsDBNull(reader.GetOrdinal("venue_ID")) ? -1 : reader.GetInt32("venue_ID");
                events.Add(new Event(reader.GetInt32("event_id"), reader.GetString("event_name"), date, description, ITECID, categoryID, venueID, -1));
            }
            return events;
        }
    }
}
