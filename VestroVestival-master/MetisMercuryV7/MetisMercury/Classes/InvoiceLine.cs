using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class InvoiceLine
    {
        public int InvoiceID { get; set; }
        public int ItemNr { get; set; }
        public int Quanity { get; set; }

        public InvoiceLine(int invoiceid,int itemnr,int quantity)
        {
            this.InvoiceID = invoiceid;
            this.ItemNr = itemnr;
            this.Quanity = quantity;
        }
    }
}
