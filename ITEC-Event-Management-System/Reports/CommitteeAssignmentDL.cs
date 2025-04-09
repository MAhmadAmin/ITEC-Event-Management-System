using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Tls;

namespace ITEC_Event_Management_System.Reports
{
    static public class CommitteeAssignmentDL
    {
        static public List<CommitteeAssignmentDataClass> GetDuties(int committeeID)
        {
            string query = $"SELECT d.duty_ID, d.committee_id, c.committee_name, d.assigned_to, d.task_description, d.deadline, l.value FROM duties d INNER JOIN committees c ON d.committee_ID = c.committee_ID INNER JOIN lookup l ON d.status_ID = l.lookup_id WHERE d.committee_ID = {committeeID}";

            var reader = DatabaseHelper.Instance.getData(query);
            List<CommitteeAssignmentDataClass> duties = new List<CommitteeAssignmentDataClass>();
            while (reader.Read())
            {
                CommitteeAssignmentDataClass duty = new CommitteeAssignmentDataClass
                {
                    dutyID = reader.GetInt32(0),
                    committeeID = reader.GetInt32(1),
                    committeeName = reader.GetString(2),
                    assignedTo = reader.GetString(3),
                    taskDescription = reader.GetString(4),
                    deadline = reader.GetDateTime(5).ToString(),
                    status = reader.GetString(6)
                };
                duties.Add(duty);
            }
            return duties;
        }
    }
}
