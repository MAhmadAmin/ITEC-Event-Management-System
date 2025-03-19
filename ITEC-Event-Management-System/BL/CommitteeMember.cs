using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class CommitteeMember
    {
        public int ID;
        public int committeeID;
        public string name;
        public int roleID;
        public CommitteeMember(int ID, int committeeID, string name, int roleID)
        {
            this.ID = ID;
            this.committeeID = committeeID;
            this.name = name;
            this.roleID = roleID;
        }
    }
}
