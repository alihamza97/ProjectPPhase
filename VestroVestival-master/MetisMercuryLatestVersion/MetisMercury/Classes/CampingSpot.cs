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
        public string CampSpot { get; set; }
        public int IsAvailable { get; set; }
        public int NrOfParticipant { get; set; }
        public decimal Price { get; set; }
        public int HasPaid { get; set; }
        public int day { get; set; }

        public CampingSpot(int spotId,string CAMPSPOT,int dy, int avaiable,int nrParticipants,decimal pric,int paid)
        {
            this.CampingSpotID = spotId;
            this.day = dy;
            this.CampSpot = CAMPSPOT;
            this.IsAvailable = avaiable;
            this.NrOfParticipant = nrParticipants;
            this.Price = pric;
            this.HasPaid = paid;
        }
    }
}
