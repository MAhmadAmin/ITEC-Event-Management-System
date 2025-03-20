using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class Sponsor
    {
        public int ID;
        public string name;
        public string contact;

        public Sponsor(int ID, string name, string contact)
        {
            this.ID = ID;
            this.name = name;
            this.contact = contact;
        }
    }
}
