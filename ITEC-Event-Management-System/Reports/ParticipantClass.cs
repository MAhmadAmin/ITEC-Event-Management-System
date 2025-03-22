using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.Reports
{
    public class ParticipantClass
    {
        public int ID {  get; set; }
        public int ITECID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string institute { get; set; }
        public int roleID { get; set; }
    }
}
