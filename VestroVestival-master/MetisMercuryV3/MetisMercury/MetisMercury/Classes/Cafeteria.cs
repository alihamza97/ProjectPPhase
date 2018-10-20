using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetisMercury.Classes
{
    class Cafeteria
    {
        public int ItemNr { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public int ShopNr { get; set; }
        public int QUANTITY { get; set; }

        public Cafeteria(/*int itemnr*/decimal price,string nam,int QUANT)
        {
            //this.ItemNr = itemnr;
            this.Price = price;
            this.Name = nam;
         //   this.ShopNr = sHOPnR;
            this.QUANTITY = QUANT;
        }
       public int AddQuantity()
        {
           
            return QUANTITY++;
        }
        public int RemoveQuantity()
        {

            return QUANTITY--;
        }
    }
}
