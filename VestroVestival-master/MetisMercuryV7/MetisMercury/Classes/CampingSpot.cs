using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class CampingSpot
    {
        public int CampingSpotID { get; set; }
        public bool IsAvailable { get; set; }
        public int NrOfParticipant { get; set; }
        public decimal Price { get; set; }
        public bool HasPaid { get; set; }
        public int day { get; set; }

        public CampingSpot(int spotId,int dy, bool avaiable,int nrParticipants,decimal pric,bool paid)
        {
            this.CampingSpotID = spotId;
            this.day = dy;
            this.IsAvailable = avaiable;
            this.NrOfParticipant = nrParticipants;
            this.Price = pric;
            this.HasPaid = paid;
        }
    }
}
