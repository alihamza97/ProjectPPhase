using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class Boat
    {
        public int BoatID { get; set; }
        public bool isAvailable { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Day { get; set; }
        public decimal Price { get; set; }
        public bool HasPaid { get; set; }
        public int NrOfParticipants { get; set; }


        //Constructor
        public Boat(int boatid,int NrOfParticipan,bool available,string day, DateTime start, DateTime end, decimal price,bool paid)
        {
            this.BoatID = boatid;
            this.NrOfParticipants = NrOfParticipan;
            this.isAvailable = available;
            this.StartTime = start;
            this.EndTime = end;
            this.Day = day;
            this.Price = price;
            this.HasPaid = paid;
        }
    }
}
