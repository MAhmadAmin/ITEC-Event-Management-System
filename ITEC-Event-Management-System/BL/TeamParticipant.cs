using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class TeamParticipant
    {
        public int TeamID;
        public int ParticipantID;

        public TeamParticipant(int teamID, int participantID)
        {
            TeamID = teamID;
            ParticipantID = participantID;
        }
    }
}
