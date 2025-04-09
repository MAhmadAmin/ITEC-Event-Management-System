using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.Reports
{
    static public class EventScheduleDL
    {
        static public List<EventScheduleDataClass> GetData(int ITECID)
        {
            string query = $"SELECT e.event_id, e.event_name, va.assigned_date, va.assigned_time, v.venue_name, v.location FROM itec_events e INNER JOIN venue_allocations va ON e.event_id = va.event_id INNER JOIN venues v ON va.venue_id = v.venue_id WHERE e.itec_id = {ITECID}";
            var reader = DatabaseHelper.Instance.getData(query);
            List<EventScheduleDataClass> data = new List<EventScheduleDataClass>();
            while (reader.Read())
            {
                data.Add(new EventScheduleDataClass()
                {
                    //EventID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    //EventName = reader.GetString(1),
                    //Date = reader.GetDateTime(2).ToString(),
                    //Time = reader.GetTimeSpan(3).ToString(),
                    //Venue = reader.GetDateTime(4).ToString(),
                    //Location = reader.IsDBNull(5) ? "NULL" : reader.GetString(5)


                    EventID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    EventName = reader.GetString(1),
                    Date = reader.IsDBNull(2) ? null : reader.GetDateTime(2).ToString("yy-MM-dd"),
                    Time = reader.IsDBNull(3) ? null : reader.GetTimeSpan(3).ToString(),
                    Venue = reader.GetString(4),
                    Location = reader.IsDBNull(5) ? "NULL" : reader.GetString(5)
                });
            }
            reader.Close();
            return data;
        }
    }
}
