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
    public partial class EquipmentShop : Form
    {
        private phidget phidget = null;
        private string RFIDTagNr = null;
        private BorrowedEquipment BEQUIP = null;
        Visitor_DataHelper visitordata = null;
        private int id;
       // private Visitor visitor;
        //when sacn with scanner, put the id in cusomterID and call the method getbalance and store the balance in balance;
        DatabaseClasses.EquipmentShop_DH Equipment;
        List<Classes.EquipmentsShop> orders;
        List<Classes.EquipmentsShop> returned;
        int cusotmerID;
        decimal balance;
        decimal total;
        public EquipmentShop()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // disables reshaping the form.
            MaximizeBox = false;
            visitordata = new Visitor_DataHelper();
            orders = new List<Classes.EquipmentsShop>();
            returned = new List<Classes.EquipmentsShop>();
            Equipment = new DatabaseClasses.EquipmentShop_DH();

            foreach (var v in Equipment.GetEquipments())
            {
                if (v.ItemID == 1)
                {
                    charger1.Text = v.Name;
                }
                if (v.ItemID == 2)
                {
                    Charger2.Text = v.Name;
                }
                if (v.ItemID == 3)
                {
                    Charger3.Text = v.Name;
                }
                if (v.ItemID == 4)
                {
                    Charger4.Text = v.Name;
                }
                if (v.ItemID == 5)
                {
                    usb5.Text = v.Name;
                }
                if (v.ItemID == 6)
                {
                    usb6.Text = v.Name;
                }
                if (v.ItemID == 7)
                {
                    USB7.Text = v.Name;
                }
                if (v.ItemID == 8)
                {
                    USB8.Text = v.Name;
                }
                if (v.ItemID == 9)
                {
                    cable9.Text = v.Name;
                }
                if (v.ItemID == 10)
                {
                    CABLE10.Text = v.Name;
                }
                if (v.ItemID == 11)
                {
                    CABLE11.Text = v.Name;
                }
                if (v.ItemID == 12)
                {
                    CABLE12.Text = v.Name;
                }
                if (v.ItemID == 13)
                {
                    camera13.Text = v.Name;
                }
                if (v.ItemID == 14)
                {
                    CAMERA14.Text = v.Name;
                }
                if (v.ItemID == 15)
                {
                    CAMERA15.Text = v.Name;
                }
                if (v.ItemID == 16)
                {
                    CAMERA16.Text = v.Name;
                }

            }


            phidget = new phidget();

            try
            {
                phidget.OpenRFID();
                phidget.RFID.Tag += new RFIDTagEventHandler(AssignARFID);
               

            }
            catch (Exception)
            {
                MessageBox.Show("Error opening the RFID reader.");
            }

      //      MessageBox.Show("Note:itemNr has to be assigned to a product according to the button itemnr");

        }

        private string UpdateProductName(int itemNr, decimal price, string productName)
        {
            bool updated = Equipment.UpdateItem(itemNr, price, productName);

            if (updated)
            {
                return "Successfully Added to the BackEnd";
            }
            else
            {
                return "This product is already added in the database";
            }
        }
       
        private Visitor CheckID(int id)
        {
            return null;
        }

       
        void totalPrice()
        {
            total = 0;
            foreach (var item in orders)
            {
                total += item.Price;
            }
            lbTotalPrice.Text = total.ToString();
        }

        private int CheckID()
        {
            if (phidget.TagNr == RFIDTagNr)
            {
               id = Equipment.GetVistorFromDataBase(id, RFIDTagNr);
            }
            return id;
        }
        public void ChekBalance()
        {
            balance = Equipment.GettTotalBalance(RFIDTagNr);
        }

        private void AssignARFID(object sender, RFIDTagEventArgs e)
        {
            if (phidget.TagNr != null)
            {// the scanned object has a tag code.
                RFIDTagNr = phidget.TagNr;
                lbEventID.Text = RFIDTagNr;

          
                balance = Equipment.GettTotalBalance(RFIDTagNr);
                lbCurrentBalance.Text = balance.ToString();

                if (phidget.TagNr == RFIDTagNr)
                {
                   id = Equipment.GetVistorFromDataBase(id, RFIDTagNr);
                    lbuserid.Text = id.ToString();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 9)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void EquipmentShop_Load(object sender, EventArgs e)
        {

        }

        private void buttonClearItem_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dataGridVisitor.SelectedRows[0].Index;
                dataGridVisitor.Rows.RemoveAt(row);
                orders.RemoveAt(row);
                totalPrice();
            }
            catch (Exception)
            {
                MessageBox.Show("Forbidden to perform this operation please try again");
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            dataGridVisitor.Rows.Clear();
            orders.Clear();
            totalPrice();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Visitor visitor = null;

            if (balance >=0)
            {
                foreach (var item in orders)
                { Equipment.BorrowProduct( item.ItemID,CheckID(),RFIDTagNr); }
                lbCurrentBalance.Text = (balance - total).ToString();
                MessageBox.Show("bought");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 1)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 13)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 5)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Visitor visitor = null;
            
                foreach (var item in orders)
                    Equipment.ReturnProduct(item.ItemID, CheckID(), DateTime.Now);
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbEventID_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                phidget.CloseRFID();
                phidget.RFID.Tag -= new RFIDTagEventHandler(AssignARFID);
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

        private void AddPrODUCTBTN_Click(object sender, EventArgs e)
        {
            

            
               
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void Charger2_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 2)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void Charger3_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 3)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void Charger4_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 4)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void usb6_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 6)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void USB7_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 7)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void USB8_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 8)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void CABLE10_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 10)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void CABLE11_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 11)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void CABLE12_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 12)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void CAMERA14_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 14)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void CAMERA15_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 15)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void CAMERA16_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.ItemID == 16)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                }
            }
            totalPrice();
        }

        private void EquipmentShop_DoubleClick(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridVisitor.Width + 6, this.dataGridVisitor.Height + 6);
            dataGridVisitor.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridVisitor.Width, this.dataGridVisitor.Height));
            e.Graphics.DrawImage(bm, 10, 10);
        }

        private void print_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
