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
    public partial class BoatCheckIn : Form
    {
        private phidget phidget = null;
        private string RFIDTagNr = null;
        private Boat_DH boatData = null;
        private Visitor_DataHelper visitordata;
        public BoatCheckIn()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // disables reshaping the form.
            MaximizeBox = false;
            lbGreetings.Text = "";
            lbWarning.Text = "";

            phidget = new phidget();
            boatData = new Boat_DH();

            try
            {
                phidget.OpenRFID();
                //phidget.RFID.Tag += new TagEventHandler(AssignRFID);
                if (RFIDTagNr == null)
                {
                    lbRFIDStatus.Text = "Current Status";
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
                lbRFIDStatus.Text = RFIDTagNr;
            }
        }
        private Boat CheckForBoatID()
        {
            int spotid = Convert.ToInt16(tbspotID.Text);
            return boatData.GetABoat(spotid); // get the participant from the database.
        }
        private bool CheckPaymentStatus(Boat boat)
        {
            return boat.HasPaid;
        }
        //private string GiveRFID(Visitor visitor, string RFIDTagNr)
        //{
        //    bool updated = visitordata.UpdateRFIDStatus(visitor, RFIDTagNr);

        //    if (updated)
        //    {
        //        return "Allowed to enter into Lake.";
        //    }
        //    else
        //    {
        //        return "The visitor is already inside the Lake!";
        //    }
        //}

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (tbspotID.Text != "")
            {
                lbRFIDStatus.Text = "";
                lbWarning.Text = "";
                lbGreetings.Text = "";

                phidget.RFID.Tag += new RFIDTagEventHandler(AssignARFID);
                Boat boat = CheckForBoatID();
                bool paymentStatus;

                if (boat != null)
                {
                    lbWarning.Text = "The visitor has made a Boat reserveration.";
                    lbGreetings.Text = "Welcome to VestroVestival Lake ";
                    //  lbRFIDStatus.Text = "The Visitor has made\n boat reservation on " + boat.Day;
                    lbDAY.Text = "day:"+boat.Day;
                    lbstart.Text = "From:" + boat.StartTime;
                    lbend.Text = "Untill:" + boat.EndTime;
                    paymentStatus = CheckPaymentStatus(boat);
                    if (paymentStatus)
                    {
                        if (RFIDTagNr != null)
                        {
                            lbGreetings.Text = "had a Rfid already";
                            lbWarning.Text = "";
                        }
                        else
                        {
                            lbRFIDStatus.Text = "Scan an RFID .";
                        }
                    }
                    else
                    {
                        lbWarning.Text = "The Lake fee is pending or not paid yet!";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
