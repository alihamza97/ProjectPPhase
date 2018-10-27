using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22.Events;
using MetisMercury.Classes;
using MetisMercury.DatabaseClasses;

namespace MetisMercury.Apps
{
    public partial class CafeTeria : Form
    {
        Cafeteria myCafeteria;
        DatabaseClasses.Cafeteria_DataHelper items;
        List<Classes.Cafeteria> orders;
        private phidget phidget = null;
        private string RFIDTagNr = null;
        decimal balnce;
        decimal totalBalnc;
       // string rfid = "2800b868d1";
        //   string rfid = "2800b868d1";
        int indexRow;
        Invoice_DH INVOICE;

        public CafeTeria()
        {
            InitializeComponent();
            INVOICE = new Invoice_DH();
            items = new DatabaseClasses.Cafeteria_DataHelper();
            orders = new List<Classes.Cafeteria>();
            //  myCafeteria = new Cafeteria(20,"Coffee",5);

            foreach (var v in items.getItems())
            {
                if (v.ItemNr == 1)
                {
                    drink1.Text = v.Name;
                }
                if (v.ItemNr == 2)
                {
                    drink2.Text = v.Name;
                }
                if (v.ItemNr == 3)
                {
                    drink3.Text = v.Name;
                }
                if (v.ItemNr == 4)
                {
                    drink4.Text = v.Name;
                }
                if (v.ItemNr == 5)
                {
                    drink5.Text = v.Name;
                }
                if (v.ItemNr == 6)
                {
                    drink6.Text = v.Name;
                }
                if (v.ItemNr == 7)
                {
                    drink7.Text = v.Name;
                }
                if (v.ItemNr == 8)
                {
                    drink8.Text = v.Name;
                }
                if (v.ItemNr == 9)
                {
                    drink9.Text = v.Name;
                }
                if (v.ItemNr == 10)
                {
                    drink10.Text = v.Name;
                }
                if (v.ItemNr == 11)
                {
                    drink11.Text = v.Name;
                }
                if (v.ItemNr == 12)
                {
                    drink12.Text = v.Name;
                }
                if (v.ItemNr == 13)
                {
                    drink13.Text = v.Name;
                }
                if (v.ItemNr == 14)
                {
                    drink14.Text = v.Name;
                }
                if (v.ItemNr == 15)
                {
                    drink15.Text = v.Name;
                }
                if (v.ItemNr == 16)
                {
                    drink16.Text = v.Name;
                }
                if (v.ItemNr == 17)
                {
                    drink17.Text = v.Name;
                }
                if (v.ItemNr == 18)
                {
                    drink18.Text = v.Name;
                }
                if (v.ItemNr == 19)
                {
                    food19.Text = v.Name;
                }
                if (v.ItemNr == 20)
                {
                    food20.Text = v.Name;
                }
                if (v.ItemNr == 21)
                {
                    food21.Text = v.Name;
                }
                if (v.ItemNr == 22)
                {
                    food22.Text = v.Name;
                }
                if (v.ItemNr == 23)
                {
                    food23.Text = v.Name;
                }
                if (v.ItemNr == 24)
                {
                    food24.Text = v.Name;
                }
                if (v.ItemNr == 25)
                {
                    food25.Text = v.Name;
                }
                if (v.ItemNr == 26)
                {
                    food26.Text = v.Name;
                }
                if (v.ItemNr == 27)
                {
                    food27.Text = v.Name;
                }
                if (v.ItemNr == 28)
                {
                    food28.Text = v.Name;
                }
                if (v.ItemNr == 29)
                {
                    food29.Text = v.Name;
                }
                if (v.ItemNr == 30)
                {
                    food30.Text = v.Name;
                }
                if (v.ItemNr == 31)
                {
                    food31.Text = v.Name;
                }
                if (v.ItemNr == 32)
                {
                    food32.Text = v.Name;
                }
                if (v.ItemNr == 33)
                {
                    food33.Text = v.Name;
                }
                if (v.ItemNr == 34)
                {
                    food34.Text = v.Name;
                }
                if (v.ItemNr == 35)
                {
                    food35.Text = v.Name;
                }


            }
            phidget = new phidget();

            try
            {
                phidget.OpenRFID();
                phidget.RFID.Tag +=new RFIDTagEventHandler(AssignRFID);
             // phidget.RFID.Tag += new RFIDTagEventHandler(RFIDTagNr);
               

            }
            catch (Exception)
            {
                MessageBox.Show("There was an error opening the rfid reader.");
            }

          //  MessageBox.Show("Note:itemNr has to be assigned to a product according to the button itemnr");


        }

        

        private string UpdateProductName(int itemNr,decimal price, string productName)
        {
            bool updated = items.UpdateProduct(itemNr,price, productName);

            if (updated)
            {
                return "Successfully Added to the BackEnd";
            }
            else
            {
                return "This product is already added in the database";
            }
        }


        private void AssignRFID(object sender, RFIDTagEventArgs e)
        {
            if (phidget.TagNr != null)
            {
                RFIDTagNr = phidget.TagNr;
                lbEventID.Text = RFIDTagNr;

                balnce = items.GetPresentBalance(RFIDTagNr);
                lbCurrentBalance.Text = balnce.ToString();

                dataGridVisitor.Rows.Clear();
                orders.Clear();
                Totalprice();

            }
        }

        public void ChekBalance()
        {
            balnce = items.GetPresentBalance(RFIDTagNr);
        }
       private int i = 0;
        void Totalprice()
        {
            totalBalnc = 0;
            int quantity = Convert.ToInt32(textBox1.Text);
           
            foreach (var item in orders)
            {
               // quantity = item.QUANTITY;
                totalBalnc+= item.Price*quantity;
            }
            lbTotalPrice.Text = totalBalnc.ToString();
        }

        private void Cafeteria_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //foreach (var item in items.getItems())
            //{
            //    int quantity = Convert.ToInt32(textBox1.Text);


            //    if (item.ItemNr == 10)
            //    {


            //        orders.Add(item);
            //        dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

            //        drink1.Text = item.Name;

            //    }
            //}
            //Totalprice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);


                if (item.Name == "water")
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);



                }
            }
            Totalprice();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);


                if (item.Name == "Chicken Burger")
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);



                }
            }
            Totalprice();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);


                if (item.Name == "fries")
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);



                }
            }
            Totalprice();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);


                if (item.Name == "salad")
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);



                }
            }
            Totalprice();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //foreach (var item in items.getItems())
            //{
            //    int quantity = Convert.ToInt32(textBox1.Text);
              

            //    if (item.ItemNr==0)
            //    {
                    

            //            orders.Add(item);
            //            dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);
                    
                                    
            //    }
            //}
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);


                if (item.Name == "ColdDrink")
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);



                }
            }
            Totalprice();
        }

        private void btClearItem_Click(object sender, EventArgs e)
        {
            int row = dataGridVisitor.SelectedRows[0].Index;
            dataGridVisitor.Rows.RemoveAt(row);
            orders.RemoveAt(row);
            Totalprice();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (balnce > totalBalnc)
            {
                foreach (var item in orders)
                    items.BuyProduct(RFIDTagNr, balnce - totalBalnc);
                lbCurrentBalance.Text = (balnce - totalBalnc).ToString();
                

            }
           // INVOICE.GetSoldItems(item)
            DataGridViewRow newDataRow = dataGridVisitor.Rows[indexRow];
            newDataRow.Cells[2].Value = textBox1.Text;
            Totalprice();
            lbCurrentBalance.Text = (balnce - totalBalnc).ToString();
            //if (balnce == 0)
            //{
            //    lbCurrentBalance.Text = "not enough money";
            //    MessageBox.Show("You are not allowed to buy this/these product(s)");
            //}
           // dataGridVisitor.Rows.Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            dataGridVisitor.Rows.Clear();
            orders.Clear();
            Totalprice();
            lbCurrentBalance.Text = "";
            lbEventID.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //foreach (var item in items.getItems())
            //{
            //    int quantity = Convert.ToInt32(textBox1.Text);


            //    if (item.ItemNr==3)
            //    {


            //        orders.Add(item);
            //        dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);



            //    }
            //}
            //Totalprice();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);


                if (item.Name == "RedBull")
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);



                }
            }
            Totalprice();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);


                if (item.Name == "liquor")
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);



                }
            }
            Totalprice();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);


                if (item.Name == "pizza")
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);



                }
            }
            Totalprice();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);


                if (item.Name == "pasta")
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);



                }
            }
            Totalprice();
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);


                if (item.Name == "soup")
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);



                }
            }
            Totalprice();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int b = 0;
            b = Convert.ToInt32(textBox1.Text);
            b++;
            textBox1.Text = Convert.ToString(b);

           
            //int i = 0;
            //i = Convert.ToInt32(textBox1.Text);
            //i--;
            //   textBox1.Text = myCafeteria.AddQuantity().ToString();

            //for(int i = 0; i <= items.getItems().Count; i++)
            //{
            //    quantity++;

            //}


            //    foreach (var item in items.getItems())
            //    {
            //        int quantity = Convert.ToInt32(nudQuantity.Value);
            //        if (item.Name == "SOUP")
            //        {
            //            orders.Add(item);
            //            dataGridVisitor.Rows.Add(item.Name, item.Price, item.ItemNr);
            //        }
            //    }
            //    Totalprice();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            int b = 0;
            b = Convert.ToInt32(textBox1.Text);
            b--;
            textBox1.Text = Convert.ToString(b);


            //  textBox1.Text = myCafeteria.RemoveQuantity().ToString();
        }

        private void dataGridVisitor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int quantity = Convert.ToInt32(nudQuantity.Value);

            //indexRow = e.RowIndex; // get the selected Row Index
            //DataGridViewRow row = dataGridVisitor.Rows[indexRow];

            //
            //textBoxFN.Text = row.Cells[1].Value.ToString();
            //textBoxLN.Text = row.Cells[2].Value.ToString();
            //textBoxAGE.Text = row.Cells[3].Value.ToString();
            indexRow = e.RowIndex;

            DataGridViewRow row = dataGridVisitor.Rows[indexRow];

            // display datagridview selected row data into textboxes
            textBox1.Text = row.Cells[2].Value.ToString();
        }

        private void lbEventID_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                phidget.CloseRFID();
                phidget.RFID.Tag -= new RFIDTagEventHandler(AssignRFID);
                // phidget.RFID.Tag += new RFIDTagEventHandler(RFIDTagNr);
                if (RFIDTagNr == null)
                {
                    MessageBox.Show("Please scan the rfid chip");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("There was an error closing the rfid reader.");
            }
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // MessageBox.Show("Note: items names have to be assigned according to their button numbers");
         


        }

        private void drink1_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 1)
                {


                    orders.Add(item);
                    if(quantity>0)
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                  //  drink1.Text = item.Name;

                }
             //   drink1.Text = item.Name;
            }
            Totalprice();
        }

        private void drink2_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 2)
                {


                    orders.Add(item);

                    if (quantity > 0)
                        dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
              //  drink2.Text = item.Name;
            }
            Totalprice();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drink3_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 3)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink4_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 4)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink5_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 5)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink6_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 6)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink7_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 7)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink8_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 8)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink9_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 9)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink10_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 10)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink11_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 11)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink12_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 12)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink13_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 13)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink14_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 14)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink15_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 15)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink16_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 16)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink17_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 17)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void drink18_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 18)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food19_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 19)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food20_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 20)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food21_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 21)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food22_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 22)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food23_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 23)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food24_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 24)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food25_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 25)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food26_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 26)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food27_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 27)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food28_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 28)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food29_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 29)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food30_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 30)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food31_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 31)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();

        }

        private void food32_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 32)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food33_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 33)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food34_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 34)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void food35_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);

                //item.ItemNr = 1;

                if (item.ItemNr == 35)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    //  drink1.Text = item.Name;

                }
                //  drink2.Text = item.Name;
            }
            Totalprice();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //printDialog1.Document = printDocument1;
            //if (printDialog1.ShowDialog() == DialogResult.OK)
            //{
            //Graphics g = this.CreateGraphics();
            //Bitmap bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            //Graphics mg = Graphics.FromImage(bmp);
            //mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //printPreviewDialog1.ShowDialog();
                printDocument1.Print();
         //   }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridVisitor.Width+6, this.dataGridVisitor.Height+6);
            dataGridVisitor.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridVisitor.Width, this.dataGridVisitor.Height));
            e.Graphics.DrawImage(bm, 10, 10);
        }
    }
}
