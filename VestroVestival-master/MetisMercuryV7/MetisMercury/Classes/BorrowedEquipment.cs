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
        public DateTime BorrowedDate { get; set; }
      //  public DateTime ReturnDate { get; set; }

        public BorrowedEquipment(int item,int eventnr,DateTime borrowedDate)//,DateTime returnDate)
        {
            this.ItemID = item;
            this.EventID = eventnr;
            this.BorrowedDate = borrowedDate;
        //    this.ReturnDate = returnDate;
        }
    }
}
