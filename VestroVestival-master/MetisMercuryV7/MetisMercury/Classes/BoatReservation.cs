using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class BoatReservation
    {
        public int EventID { get; set; }
        public int BoatID { get; set; }
        public bool PresentlyChekdin { get; set; }

        public BoatReservation(int eventID,int BoatId,bool presentlycHEKDIN)
        {
            this.EventID = eventID;
            this.BoatID = BoatId;
            this.PresentlyChekdin = presentlycHEKDIN;
        }
    }
}
