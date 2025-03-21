using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class Participant
    {
        public int ID;
        public int ITECID;
        public string name;
        public string email;
        public string contact;
        public string institute;
        public int roleID;

        public Participant(int iD, int iTECID, string name, string email, string contact, string institute, int roleID)
        {
            ID = iD;
            ITECID = iTECID;
            this.name = name;
            this.email = email;
            this.contact = contact;
            this.institute = institute;
            this.roleID = roleID;
        }
    }
}
