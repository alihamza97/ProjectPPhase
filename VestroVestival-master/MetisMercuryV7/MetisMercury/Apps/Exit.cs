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
    public partial class Exit : Form
    {
        private phidget phidget = null;
        private string RFIDTagNr = null;
        List<BorrowedEquipment> items = null;
        //     Visitor_DataHelper visitordata = null;
        List<Classes.EquipmentShop> returned;
        Visitor_DataHelper visitorData = null;
        EquipmentShop_DH Equipmentdata;
        private BorrowedEquipments_DH borrowedEquimentData = null;
        public Exit()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // disables reshaping the form.
            MaximizeBox = false;
            lbWarnings.Text = "";
            visitorData = new Visitor_DataHelper();
            returned = new List<Classes.EquipmentShop>();
            items = new List<BorrowedEquipment>();
            phidget = new phidget();
            Equipmentdata = new EquipmentShop_DH();
            borrowedEquimentData = new BorrowedEquipments_DH();

            try
            {
                phidget.OpenRFID();
                phidget.RFID.Tag += new RFIDTagEventHandler(AssignRFID);
                if (RFIDTagNr == null)
                {
                    lbRFIDStatus.Text = "Scan an RFID chip.";
                }

            }
            catch (Exception)
            {
                lbRFIDStatus.Text = "Error while opening the RFID reader.";
            }
        }

        private Visitor GetVisitor(string RFID)
        {
            Visitor_DataHelper visitorData = new Visitor_DataHelper();
            return visitorData.GetVisitor(RFID);
        }

        private bool isHiredItems(Visitor visitor)
        {
            BorrowedEquipments_DH itemsData = new BorrowedEquipments_DH();
            items = itemsData.GetBorrowedItems(visitor.EventID,visitor.RFID);

            if (items.Count > 0)
            {// there are some  items
                return true;
            }
            else
            {// no  items
                return false;
            }
        }

        //private string SetReturndate(int id)
        //{
        //    string b = returndate.ToShortDateString();
        //    bool updated = borrowedEquimentData.GetAITEM(id);

        //    if (updated)
        //    {
        //        return "SuccessFully Returned.";
        //    }
        //    else
        //    {
        //        return "no hired items";
        //    }
        //}

        private void Status()
        {
            if (RFIDTagNr != null)
            {// RFID tag number is reader
                lbEquipment.Text = "";
                lbRemainingBlnc.Text = "";
                lbRFIDStatus.Text = RFIDTagNr;
                lbWarnings.Text = "";

                Visitor visitor = GetVisitor(RFIDTagNr);
                Visitor_DataHelper visitorData = new Visitor_DataHelper();
                if (visitor != null)
                {// participant exists
                    lbRemainingBalance.Text = visitor.PresentBalance.ToString(); // display their balance
                    if (isHiredItems(visitor))
                    {
                        lbEquipment.Text = "Some items are not returned.";
                    }
                    else
                    {
                        lbEquipment.Text = "No hired items.";
                    }
                }
                else
                {
                    lbWarnings.Text = "visitor doesn't exist.";
                }
            }
            else
            {
                lbRFIDStatus.Text = "Scan an RFID chip.";
            }
        }

        private Visitor CheckForid()
        {
            int id = Convert.ToInt16(textBox1.Text);
            return visitorData.GetAVisitor(id); // get the participant from the database.
        }

        private BorrowedEquipment CheckForItemID()
        {
            int id = Convert.ToInt16(textBox1.Text);
            return borrowedEquimentData.GetAITEM(id); // get the participant from the database.
        }

        //private BorrowedEquipment CheckForitemid()
        //{
        //    int id = Convert.ToInt16(textBox1.Text);
        //    return equip.GetAVisitor(id); // get the participant from the database.
        //}

        private void AssignRFID(object sender, RFIDTagEventArgs e)
        {
            if (phidget.TagNr != null)
            {// the scanned object has a tag code.
                RFIDTagNr = phidget.TagNr;
                Status();
            }
            else
            {
                lbRFIDStatus.Text = "Scan an RFID object.";
            }
        }

        private void Exit_Load(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Visitor_DataHelper visitorData = new Visitor_DataHelper();

            if (RFIDTagNr == null)
            {
                lbRFIDStatus.Text = "";
                lbWarnings.Text = "";

                //   Visitor visitor = GetVisitor(RFIDTagNr);
                Visitor visitor = CheckForid();
                BorrowedEquipments_DH BorrowedItemsData = new BorrowedEquipments_DH();

                items = BorrowedItemsData.GetBorrowedItems(visitor.EventID,visitor.RFID);

                if (visitor != null)
                {// participant exists
                    if (visitor.PresentBalance>= 0 && items.Count == 0)
                    {// no borrowed items and their balance is 0
                       visitorData.CheckOut(RFIDTagNr);
                        lbWarnings.Text = "Problem";
                        lbEventID.Text = "Visitor Found";
                      
                    }
                    else
                    {
                        lbWarnings.Text = "No Hired Item found";
                        lbRemainingBlnc.Text = ""+visitor.PresentBalance;
                        lbEquipment.Text = "" + "Returened\nlet the visitor go";
                    }
                }
            }
            else
            {
                lbRFIDStatus.Text = "Scan an RFID object.";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Visitor_DataHelper visitorData = new Visitor_DataHelper();
            timer1.Interval = 3000;
            timer1.Enabled = true;

            int nr = visitorData.GetPresentParticipants();
            //if (nr > -1)
            //{
            //    totalVisitors.Text = nr.ToString();
            //}
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void lbRFIDStatus_Click(object sender, EventArgs e)
        {

        }

        private void lbWarnings_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void lbTotalParticipants_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            //foreach (var item in returned)
            //{
            //    Equipmentdata.ReturnProduct(item.ItemID,item.)
            //}

            if (textBox1.Text != "")
            {
                Visitor visitor = CheckForid();
                BorrowedEquipment borrowedequip = CheckForItemID();

                DateTime updateReturnDate;

                updateReturnDate = Convert.ToDateTime(dateTimePicker1.Value);

                Equipmentdata.ReturnItem(borrowedequip.EventID);

                MessageBox.Show("Return Date added to DB");
            }
                
        }
    }
}
