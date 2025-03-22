using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using ITEC_Event_Management_System.BL;
using MySql.Data.MySqlClient;

namespace ITEC_Event_Management_System.DL
{
    static public class VendorDL
    {
        static public int StoreVendor(Vendor vendor)
        {
            string contact = string.IsNullOrWhiteSpace(vendor.Contact) ? "NULL" : $"'{vendor.Contact}'";
            string serviceType = string.IsNullOrWhiteSpace(vendor.Servicetype) ? "NULL" : $"'{vendor.Servicetype}'";

            string query = $"INSERT INTO vendors (vendor_name, contact, service_type) VALUES ('{vendor.Name}', {contact}, {serviceType})";
            int result;
            try
            {
                result = DatabaseHelper.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return -1;
            }
            return result;
        }

        static public List<Vendor> GetAllVendors()
        {
            List<Vendor> vendors = new List<Vendor>();

            string query = "SELECT * FROM vendors";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                string contact = reader.IsDBNull(2) ? null : reader.GetString("contact");
                string serviceType = reader.IsDBNull(3) ? null : reader.GetString("service_type");

                vendors.Add(new Vendor(reader.GetInt16(0), reader.GetString(1), contact, serviceType));
            }
            reader.Close();
            return vendors;
        }

        static public Vendor GetVendorByID(int ID)
        {
            string query = $"SELECT * FROM vendors WHERE vendor_id = {ID}";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);

            if (reader.Read())
            {
                string contact = reader.IsDBNull(2) ? null : reader.GetString("contact");
                string serviceType = reader.IsDBNull(3) ? null : reader.GetString("service_type");

                return new Vendor(reader.GetInt16(0), reader.GetString(1), contact, serviceType);
            }
            else
                return null;
        }

        static public int DeleteVendor(int ID)
        {
            string query = $"DELETE FROM Vendors WHERE vendor_id = {ID}";

            return DatabaseHelper.Instance.ExecuteQuery(query);
        }

        static public int UpdateVendor(Vendor vendor)
        {
            string checkQuery = $"SELECT * FROM Vendors WHERE vendor_ID = {vendor.ID}";
            MySqlDataReader checkReader = DatabaseHelper.Instance.getData(checkQuery);
            if (checkReader.Read())
            {
                string vendorName = string.IsNullOrWhiteSpace(vendor.Name) ? checkReader.GetString("vendor_name") : vendor.Name;
                string contact = string.IsNullOrEmpty(vendor.Contact) ? "NULL" : $"'{vendor.Contact}'";
                string serviceType = string.IsNullOrEmpty(vendor.Servicetype) ? "NULL" : $"'{vendor.Servicetype}'";
                string query = $"UPDATE vendors SET vendor_name = '{vendorName}', contact = {contact}, service_type = {serviceType} WHERE vendor_ID = {vendor.ID}";
                checkReader.Close();
                return DatabaseHelper.Instance.ExecuteQuery(query);
            }
            else
                return -1;

        }

        static public List<Vendor> GetVendorsByNameLike(string name)
        {
            List<Vendor> vendors = new List<Vendor>();
            string query = $"SELECT * FROM vendors WHERE vendor_name LIKE '%{name}%'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                string contact = reader.IsDBNull(2) ? null : reader.GetString("contact");
                string serviceType = reader.IsDBNull(3) ? null : reader.GetString("service_type");

                vendors.Add(new Vendor(reader.GetInt16(0), reader.GetString(1), contact, serviceType));
            }
            reader.Close();
            return vendors;
        }

        static public List<Vendor> GetVendorsByContactLike(string contact)
        {
            List<Vendor> vendors = new List<Vendor>();
            string query = $"SELECT * FROM vendors WHERE contact LIKE '%{contact}%'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                string vendorContact = reader.IsDBNull(2) ? null : reader.GetString("contact");
                string serviceType = reader.IsDBNull(3) ? null : reader.GetString("service_type");

                vendors.Add(new Vendor(reader.GetInt16(0), reader.GetString(1), vendorContact, serviceType));
            }
            reader.Close();
            return vendors;
        }

        static public List<Vendor> GetVendorsByServiceLike(string service)
        {
            List<Vendor> vendors = new List<Vendor>();
            string query = $"SELECT * FROM vendors WHERE service_type LIKE '%{service}%'";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                string contact = reader.IsDBNull(2) ? null : reader.GetString("contact");
                string serviceType = reader.IsDBNull(3) ? null : reader.GetString("service_type");

                vendors.Add(new Vendor(reader.GetInt16(0), reader.GetString(1), contact, serviceType));
            }
            reader.Close();
            return vendors;
        }

        static public List<Vendor> GetVendorsByNullContact()
        {
            List<Vendor> vendors = new List<Vendor>();
            string query = "SELECT * FROM vendors WHERE contact IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                string contact = reader.IsDBNull(2) ? null : reader.GetString("contact");
                string serviceType = reader.IsDBNull(3) ? null : reader.GetString("service_type");

                vendors.Add(new Vendor(reader.GetInt16(0), reader.GetString(1), contact, serviceType));
            }
            reader.Close();
            return vendors;
        }

        static public List<Vendor> GetVendorsByNullService()
        {
            List<Vendor> vendors = new List<Vendor>();
            string query = "SELECT * FROM vendors WHERE service_type IS NULL";
            MySqlDataReader reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                string contact = reader.IsDBNull(2) ? null : reader.GetString("contact");
                string serviceType = reader.IsDBNull(3) ? null : reader.GetString("service_type");

                vendors.Add(new Vendor(reader.GetInt16(0), reader.GetString(1), contact, serviceType));
            }
            reader.Close();
            return vendors;
        }
    }
}
