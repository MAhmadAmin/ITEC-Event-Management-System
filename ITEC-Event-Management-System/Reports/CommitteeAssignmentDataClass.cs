using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.Reports
{
    public class CommitteeAssignmentDataClass
    {
        public int dutyID { get; set; }
        public int committeeID { get; set; }
        public string committeeName { get; set; }
        public string assignedTo { get; set; }
        public string taskDescription { get; set; }
        public string deadline { get; set; }
        public string status { get; set; }
    }
}
