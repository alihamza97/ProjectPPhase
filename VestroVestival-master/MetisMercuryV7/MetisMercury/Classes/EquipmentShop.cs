using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class EquipmentShop
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public decimal Price
        { get; set; }

        //Constructor

        public EquipmentShop(int item,string nam,decimal pric)
        {
            this.ItemID = item;
            this.Name = nam;
            this.Price = pric;
        }
    }
}
