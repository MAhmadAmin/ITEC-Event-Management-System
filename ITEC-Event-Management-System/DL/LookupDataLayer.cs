using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ITEC_Event_Management_System
{
    static public class LookupDataLayer
    {
        static public List<Lookup> GetIDsByCategory(string category)
        {
            List<Lookup> lookups = new List<Lookup>();

            string query = $"SELECT * FROM Lookup WHERE category = '{category}'";

            //MySqlConnection connection = DatabaseHelper.Instance.getConnection();
            //connection.Open();
            MySqlCommand command = new MySqlCommand(query, DatabaseHelper.Instance.getConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Lookup lookup = new Lookup();
                lookup.ID = reader.GetInt32("lookup_id");
                lookup.category = reader.GetString("category");
                lookup.value = reader.GetString("value");
                lookups.Add(lookup);
            }

            return lookups;
        }
    }
}
