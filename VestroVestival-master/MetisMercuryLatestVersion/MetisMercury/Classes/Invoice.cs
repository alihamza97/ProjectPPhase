using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class Invoice
    {
        public int InvoiceId { get; set; }
        public int EventID { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalBill { get; set; }

        public Invoice(int InvoiceId, int EventID, DateTime date, decimal totalBill)
        {
            this.InvoiceId = InvoiceId;
            this.EventID = EventID;
            this.Date = date;
            this.TotalBill = totalBill;
        }

    }
}
