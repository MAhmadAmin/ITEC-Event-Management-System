using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class Committee
    {
        public int ID;
        public int ITECID;
        public string Name;
        public Committee(int ID, int ITECID, string Name)
        {
            this.ID = ID;
            this.ITECID = ITECID;
            this.Name = Name;
        }
    }
}
