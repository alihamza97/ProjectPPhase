using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class LogFiles
    {
        public int LogID { get; set; }
        public int BankAccountID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NrOfDeposit { get; set; }

        public LogFiles(int logId,int bankAccount,DateTime startdate,DateTime enddate,int nrofDeposit)
        {
            this.LogID = logId;
            this.BankAccountID = bankAccount;
            this.StartDate = startdate;
            this.EndDate = enddate;
            this.NrOfDeposit = nrofDeposit;
        }

    }
}
