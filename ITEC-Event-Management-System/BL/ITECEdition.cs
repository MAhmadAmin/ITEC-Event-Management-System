using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC_Event_Management_System.BL
{
    public class ITECEdition
    {
        public int ID;
        public int year;
        public string theme;
        public string description;
        public ITECEdition(int id, int year, string theme, string description)
        {
            this.ID = id;
            this.year = year;
            this.theme = theme;
            this.description = description;
        }
    }
}
