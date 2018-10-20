using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class AssignRfid
    {
        public string RFID { get; set; }
        public decimal Balance { get; set; }
        public string Fname { get; set; }
        public int EventId { get; set; }

        public AssignRfid(string fname,string rfid,decimal balnc)
        {
            this.RFID = rfid;
            this.Balance = balnc;
            this.Fname = fname;
        }
    }
}
