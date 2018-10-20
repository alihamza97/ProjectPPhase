using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class BorrowedEquipment
    {
        public int ItemID { get; set; }
        public int EventID { get; set; }
        public string BorrowedDate { get; set; }
        public string ReturnDate { get; set; }

        public BorrowedEquipment(int item,int eventnr,string borrowedDate,string returnDate)
        {
            this.ItemID = item;
            this.EventID = eventnr;
            this.BorrowedDate = borrowedDate;
            this.ReturnDate = returnDate;
        }
    }
}
