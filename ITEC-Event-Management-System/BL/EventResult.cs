using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class EventResult
    {
        public int ResultID;
        public int EventID;
        public int ParticipantID;
        public int TeamID;
        public int Position;
        public float Score;
        public string Remarks;
        public EventResult(int resultID, int eventID, int participantID, int teamID, int position, float score, string remarks)
        {
            ResultID = resultID;
            EventID = eventID;
            ParticipantID = participantID;
            TeamID = teamID;
            Position = position;
            Score = score;
            Remarks = remarks;
        }
    }
}
