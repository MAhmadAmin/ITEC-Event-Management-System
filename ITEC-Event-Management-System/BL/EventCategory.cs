using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class EventCategory
    {
        public int ID;
        public string name;

        public EventCategory(int ID, string name)
        {
            this.ID = ID;
            this.name = name;
        }
    }
}
