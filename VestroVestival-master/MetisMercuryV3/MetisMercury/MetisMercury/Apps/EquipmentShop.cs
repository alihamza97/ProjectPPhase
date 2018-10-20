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
        private Visitor visitor;
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
        void totalPrice()
        {
            total = 0;
            foreach (var item in orders)
            {
                total += item.Price;
            }
            lbTotalPrice.Text = total.ToString();
        }
        private void AssignARFID(object sender, RFIDTagEventArgs e)
        {
            if (phidget.TagNr != null)
            {// the scanned object has a tag code.
                RFIDTagNr = phidget.TagNr;
                lbEventID.Text = RFIDTagNr;

                balance = Equipment.GettTotalBalance(RFIDTagNr);
                lbCurrentBalance.Text = balance.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in Equipment.GetEquipments())
            {
                if (item.Name == "USB")
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
            if (balance >=0)
            {
                foreach (var item in orders)
                { Equipment.BorrowProduct(item.ItemID,DateTime.Now,RFIDTagNr); }
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
                if (item.Name == "USB flash drive")
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
            {
                foreach (var item in orders)
                    Equipment.ReturnProduct(item.ItemID, DateTime.Now, RFIDTagNr);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
