using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class Tickets
    {
        public int TicketID { get; set; }
        public int EventID { get; set; }
        public decimal Price { get; set; }
        public string TicketType { get; set; }

        public Tickets(int ticek,int eventid,decimal price,string type)
        {
            this.TicketID = ticek;
            this.EventID = eventid;
            this.Price = price;
            this.TicketType = type;
        }
    }
}
