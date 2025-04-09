using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITEC_Event_Management_System.Reports
{
    static public class IncomeAndExpenceDL
    {
        static public List<IncomeAndExpenceDataClass> GetData(int EventID)
        {
            //string query1 = $"SELECT SUM(fee_amount) FROM event_participants Group BY event_id HAVING event_id = {EventID}";
            //MySqlDataReader reader = DatabaseHelper.Instance.getData(query1);

            string query = $"SELECT SUM(amount) FROM finances WHERE event_id = {EventID} Group By type_id UNION SELECT((SELECT SUM(amount) FROM finances WHERE event_id = {EventID} Group By type_id HAVING type_id = 22) + (SELECT SUM(amount) FROM finances WHERE event_id = {EventID} Group By type_id HAVING type_id = 23) - (SELECT SUM(amount) FROM finances WHERE event_id = {EventID} Group By type_id HAVING type_id = 24));";

            var reader = DatabaseHelper.Instance.getData(query);
            List<IncomeAndExpenceDataClass> data = new List<IncomeAndExpenceDataClass>();

            data.Add(new IncomeAndExpenceDataClass() { type = "Event ID", amount = EventID });

            List<string> types = new List<string>()
            {
                "Amount From Sponsors", "Ticket Sales", "Expenses", "Total Income"
            };
            int i = 0;
            for (int j = 1; j <= 4; j++)
            {
                reader.Read();
                IncomeAndExpenceDataClass iae = new IncomeAndExpenceDataClass()
                {
                    type = types[i],
                    amount = reader.IsDBNull(0) ? 0 : reader.GetInt32(0)

                };
                data.Add(iae);
                i++;
            }

            data[4].amount = data[1].amount + data[2].amount - data[3].amount;
            return data;



            //List<IncomeAndExpenceDataClass> data = new List<IncomeAndExpenceDataClass>();

            //data.Add(new IncomeAndExpenceDataClass() { type = "Event ID", amount = EventID });

            //List<string> types = new List<string>()
            //{
            //    "Amount From Sponsors", "Ticket Sales", "Expenses", "Total Income"
            //};
            //int l = 0;

            //string query1 = $"SELECT SUM(amount) FROM finances WHERE event_id = {EventID} Group By type_id";
            //var reader1 = DatabaseHelper.Instance.getData(query1);
            //if(reader1.Read())
            //{
            //    IncomeAndExpenceDataClass iae = new IncomeAndExpenceDataClass()
            //    {
            //        type = types[l],
            //        amount = reader1.IsDBNull(0) ? 0 : reader1.GetInt32(0)

            //    };
            //    data.Add(iae);
            //    l++;
            //}
            //else
            //{
            //    IncomeAndExpenceDataClass iae = new IncomeAndExpenceDataClass()
            //    {
            //        type = types[l],
            //        amount = 0

            //    };
            //    data.Add(iae);
            //    l++;
            //}

            //string query2 = $"SELECT SUM(amount) FROM finances WHERE event_id = {EventID} Group By type_id HAVING type_id = 22";
            //var reader2 = DatabaseHelper.Instance.getData(query2);
            //if (reader2.Read())
            //{
            //    IncomeAndExpenceDataClass iae = new IncomeAndExpenceDataClass()
            //    {
            //        type = types[l],
            //        amount = reader2.IsDBNull(0) ? 0 : reader2.GetInt32(0)

            //    };
            //    data.Add(iae);
            //    l++;
            //    reader2.Close();
            //}
            //else
            //{
            //    IncomeAndExpenceDataClass iae = new IncomeAndExpenceDataClass()
            //    {
            //        type = types[l],
            //        amount = 0

            //    };
            //    data.Add(iae);
            //    l++;
            //}

            //string query3 = $"SELECT SUM(amount) FROM finances WHERE event_id = {EventID} Group By type_id HAVING type_id = 23";
            //var reader3 = DatabaseHelper.Instance.getData(query2);
            //if (reader3.Read())
            //{
            //    IncomeAndExpenceDataClass iae = new IncomeAndExpenceDataClass()
            //    {
            //        type = types[l],
            //        amount = reader3.IsDBNull(0) ? 0 : reader3.GetInt32(0)

            //    };
            //    data.Add(iae);
            //    l++;

            //    reader3.Close();
            //}
            //else
            //{
            //    IncomeAndExpenceDataClass iae = new IncomeAndExpenceDataClass()
            //    {
            //        type = types[l],
            //        amount = 0

            //    };
            //    data.Add(iae);
            //    l++;
            //}

            //string query4 = $"SELECT SUM(amount) FROM finances WHERE event_id = {EventID} Group By type_id HAVING type_id = 24";
            //var reader4 = DatabaseHelper.Instance.getData(query2);
            //if (reader4.Read())
            //{
            //    IncomeAndExpenceDataClass iae = new IncomeAndExpenceDataClass()
            //    {
            //        type = types[l],
            //        amount = reader4.IsDBNull(0) ? 0 : reader4.GetInt32(0)

            //    };
            //    data.Add(iae);
            //    l++;
            //    reader4.Close();
            //}
            //else
            //{
            //    IncomeAndExpenceDataClass iae = new IncomeAndExpenceDataClass()
            //    {
            //        type = types[l],
            //        amount = 0

            //    };
            //    data.Add(iae);
            //    l++;
            //}

            //IncomeAndExpenceDataClass abc = new IncomeAndExpenceDataClass()
            //{
            //    type = types[l],
            //    amount = 0

            //};
            //data.Add(abc);
            //l++;



            //data[4].amount = data[1].amount + data[2].amount - data[3].amount;
            //return data;
        }
    }
}
