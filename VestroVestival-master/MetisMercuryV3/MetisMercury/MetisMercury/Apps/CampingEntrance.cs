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
    public partial class CampingEntrance : Form
    {
        private phidget phidget = null;
        private string RFIDTagNr = null;

        public CampingEntrance()
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


        private CampingReservation GetAReservation(Visitor visitor)
        {
            CampingReservation_DataHelper reservData = new CampingReservation_DataHelper();
            return reservData.GetReservation(visitor.EventID, visitor.CampingSpotID);
        }

        private bool UpdateStatus(CampingReservation reserv)
        {
            CampingReservation_DataHelper reservData = new CampingReservation_DataHelper();
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
                    CampingReservation reserv = GetAReservation(visitor);
                    if (reserv != null)
                    {// reservation found for this participant
                        if (UpdateStatus(reserv))
                        {// participant has checked in
                            lbChekingStatus.Text = "CheckedIn.";
                        }
                        else
                        {
                            lbChekingStatus.Text = "The visitor is already checked into CampingSpot.";
                        }
                    }
                    else
                    {
                        lbReservStatus.Text = "No reservation found ";
                    }
                }
                else
                {
                    lbReservStatus.Text = "visitor doesn't exists in the database.";
                }
            }
        }

        private void CampingEntrance_Load(object sender, EventArgs e)
        {

        }
    }
}
