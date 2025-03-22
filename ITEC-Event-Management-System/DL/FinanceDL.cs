using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEC_Event_Management_System.BL;

namespace ITEC_Event_Management_System.DL
{
    static public class FinanceDL
    {
        static public int Store(Finance finance)
        {
            string ITECID = finance.ITECID == -1 ? "NULL" : finance.ITECID.ToString();
            string eventID = finance.EventID == -1 ? "NULL" : finance.EventID.ToString();
            string typeID = finance.TypeID == -1 ? "NULL" : finance?.TypeID.ToString();
            string description = string.IsNullOrWhiteSpace(finance.Description) ? "NULL" : $"'{finance.Description}'";

            string query = $"INSERT INTO finances (itec_id, event_id, type_id, amount, from_entity_type, from_entity_id, to_entity_type, to_entity_id, description, date_recorded) VALUES ({ITECID}, {eventID}, {typeID}, {finance.Amount}, '{finance.FromType}', {finance.FromID}, '{finance.ToType}', {finance.ToID}, {description}, Now())";
            int result = DatabaseHelper.Instance.ExecuteQuery(query);
            return result;
        }

        static public List<Finance> GetAll()
        {
            List<Finance> finances = new List<Finance>();

            string query = "SELECT * FROM Finances";
            var reader = DatabaseHelper.Instance.getData(query);

            while (reader.Read())
            {
                int ITECID = reader.IsDBNull(reader.GetOrdinal("itec_id")) ? -1 : reader.GetInt32("itec_id");
                int eventID = reader.IsDBNull(reader.GetOrdinal("event_id")) ? -1 : reader.GetInt32("event_id");
                int typeID = reader.IsDBNull(reader.GetOrdinal("type_id")) ? -1 : reader.GetInt32("type_id");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");

                Finance f = new Finance(reader.GetInt32("transaction_id"), ITECID, eventID, typeID, reader.GetFloat("amount"), reader.GetString("from_entity_type"), reader.GetInt32("from_entity_id"), reader.GetString("to_entity_type"), reader.GetInt32("to_entity_id"), description, reader.GetDateTime("date_recorded"));

                finances.Add(f);
            }
            reader.Close();
            return finances;
        }

        static public int Delete(int ID)
        {
            string query = $"DELETE FROM finances WHERE transaction_id = {ID}";
            int result = DatabaseHelper.Instance.ExecuteQuery(query);
            return result;
        }

        static public int Update(Finance finance)
        {
            string ITECID = finance.ITECID == -1 ? "NULL" : finance.ITECID.ToString();
            string eventID = finance.EventID == -1 ? "NULL" : finance.EventID.ToString();
            string typeID = finance.TypeID == -1 ? "NULL" : finance.TypeID.ToString();
            string description = string.IsNullOrWhiteSpace(finance.Description) ? "NULL" : $"'{finance.Description}'";

            string query = $"UPDATE finances SET itec_id = {ITECID}, event_id = {eventID}, type_id = {typeID}, amount = {finance.Amount}, from_entity_type = '{finance.FromType}', from_entity_id = {finance.FromID}, to_entity_type = '{finance.ToType}', to_entity_id = {finance.ToID}, description = {description} WHERE transaction_id = {finance.TransactionID}";

            int result = DatabaseHelper.Instance.ExecuteQuery(query);
            return result;
        }

        static public Finance GetByID(int ID)
        {
            Finance finance = null;
            string query = $"SELECT * FROM finances WHERE transaction_id = {ID}";

            var reader = DatabaseHelper.Instance.getData(query);

            if (reader.Read())
            {
                int ITECID = reader.IsDBNull(reader.GetOrdinal("itec_id")) ? -1 : reader.GetInt32("itec_id");
                int eventID = reader.IsDBNull(reader.GetOrdinal("event_id")) ? -1 : reader.GetInt32("event_id");
                int typeID = reader.IsDBNull(reader.GetOrdinal("type_id")) ? -1 : reader.GetInt32("type_id");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");

                finance = new Finance(
                    reader.GetInt32("transaction_id"),
                    ITECID, eventID, typeID,
                    reader.GetFloat("amount"),
                    reader.GetString("from_entity_type"),
                    reader.GetInt32("from_entity_id"),
                    reader.GetString("to_entity_type"),
                    reader.GetInt32("to_entity_id"),
                    description,
                    reader.GetDateTime("date_recorded")
                );
            }
            reader.Close();
            return finance;
        }

        static public List<Finance> GetByITECID(int ID)
        {
            string query = $"SELECT * FROM finances WHERE itec_id = {ID}";
            return GetFinancesByQuery(query);
        }

        static public List<Finance> GetByNullITECID()
        {
            string query = $"SELECT * FROM finances WHERE itec_id IS NULL";
            return GetFinancesByQuery(query);
        }

        static public List<Finance> GetByEventID(int ID)
        {
            string query = $"SELECT * FROM finances WHERE event_id = {ID}";
            return GetFinancesByQuery(query);
        }

        static public List<Finance> GetByNullEventID()
        {
            string query = $"SELECT * FROM finances WHERE event_id IS NULL";
            return GetFinancesByQuery(query);
        }

        static public List<Finance> GetByTypeID(int ID)
        {
            string query = $"SELECT * FROM finances WHERE type_id = {ID}";
            return GetFinancesByQuery(query);
        }

        static public List<Finance> GetByNullTypeID()
        {
            string query = $"SELECT * FROM finances WHERE type_id IS NULL";
            return GetFinancesByQuery(query);
        }

        static public List<Finance> GetByDescription(string description)
        {
            string query = $"SELECT * FROM finances WHERE description LIKE '%{description}%'";
            return GetFinancesByQuery(query);
        }

        static public List<Finance> GetByNullDescription()
        {
            string query = $"SELECT * FROM finances WHERE description IS NULL";
            return GetFinancesByQuery(query);
        }

        static public List<Finance> GetByAmount(float amount)
        {
            string query = $"SELECT * FROM finances WHERE amount = {amount}";
            return GetFinancesByQuery(query);
        }

        static public List<Finance> GetByFromType(string fromType)
        {
            string query = $"SELECT * FROM finances WHERE from_entity_type = '{fromType}'";
            return GetFinancesByQuery(query);
        }

        static public List<Finance> GetByFromID(int fromID)
        {
            string query = $"SELECT * FROM finances WHERE from_entity_id = {fromID}";
            return GetFinancesByQuery(query);
        }

        static public List<Finance> GetByToType(string toType)
        {
            string query = $"SELECT * FROM finances WHERE to_entity_type = '{toType}'";
            return GetFinancesByQuery(query);
        }

        static public List<Finance> GetByToID(int toID)
        {
            string query = $"SELECT * FROM finances WHERE to_entity_id = {toID}";
            return GetFinancesByQuery(query);
        }
        static private List<Finance> GetFinancesByQuery(string query)
        {
            List<Finance> finances = new List<Finance>();

            var reader = DatabaseHelper.Instance.getData(query);

            while (reader.Read())
            {
                int ITECID = reader.IsDBNull(reader.GetOrdinal("itec_id")) ? -1 : reader.GetInt32("itec_id");
                int eventID = reader.IsDBNull(reader.GetOrdinal("event_id")) ? -1 : reader.GetInt32("event_id");
                int typeID = reader.IsDBNull(reader.GetOrdinal("type_id")) ? -1 : reader.GetInt32("type_id");
                string description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description");

                Finance f = new Finance(
                    reader.GetInt32("transaction_id"),
                    ITECID, eventID, typeID,
                    reader.GetFloat("amount"),
                    reader.GetString("from_entity_type"),
                    reader.GetInt32("from_entity_id"),
                    reader.GetString("to_entity_type"),
                    reader.GetInt32("to_entity_id"),
                    description,
                    reader.GetDateTime("date_recorded")
                );

                finances.Add(f);
            }
            reader.Close();
            return finances;
        }

    }
}
