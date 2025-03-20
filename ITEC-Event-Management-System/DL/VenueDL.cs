using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEC_Event_Management_System.BL;
using MySql.Data.MySqlClient;

namespace ITEC_Event_Management_System.DL
{
    static public class VenueDL
    {
        static public List<Venue> GetAllVenues()
        {
            List<Venue> venues = new List<Venue>();
            string query = $"SELECT * FROM Venues";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                string location = reader.IsDBNull(3) ? null : reader.GetString(3);
                venues.Add(new Venue(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), location));
            }
            return venues;
        }
    }
}
