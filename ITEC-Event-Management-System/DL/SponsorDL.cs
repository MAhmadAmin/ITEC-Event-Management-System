using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITEC_Event_Management_System.BL;
using MySql.Data.MySqlClient;

namespace ITEC_Event_Management_System.DL
{
    static public class SponsorDL
    {
        static public int StoreSponsor(Sponsor Sponsor)
        {
            string contactValue = string.IsNullOrWhiteSpace(Sponsor.contact) ? "Null" : $"'{Sponsor.contact}'";
            string query = $"INSERT INTO Sponsors (sponsor_name, contact) VALUES ('{Sponsor.name}', {contactValue})";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }
        static public List<Sponsor> GetAllSponsors()
        {
            List<Sponsor> sponsors = new List<Sponsor>();
            string query = "SELECT * FROM Sponsors";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                string contact = reader.IsDBNull(reader.GetOrdinal("contact")) ? "NULL" : reader.GetString("contact");
                sponsors.Add(new Sponsor(reader.GetInt32("sponsor_ID"), reader.GetString("sponsor_name"), contact));
            }
            return sponsors;
        }
        static public List<Sponsor> GetSponsorsByLikeContact(string contact)
        {
            List<Sponsor> sponsors = new List<Sponsor>();
            string query = $"SELECT * FROM Sponsors WHERE contact LIKE '%{contact}%'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                string contactValue = reader.IsDBNull(reader.GetOrdinal("contact")) ? "NULL" : reader.GetString("contact");
                sponsors.Add(new Sponsor(reader.GetInt32("sponsor_ID"), reader.GetString("sponsor_name"), contactValue));
            }
            return sponsors;
        }
        static public List <Sponsor> GetSponsorsByNullContact()
        {
            List<Sponsor> sponsors = new List<Sponsor>();
            string query = "SELECT * FROM Sponsors WHERE contact IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                string contact = reader.IsDBNull(reader.GetOrdinal("contact")) ? "NULL" : reader.GetString("contact");
                sponsors.Add(new Sponsor(reader.GetInt32("sponsor_ID"), reader.GetString("sponsor_name"), contact));
            }
            return sponsors;
        }
        static public Sponsor GetSponsorByID(int id)
        {
            string query = $"SELECT * FROM Sponsors WHERE sponsor_ID = {id}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                string contact = reader.IsDBNull(reader.GetOrdinal("contact")) ? "NULL" : reader.GetString("contact");
                return new Sponsor(reader.GetInt32("sponsor_ID"), reader.GetString("sponsor_name"), contact);
            }
            return null;
        }
        static public List<Sponsor> GetSponsorsByLikeName(string name)
        {
            List<Sponsor> sponsors = new List<Sponsor>();
            string query = $"SELECT * FROM Sponsors WHERE sponsor_name LIKE '%{name}%'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                string contact = reader.IsDBNull(reader.GetOrdinal("contact")) ? "NULL" : reader.GetString("contact");
                sponsors.Add(new Sponsor(reader.GetInt32("sponsor_ID"), reader.GetString("sponsor_name"), contact));
            }
            return sponsors;
        }
        static public int UpdateSponsor(Sponsor Sponsor)
        {
            string checkQuery = $"SELECT * FROM Sponsors WHERE sponsor_ID = {Sponsor.ID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(checkQuery);
            if (reader.Read())
            {
                string contactValue = string.IsNullOrWhiteSpace(Sponsor.contact) ? "Null" : $"'{Sponsor.contact}'";
                string nameValue = string.IsNullOrWhiteSpace(Sponsor.name) ? reader.GetString("sponsor_name") : $"{Sponsor.name}";
                string query = $"UPDATE Sponsors SET sponsor_name = '{nameValue}', contact = {contactValue} WHERE sponsor_ID = {Sponsor.ID}";
                return DatabaseHelper.Instance.ExecuteQuery(query);
            }
            return -1;
        }
        static public int DeleteSponsor(int id)
        {
            string query = $"DELETE FROM Sponsors WHERE sponsor_ID = {id}";
            return DatabaseHelper.Instance.ExecuteQuery(query);
        }
    }
}
