using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class Vendor
    {
        public int ID;
        public string Name;
        public string Contact;
        public string Servicetype;
        public Vendor(int iD, string name, string contact, string servicetype)
        {
            ID = iD;
            Name = name;
            Contact = contact;
            Servicetype = servicetype;
        }
    }
}
