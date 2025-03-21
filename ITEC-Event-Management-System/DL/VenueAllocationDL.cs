using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ITEC_Event_Management_System.BL;
using System.Xml;
using System.Windows.Forms;
using System.Data;

namespace ITEC_Event_Management_System.DL
{
    static public class VenueAllocationDL
    {
        static public List<VenueAllocation> GetAllVenueAllocations()
        {
            List<VenueAllocation> venueAllocations = new List<VenueAllocation>();
            string query = "SELECT * FROM Venue_Allocations";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int eventID = reader.IsDBNull(reader.GetOrdinal("Event_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Event_ID"));
                int venueID = reader.IsDBNull(reader.GetOrdinal("Venue_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Venue_ID"));
                VenueAllocation venueAllocation = new VenueAllocation(reader.GetInt32(0), eventID, venueID, reader.GetDateTime(3), reader.GetTimeSpan(4));
                venueAllocations.Add(venueAllocation);
            }
            reader.Close();
            return venueAllocations;
        }

        static public int StoreVenueAllocation(VenueAllocation venueAllocation)
        {
            string query = "INSERT INTO Venue_Allocations (Event_ID, Venue_ID, Assigned_Date, Assigned_Time) VALUES (";
            query += venueAllocation.EventID == -1 ? "NULL" : venueAllocation.EventID.ToString();
            query += ", ";
            query += venueAllocation.VenueID == -1 ? "NULL" : venueAllocation.VenueID.ToString();
            query += ", '";
            query += venueAllocation.AssignedDate.ToString("yyyy-MM-dd");
            query += "', '";
            query += venueAllocation.AssignedTime.ToString();
            query += "')";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public VenueAllocation GetVenueAllocationByID(int allocationID)
        {

            string query = "SELECT * FROM Venue_Allocations WHERE venue_allocation_ID = " + allocationID;
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                int eventID = reader.IsDBNull(reader.GetOrdinal("Event_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Event_ID"));
                int venueID = reader.IsDBNull(reader.GetOrdinal("Venue_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Venue_ID"));
                VenueAllocation venueAllocation = new VenueAllocation(reader.GetInt32(0), eventID, venueID, reader.GetDateTime(3), reader.GetTimeSpan(4));
                reader.Close();
                return venueAllocation;
            }
            else
            {
                return null;
            }
        }

        static public int UpdateVenueAllocation(VenueAllocation venueAllocation)
        {
            string eventID = venueAllocation.EventID == -1 ? "NULL" : $"'{venueAllocation.EventID}'";
            string venueID = venueAllocation.VenueID == -1 ? "NULL" : $"'{venueAllocation.VenueID}'";
            string query = $"UPDATE Venue_Allocations SET Event_ID = {eventID}, Venue_ID = {venueID}, Assigned_Date = '{venueAllocation.AssignedDate.ToString("yyyy-MM-dd")}', Assigned_Time = '{venueAllocation.AssignedTime.ToString()}' WHERE Venue_Allocation_ID = {venueAllocation.AllocationID}";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public int DeleteVenueAllocation(int eventID)
        {
            string query = "DELETE FROM Venue_Allocations WHERE Venue_Allocation_ID = " + eventID;
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public List<VenueAllocation> GetVenueAllocationsByEventID(int eventID)
        {
            List<VenueAllocation> venueAllocations = new List<VenueAllocation>();
            string query = "SELECT * FROM Venue_Allocations WHERE Event_ID = " + eventID;
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int venueID = reader.IsDBNull(reader.GetOrdinal("Venue_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Venue_ID"));
                VenueAllocation venueAllocation = new VenueAllocation(reader.GetInt32(0), eventID, venueID, reader.GetDateTime(3), reader.GetTimeSpan(4));
                venueAllocations.Add(venueAllocation);
            }
            reader.Close();
            return venueAllocations;
        }

        static public List<VenueAllocation> GetVenueAllocationsByNullEventID()
        {
            List<VenueAllocation> venueAllocations = new List<VenueAllocation>();
            string query = "SELECT * FROM Venue_Allocations WHERE Event_ID IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int eventID = reader.IsDBNull(reader.GetOrdinal("Event_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Event_ID"));
                int venueID = reader.IsDBNull(reader.GetOrdinal("Venue_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Venue_ID"));
                VenueAllocation venueAllocation = new VenueAllocation(reader.GetInt32(0), eventID, venueID, reader.GetDateTime(3), reader.GetTimeSpan(4));
                venueAllocations.Add(venueAllocation);
            }
            reader.Close();
            return venueAllocations;
        }

        static public List<VenueAllocation> GetVenueAllocationsByVenueID(int venueID)
        {
            List<VenueAllocation> venueAllocations = new List<VenueAllocation>();
            string query = "SELECT * FROM Venue_Allocations WHERE Venue_ID = " + venueID;
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int eventID = reader.IsDBNull(reader.GetOrdinal("Event_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Event_ID"));
                VenueAllocation venueAllocation = new VenueAllocation(reader.GetInt32(0), eventID, venueID, reader.GetDateTime(3), reader.GetTimeSpan(4));
                venueAllocations.Add(venueAllocation);
            }
            reader.Close();
            return venueAllocations;
        }

        static public List<VenueAllocation> GetVenueAllocationsByNullVenueID()
        {
            List<VenueAllocation> venueAllocations = new List<VenueAllocation>();
            string query = "SELECT * FROM Venue_Allocations WHERE Venue_ID IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int eventID = reader.IsDBNull(reader.GetOrdinal("Event_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Event_ID"));
                int venueID = reader.IsDBNull(reader.GetOrdinal("Venue_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Venue_ID"));
                VenueAllocation venueAllocation = new VenueAllocation(reader.GetInt32(0), eventID, venueID, reader.GetDateTime(3), reader.GetTimeSpan(4));
                venueAllocations.Add(venueAllocation);
            }
            reader.Close();
            return venueAllocations;
        }

        static public List<VenueAllocation> GetVenueAllocationsByDateandTime(VenueAllocation venueAllocation)
        {
            List<VenueAllocation> venueAllocations = new List<VenueAllocation>();
            string query = "SELECT * FROM Venue_Allocations WHERE Assigned_Date = '" + venueAllocation.AssignedDate.ToString("yyyy-MM-dd") + "' AND Assigned_Time = '" + venueAllocation.AssignedTime.ToString() + "'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int eventID = reader.IsDBNull(reader.GetOrdinal("Event_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Event_ID"));
                int venueID = reader.IsDBNull(reader.GetOrdinal("Venue_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Venue_ID"));
                VenueAllocation venueAllocation1 = new VenueAllocation(reader.GetInt32(0), eventID, venueID, reader.GetDateTime(3), reader.GetTimeSpan(4));
                venueAllocations.Add(venueAllocation1);
            }
            reader.Close();
            return venueAllocations;
        }

        static public List<VenueAllocation> GetVenueAllocationsByDate(DateTime date)
        {
            List<VenueAllocation> venueAllocations = new List<VenueAllocation>();
            string query = "SELECT * FROM Venue_Allocations WHERE Assigned_Date = '" + date.ToString("yyyy-MM-dd") + "'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int eventID = reader.IsDBNull(reader.GetOrdinal("Event_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Event_ID"));
                int venueID = reader.IsDBNull(reader.GetOrdinal("Venue_ID")) ? -1 : reader.GetInt32(reader.GetOrdinal("Venue_ID"));
                VenueAllocation venueAllocation = new VenueAllocation(reader.GetInt32(0), eventID, venueID, reader.GetDateTime(3), reader.GetTimeSpan(4));
                venueAllocations.Add(venueAllocation);
            }
            reader.Close();
            return venueAllocations;
        }

        static public DataTable GetVenueAllocationsConflict()
        {
            string query = "SELECT V1.Venue_Allocation_ID AS ID_1, V1.event_ID AS EventID_1, V2.Venue_Allocation_ID ID_2, V2.event_ID EventID_2, V1.venue_id AS VenueID, V1.assigned_date AS Date, V1.assigned_time AS Time FROM venue_allocations V1 INNER JOIN venue_allocations V2 ON V1.venue_id = V2.venue_id AND V1.assigned_date = V2.assigned_date AND V1.assigned_time = V2.assigned_time WHERE V1.venue_allocation_id < V2.venue_allocation_ID";

            //string query = "SELECT V1.Venue_Allocation_ID, V1.event_ID, V2.Venue_Allocation_ID, V2.event_ID, V1.venue_id, V1.assigned_date, V1.assigned_time FROM venue_allocations V1 INNER JOIN venue_allocations V2 ON V1.venue_id = V2.venue_id AND V1.assigned_date = V2.assigned_date AND V1.assigned_time = V2.assigned_time WHERE V1.venue_allocation_id < V2.venue_allocation_ID";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DatabaseHelper.Instance.getConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
