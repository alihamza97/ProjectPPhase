using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetisMercury.Classes;
using MetisMercury.DatabaseClasses;
using Phidget22.Events;

namespace MetisMercury.Apps
{
    public partial class CampingCheckIn : Form
    {
        private phidget phidget = null;
        private string RFIDTagNr = null;
        private CampingSpot_DH campingData = null;
        private Visitor_DataHelper visitordata;
        public CampingCheckIn()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // disables reshaping the form.
            MaximizeBox = false;
            lbGreetings.Text = "";
            lbWarning.Text = "";

            phidget = new phidget();
            campingData = new CampingSpot_DH();

            try
            {
                phidget.OpenRFID();
                //phidget.RFID.Tag += new TagEventHandler(AssignRFID);
                if (RFIDTagNr == null)
                {
                    lbRFIDStatus.Text = "Scan an RFID chip.";
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
        private CampingSpot CheckForSpotID()
        {
            int spotid = Convert.ToInt16(tbspotID.Text);
            return campingData.GetASpot(spotid); // get the participant from the database.
        }
        private bool CheckPaymentStatus(CampingSpot spot)
        {
            return spot.HasPaid;
        }
        //private string GiveRFID(Visitor visitor, string RFIDTagNr)
        //{
        //    bool updated = visitordata.UpdateRFIDStatus(/*visitor,*/ RFIDTagNr);

        //    if (updated)
        //    {
        //        return "Allowed to enter into Event.";
        //    }
        //    else
        //    {
        //        return "The visitor is already inside the spot!";
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
                CampingSpot spot = CheckForSpotID();
                bool paymentStatus;

                if (spot != null)
                {
                    lbWarning.Text = "The visitor has made a reserveration.";
                    lbGreetings.Text = "Welcome to VestroVestival campingSpot " ;
                    paymentStatus = CheckPaymentStatus(spot);
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
                        lbWarning.Text = "The campingSpot fee is pending or not paid yet!";
                    }
                }
            }
        }

        private void CampingCheckIn_Load(object sender, EventArgs e)
        {

        }
    }
}
