using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class logfile
    {
      //  public int LogID { get; set; }
        public string BankAccountID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string NrOfDeposit { get; set; }
        public string UserAccount { get; set; }
        public string amount { get; set; }

        public logfile(/*int logId,*/string bankAccount,string startdate,string enddate,string usera,string nrofDeposit,string amount)
        {
         //   this.LogID = logId;
            this.BankAccountID = bankAccount;
            this.StartDate = startdate;
            this.EndDate = enddate;
            this.NrOfDeposit = nrofDeposit;
            this.UserAccount = usera;
            this.amount = amount;
        }

    }
}
