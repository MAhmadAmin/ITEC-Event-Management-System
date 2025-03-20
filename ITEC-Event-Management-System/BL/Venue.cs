using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class Venue
    {
        public int ID;
        public string name;
        public int capacity;
        public string location;
        public Venue(int ID, string name, int capacity, string location)
        {
            this.ID = ID;
            this.name = name;
            this.capacity = capacity;
            this.location = location;
        }
    }
}
