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
    public partial class BoatEntrance : Form
    {
        private phidget phidget = null;
        private string RFIDTagNr = null;

        public BoatEntrance()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // disables reshaping the form.
            MaximizeBox = false;
            lbChekingStatus.Text = "";
            lbReservStatus.Text = "";
            phidget = new phidget();

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
        //methods
        private Visitor GetVisitor(string RFID)
        {
            Visitor_DataHelper VisitorData = new Visitor_DataHelper();
            return VisitorData.GetVisitor(RFID);
        }


        private BoatReservation GetAReservation(Visitor visitor)
        {
            BoatReservation_DH reservData = new BoatReservation_DH();
            return reservData.GetReservation(visitor.EventID, visitor.BoatID);
        }

        private bool UpdateStatus(BoatReservation reserv)
        {
            BoatReservation_DH reservData = new BoatReservation_DH();
            return reservData.UpdateCheckingStatus(reserv);
        }

        private void AssignRFID(object sender, RFIDTagEventArgs e)
        {
            if (phidget.TagNr != null)
            {// the scanned object has a tag code.
                RFIDTagNr = phidget.TagNr;
            }
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (RFIDTagNr != null)
            {
                lbChekingStatus.Text = "";
                lbReservStatus.Text = "";
                lbRFIDStatus.Text = "";

                Visitor visitor = GetVisitor(RFIDTagNr);

                if (visitor != null)
                {// retrieved visitor details
                    BoatReservation reserv = GetAReservation(visitor);
                    if (reserv != null)
                    {// reservation found for this participant
                        if (UpdateStatus(reserv))
                        {// participant has checked in
                            lbChekingStatus.Text = "CheckedIn.";
                        }
                        else
                        {
                            lbChekingStatus.Text = "The visitor is already checked into lake.";
                        }
                    }
                    else
                    {
                        lbReservStatus.Text = "No reservation found ";
                    }
                }
                else
                {
                    lbReservStatus.Text = "visitor is not found in the database.";
                }
            }
        }
    }
}
