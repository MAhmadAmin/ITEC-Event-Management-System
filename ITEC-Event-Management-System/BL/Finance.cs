using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class Finance
    {
        public int TransactionID;
        public int ITECID;
        public int EventID;
        public int TypeID;
        public float Amount;
        public string FromType;
        public int FromID;
        public string ToType;
        public int ToID;
        public string Description;
        public DateTime DateRecorded;
        
        public Finance(int transactionID, int itecID, int eventID, int typeID, float amount, string fromType, int fromID, string toType, int toID, string description)
        {
            TransactionID = transactionID;
            ITECID = itecID;
            EventID = eventID;
            TypeID = typeID;
            Amount = amount;
            FromType = fromType;
            FromID = fromID;
            ToType = toType;
            ToID = toID;
            Description = description;
        }

        public Finance(int transactionID, int itecID, int eventID, int typeID, float amount, string fromType, int fromID, string toType, int toID, string description, DateTime dateRecorded)
        {
            TransactionID = transactionID;
            ITECID = itecID;
            EventID = eventID;
            TypeID = typeID;
            Amount = amount;
            FromType = fromType;
            FromID = fromID;
            ToType = toType;
            ToID = toID;
            Description = description;
            DateRecorded = dateRecorded;
        }
    }
}
