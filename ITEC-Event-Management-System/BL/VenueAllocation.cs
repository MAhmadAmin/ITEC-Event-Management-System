using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.DL
{
    public class VenueAllocation
    {
        public int AllocationID;
        public int EventID;
        public int VenueID;
        public DateTime AssignedDate;
        public TimeSpan AssignedTime;

        public VenueAllocation(int allocationID, int eventID, int venueID, DateTime assignedDate, TimeSpan assignedTime)
        {
            AllocationID = allocationID;
            EventID = eventID;
            VenueID = venueID;
            AssignedDate = assignedDate;
            AssignedTime = assignedTime;
        }
    }
}
