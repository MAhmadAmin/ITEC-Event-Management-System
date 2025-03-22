using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class EventParticipant
    {
        public int RegistrationID;
        public int EventID;
        public int ParticipantID;
        public int PaymentStatusID;
        public float FeeAmount;
        public EventParticipant(int registrationID, int eventID, int participantID, int paymentStatusID, float feeAmount)
        {
            RegistrationID = registrationID;
            EventID = eventID;
            ParticipantID = participantID;
            PaymentStatusID = paymentStatusID;
            FeeAmount = feeAmount;
        }
    }
}
