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
    public partial class EventEntrance : Form
    {
        private phidget phidget = null;
        private string RFIDTagNr = null;
        private Visitor_DataHelper visitorData = null;

        public EventEntrance()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // disables reshaping the form.
            MaximizeBox = false;
            lbGreetings.Text = "";
            lbWarning.Text = "";

            phidget = new phidget();
            visitorData = new Visitor_DataHelper();

            try
            {
                phidget.OpenRFID();
                //phidget.RFID.Tag += new TagEventHandler(AssignRFID);
                if (RFIDTagNr == null)
                {
                    textBox1.Text = RFIDTagNr;
                }

            }
            catch (Exception)
            {
                lbRFIDStatus.Text = "There was an error opening the Rfid Reader.";
            }
        }
        private void AssignARFID(object sender, RFIDTagEventArgs e)
        {
            if (phidget.TagNr != null)
            {// the scanned object has a tag code.
                RFIDTagNr = phidget.TagNr;
                textBox1.Text = RFIDTagNr;
            }
        }
        private Visitor CheckForEventID()
        {
            int eventId = Convert.ToInt32(tbEventID.Text);
            return visitorData.GetAVisitor(eventId); // get the participant from the database.
        }
        private bool CheckPaymentStatus(Visitor visitor)
        {
            return visitor.StatusOfPayment;
        }
        private string GiveRFID(int id, string RFIDTagNr)
        {
            bool updated = visitorData.UpdateRFIDStatus(id,RFIDTagNr);

            if (updated)
            {
                return "Allowed to enter into Event.";
            }
            else
            {
                return "The visitor is already inside the event!";
            }
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (tbEventID.Text != "")
            {
                lbRFIDStatus.Text = "";
                lbWarning.Text = "";
                lbGreetings.Text = "";

                phidget.RFID.Tag += new RFIDTagEventHandler(AssignARFID);
                Visitor visitor = CheckForEventID();
                bool paymentStatus;

                if (visitor != null)
                {
                    lbWarning.Text = "The visitor is found.";
                    lbGreetings.Text = "Welcome to VestroVestival Event "+(visitor.Fname)+" "+visitor.Lname+"\nPresent Balance in the visitor account is "+visitor.PresentBalance;
                    paymentStatus = CheckPaymentStatus(visitor);
                    if (paymentStatus)
                    {
                        if (RFIDTagNr != null)
                        {
                            lbGreetings.Text = GiveRFID(visitor.EventID, RFIDTagNr);
                            lbWarning.Text = "";
                        }
                        else
                        {
                            lbRFIDStatus.Text = "Scan an RFID .";
                        }
                    }
                    else
                    {
                        lbWarning.Text = "The entrance fee is pending or not paid yet!";
                    }
                }
            }
        }

        private void lbGreetings_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                lbRFIDStatus.Text = "";
               

                phidget.RFID.Tag += new RFIDTagEventHandler(AssignARFID);
                Visitor visitor = CheckForEventID();
                bool paymentStatus;

                
                   string rfid;
                    
                   
                       rfid = Convert.ToString(textBox1.Text);


                    //     visitorData.AssignTheRFID(rfid);
                       
                        
                        MessageBox.Show("Succesfully added to the database");
                        

                        // lbcurrentStatus.Text = "This User Has been assigned Rfid";
                        //else
                        //{
                        //    MessageBox.Show("Error while assigning rfid to the visitor");
                        //}
                    
                    //lbWarning.Text = "The visitor is found.";
                    //lbGreetings.Text = "Welcome to VestroVestival Event " + (visitor.Fname) + " " + visitor.Lname;
                    paymentStatus = CheckPaymentStatus(visitor);

                    //if (RFIDTagNr != null)
                    //{

                       GiveRFID(visitor.EventID, rfid);
                        lbWarning.Text = "";
                    //}
                    //else
                    //{
                    //    lbRFIDStatus.Text = "Scan an RFID .";
                    //}
                
              
                }
            
        }

        private void EventEntrance_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
