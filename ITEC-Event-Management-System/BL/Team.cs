using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class Team
    {
        public int ID;
        public int EventID;
        public string Name;

        public Team(int id, int eventID, string name)
        {
            ID = id;
            EventID = eventID;
            Name = name;
        }
    }
}
