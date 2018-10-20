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
        string rfid = "2800b868d1";
        //   string rfid = "2800b868d1";
        int indexRow;

        public CafeTeria()
        {
            InitializeComponent();
            items = new DatabaseClasses.Cafeteria_DataHelper();
            orders = new List<Classes.Cafeteria>();
          //  myCafeteria = new Cafeteria(20,"Coffee",5);
            phidget = new phidget();

            try
            {
                phidget.OpenRFID();
                phidget.RFID.Tag += new RFIDTagEventHandler(AssignRFID);
             //   phidget.RFID.Tag += new RFIDTagEventHandler(RFIDTagNr);
                if (RFIDTagNr == null)
                {
                    MessageBox.Show("Please scan the rfid chip");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("There was an error opening the rfid reader.");
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
            balnce = items.GetPresentBalance(rfid);
        }
       private int i = 0;
        void Totalprice()
        {
            totalBalnc = 0;
            int quantity = Convert.ToInt32(textBox1.Text);
            foreach (var item in orders)
            {
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
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);


                if (item.ItemNr == 1)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);

                    button2.Text = item.Name;

                }
            }
            Totalprice();
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
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);
              

                if (item.ItemNr==0)
                {
                    

                        orders.Add(item);
                        dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);
                    
                                    
                }
            }
          
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
                    items.BuyProduct(rfid, balnce - totalBalnc);
                lbCurrentBalance.Text = (balnce - totalBalnc).ToString();
                

            }
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
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);


                if (item.ItemNr==3)
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);



                }
            }
            Totalprice();
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
            foreach (var item in items.getItems())
            {
                int quantity = Convert.ToInt32(textBox1.Text);


                if (item.Name == "HotDog")
                {


                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price, quantity);



                }
            }
            Totalprice();
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
    }
}
