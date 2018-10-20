using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class Visitor
    {
        public int EventID { get; set; }
        public decimal PresentBalance { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string Email { get; set; }
        public bool IsChekedin { get; set; }
        public bool HasChekedin { get; set; }
        public bool StatusOfPayment { get; set; }
        public String RFID { get; set; }
        public int CampingSpotID { get; set; }
        public int BoatID { get; set; }

        public Visitor(int eventid,decimal presentbalnc,string fnam,string lnam,string email,bool hasChekdIn,
            bool statusOfPayment,string rfid)
        {
            this.EventID = eventid;
            this.PresentBalance = presentbalnc;
            this.Fname = fnam;
            this.Lname = lnam;
            this.Email = email;
        
            this.HasChekedin = hasChekdIn;
            this.StatusOfPayment = statusOfPayment;
            this.RFID = rfid;
           
        }

        public void EntranceFees()
        {
            int fees = 55;

            if (PresentBalance >= fees)
            {
                PresentBalance = PresentBalance - fees;
                StatusOfPayment = !StatusOfPayment;
            }
        }
        public void DepositMoney(decimal amount)
        {
            PresentBalance += amount;
        }
        public void WithDrawMoney(decimal amount)
        {
            PresentBalance -= amount;
        }
    }
}
