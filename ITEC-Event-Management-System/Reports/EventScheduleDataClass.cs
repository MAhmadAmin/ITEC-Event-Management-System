using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.Reports
{
    public class EventScheduleDataClass
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Venue { get; set; }
        public string Location { get; set; }
    }
}
