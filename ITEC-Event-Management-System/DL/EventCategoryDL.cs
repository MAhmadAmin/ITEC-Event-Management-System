using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ITEC_Event_Management_System.BL;

namespace ITEC_Event_Management_System.DL
{
    static public class EventCategoryDL
    {
        static public int StoreCategory(EventCategory category)
        {
            string query = $"INSERT INTO Event_Categories (category_name) VALUES ('{category.name}')";
            int result = DatabaseHelper.Instance.ExecuteQuery(query);
            return result;
        }
        static public int DeleteCategory(EventCategory category)
        {
            string query = $"DELETE FROM Event_Categories WHERE event_category_id = {category.ID}";
            int result = DatabaseHelper.Instance.ExecuteQuery(query);
            return result;
        }
        static public int UpdateCategory(EventCategory category)
        {
            string query = $"UPDATE Event_Categories SET category_name = '{category.name}' WHERE event_category_id = {category.ID}";
            int result = DatabaseHelper.Instance.ExecuteQuery(query);
            return result;
        }
        static public List<EventCategory> GetAllCategories()
        {
            string query = "SELECT * FROM Event_Categories";
            var reader = DatabaseHelper.Instance.getData(query);
            List<EventCategory> categories = new List<EventCategory>();

            while (reader.Read())
            {
                EventCategory category = new EventCategory(Convert.ToInt32(reader["event_category_id"]), reader["category_name"].ToString());
                categories.Add(category);
            }
            return categories;
        }
        static public EventCategory GetCategoryByID(int id)
        {
            string query = $"SELECT * FROM Event_Categories WHERE event_category_id = {id}";
            var reader = DatabaseHelper.Instance.getData(query);
            if(reader.Read())
            {
                EventCategory category = new EventCategory(Convert.ToInt32(reader["event_category_id"]), reader["category_name"].ToString());
                return category;
            }
            else
            {
                return null;
            }

        }
        static public List<EventCategory> GetCategoriesByNameLike(string name)
        {
            string query = $"SELECT * FROM Event_Categories WHERE category_name LIKE '%{name}%'";
            var reader = DatabaseHelper.Instance.getData(query);
            List<EventCategory> categories = new List<EventCategory>();
            while (reader.Read())
            {
                EventCategory category = new EventCategory(Convert.ToInt32(reader["event_category_id"]), reader["category_name"].ToString());
                categories.Add(category);
            }
            return categories;
        }
    }
}
