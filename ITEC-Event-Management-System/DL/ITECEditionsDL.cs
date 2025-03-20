using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ITEC_Event_Management_System.BL;

namespace ITEC_Event_Management_System.DL
{
    static public class ITECEditionsDL
    {
        static public List<ITECEdition> GetAllEditions()
        {
            List<ITECEdition> editions = new List<ITECEdition>();
            string query = $"SELECT * FROM ITEC_Editions";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {

                //int itecId = reader.IsDBNull(reader.GetOrdinal("itec_id")) ? -1 : reader.GetInt32("itec_id");
                //string theme = reader.IsDBNull(reader.GetOrdinal("theme")) ? null : reader.GetString("theme");
                //string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");
                string theme = reader.IsDBNull(2) ? null : reader.GetString(2);
                string description = reader.IsDBNull(3) ? null : reader.GetString(3);
                editions.Add(new ITECEdition(reader.GetInt32(0), reader.GetInt32(1), theme, description));
            }
            return editions;
        }
    }
}
