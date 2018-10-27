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
        List<Classes.EquipmentsShop> returned;
        Visitor_DataHelper visitorData = null;
        EquipmentShop_DH Equipmentdata;
        private int id;
        private BorrowedEquipments_DH borrowedEquimentData = null;
        public Exit()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // disables reshaping the form.
            MaximizeBox = false;
            lbWarnings.Text = "";
            visitorData = new Visitor_DataHelper();
            returned = new List<Classes.EquipmentsShop>();
            items = new List<BorrowedEquipment>();
            phidget = new phidget();
            Equipmentdata = new EquipmentShop_DH();
            borrowedEquimentData = new BorrowedEquipments_DH();
        //    MessageBox.Show("Please scan an rfid chip for checking out");
          


            try
            {
                phidget.OpenRFID();
                phidget.RFID.Tag += new RFIDTagEventHandler(AssignRFID);
                if (RFIDTagNr == null)
                {
                    lbRFIDStatus.Text = "ScanRFID";
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

        private int CheckID()
        {
            if (phidget.TagNr == RFIDTagNr)
            {
                id = Equipmentdata.GetVistorFromDataBase(id, RFIDTagNr);
            }
            return id;
        }

        //private bool isHiredItems(Visitor visitor)
        //{
        //    BorrowedEquipments_DH itemsData = new BorrowedEquipments_DH();
        //    items = itemsData.GetBorrowedItems(visitor.EventID,visitor.RFID);

        //    if (items.Count > 0)
        //    {// there are some  items
        //        return true;
        //    }
        //    else
        //    {// no  items
        //        return false;
        //    }
        //}

        private void Status()
        {
            if (RFIDTagNr != null)
            {// RFID tag number is reader
            //    lbEquipment.Text = "";
             //   lbRemainingBlnc.Text = "";
                lbRFIDStatus.Text = RFIDTagNr;
                lbWarnings.Text = "";

                Visitor visitor = GetVisitor(RFIDTagNr);
                Visitor_DataHelper visitorData = new Visitor_DataHelper();

                visitorData.CheckOut(RFIDTagNr);

                if (visitor != null)
                {// participant exists
                    lbRemainingBalance.Text = visitor.PresentBalance.ToString(); // display their balance


                //    if (isHiredItems(visitor))
                //    {
                //   //     lbEquipment.Text = "Some items are not returned.";
                //    }
                //    else
                //    {
                //  //      lbEquipment.Text = "No hired items.";
                //    }
                //}
                //else
                //{
                    lbWarnings.Text = "RFID set to null.";
                }
            }
            else
            {
                lbRFIDStatus.Text = "ScanRFID";
            }
        }

        private Visitor CheckForid()
        {
            int id = Convert.ToInt32(textBox1.Text);
            return visitorData.GetAVisitor(id); // get the participant from the database.
        }

        private BorrowedEquipment CheckForItemID()
        {
            int id = Convert.ToInt32(textBox1.Text);
            return borrowedEquimentData.GetAITEM(id); // get the participant from the database.
        }

       

        private void AssignRFID(object sender, RFIDTagEventArgs e)
        {
            if (phidget.TagNr != null)
            {// the scanned object has a tag code.
                RFIDTagNr = phidget.TagNr;
                id = Equipmentdata.GetVistorFromDataBase(id, RFIDTagNr);
               // MessageBox.Show("Your Event is "+id.ToString()+" \n please enter into the textbox");
                textBox1.Text = id.ToString();
                Status();
            }
            else
            {
                lbRFIDStatus.Text = "Scan an RFID.";
            }
        }

        private void Exit_Load(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
        
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

              

                try
                {
                    Equipmentdata.ReturnItem(borrowedequip.EventID);
                    // MessageBox.Show("Successfully returned");
                    label19.Text = "SuccessFully Returned";

                    MessageBox.Show("GOOD BYE STAY HAPPY :)");
                 //   label20.Text = "" + visitor.PresentBalance;
                    //if (RFIDTagNr == null)
                    //{
                    //    MessageBox.Show("please scan a rfid");
                    //}
                    //else
                    //{
                    //    visitorData.CheckOut(RFIDTagNr);
                    //    MessageBox.Show("you can now checkout");
                    //}
                }
                catch (Exception) { MessageBox.Show("This user does not has any hired equipments"); }
               
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
