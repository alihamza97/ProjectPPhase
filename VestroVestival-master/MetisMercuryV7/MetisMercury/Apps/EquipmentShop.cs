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
        List<Classes.EquipmentShop> orders;
        List<Classes.EquipmentShop> returned;
        int cusotmerID;
        decimal balance;
        decimal total;
        public EquipmentShop()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // disables reshaping the form.
            MaximizeBox = false;
            visitordata = new Visitor_DataHelper();
            orders = new List<Classes.EquipmentShop>();
            returned = new List<Classes.EquipmentShop>();
            Equipment = new DatabaseClasses.EquipmentShop_DH();


            phidget = new phidget();

            try
            {
                phidget.OpenRFID();
                phidget.RFID.Tag += new RFIDTagEventHandler(AssignARFID);
                if (RFIDTagNr == null)
                {
                    MessageBox.Show("Please scan Rfid.");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error opening the RFID reader.");
            }
        }
        private Visitor CheckID(int id)
        {
            return null;
        }

        //private string Borrow(int id, int itemid, DateTime borrowdate, string RFIDTagNr)
        //{
        //    bool updated = Equipment.BorrowProduct(id, itemid, borrowdate, RFIDTagNr);

        //    if (updated)
        //    {
        //        return "Allowed to enter into Event.";
        //    }
        //    else
        //    {
        //        return "The visitor is already inside the event!";
        //    }
        //}
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

        //private string CheckVistorRFID()
        //{
        //    id = CheckID();
        //    if (phidget.TagNr == RFIDTagNr)
        //    {
        //        id = visitordata.GetVisitor(RFIDTagNr);
        //    }
        //    return RFIDTagNr;
        //}

        //private string ChekRfid()
        //{
        //    if (phidget.TagNr == RFIDTagNr)
        //    {
        //        RFIDTagNr = Equipment.GetVistorFromDataBase(id, RFIDTagNr);
        //    }

        //}
        private void AssignARFID(object sender, RFIDTagEventArgs e)
        {
            if (phidget.TagNr != null)
            {// the scanned object has a tag code.
                RFIDTagNr = phidget.TagNr;
                lbEventID.Text = RFIDTagNr;

             //   int id = Convert.ToInt32(lbuserid.Text);

                Visitor visitor = null;
             //   lbuserid.Text = "id"+visitor.EventID;
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
                if (item.Name == "USBCable")
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
                { Equipment.BorrowProduct( item.ItemID,CheckID(), DateTime.Now,RFIDTagNr); }
                lbCurrentBalance.Text = (balance - total).ToString();
            }
            ////lbCurrentBalance.Text = (balance-total).ToString();
            //else
            //{
            //    MessageBox.Show("You do not have enough money to hire products");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.Name == "Charger")
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
                if (item.Name == "Camera")
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
                if (item.ItemID==1)
                {
                    //changing the quantity. previous quantity was the quantity we had and now quantity is the quantity what buy asked

                    orders.Add(item);
                    dataGridVisitor.Rows.Add(item.Name, item.Price);
                    button4.Text = item.Name;
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
    }
}
