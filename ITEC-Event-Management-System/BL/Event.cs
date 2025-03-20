using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.DL
{
    public class Event
    {
        public int ID;
        public string name;
        public DateTime date;
        public string description;
        public int ITECID;
        public int categoryID;
        public int venueID;
        public int committeeID;
        public Event(int id, string name, DateTime date, string description, int itecid, int categoryid, int venueid, int committeeid)
        {
            this.ID = id;
            this.name = name;
            this.date = date;
            this.description = description;
            this.ITECID = itecid;
            this.categoryID = categoryid;
            this.venueID = venueid;
            this.committeeID = committeeid;
        }
    }
}
