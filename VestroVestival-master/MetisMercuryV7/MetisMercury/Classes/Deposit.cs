using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class Deposit
    {
        public int DepositID { get; set; }
        public int EventID { get; set; }
        public int LogID { get; set; }
        public decimal DepositedAmount { get; set; }
        public DateTime Date { get; set; }

        public Deposit(int deposit,int eventid,int logID,decimal depositamont,DateTime date)
        {
            this.DepositID = deposit;
            this.EventID = eventid;
            this.LogID = logID;
            this.DepositedAmount = depositamont;
            this.Date = date;
        }

    }
}
