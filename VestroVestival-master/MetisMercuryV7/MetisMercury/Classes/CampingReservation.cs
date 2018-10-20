using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class CampingReservation
    {
        public int EventID { get; set; }
        public int CampingSpotID { get; set; }
        public bool PresentlyChekedIn { get; set; }

        public CampingReservation(int Eventid,int spotid,bool chekedinstatus)
        {
            this.EventID = Eventid;
            this.CampingSpotID = spotid;
            this.PresentlyChekedIn = chekedinstatus;
        }
    }
}
