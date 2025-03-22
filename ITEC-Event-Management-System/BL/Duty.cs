using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class Duty
    {
        public int ID;
        public int CommitteeID;
        public string AssignedTo;
        public string TaskDescription;
        public DateTime Deadline;
        public int StatusID;

        public Duty(int iD, int committeeID, string assignedTo, string taskDescription, DateTime deadline, int statusID)
        {
            ID = iD;
            CommitteeID = committeeID;
            AssignedTo = assignedTo;
            TaskDescription = taskDescription;
            Deadline = deadline;
            StatusID = statusID;
        }
    }
}
