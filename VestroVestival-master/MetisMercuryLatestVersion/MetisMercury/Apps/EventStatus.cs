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
    public partial class EventStatus : Form
    {
        Ticket_DataHelper ticketData;
        CampingSpot_DH campingSpotData;
        Invoice_DH invoiceData;
    Visitor_DataHelper VisitorData;
      Boat_DH boatdata;
        BorrowedEquipments_DH BORROWEDDATA;


        public EventStatus()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // disables reshaping the form.
            MaximizeBox = false;
            DefineDataSource();
        }
        private void DefineDataSource()
        {
            ticketData = new DatabaseClasses.Ticket_DataHelper();
            campingSpotData = new DatabaseClasses.CampingSpot_DH();
            invoiceData = new DatabaseClasses.Invoice_DH();
            VisitorData = new DatabaseClasses.Visitor_DataHelper();
            boatdata = new DatabaseClasses.Boat_DH();
            BORROWEDDATA = new BorrowedEquipments_DH();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Interval = 3000;
            //timer1.Enabled = true;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lbTotalNrSoldTickets.Text = ticketData.GetTicket().ToString();
            // display total number of booked spots:
            lbavisitor.Text = VisitorData.getabsentvisitor().ToString();
            lbtotalcamp.Text = campingSpotData.bOOKEDSPOT().ToString();
            // display total number of sold supplies:
            lbhireditems.Text =BORROWEDDATA .GetTotalbORROWEDeQUIP().ToString();
            lbtotalboat.Text = boatdata.GetBookedBoat().ToString();
            // display total balance of all accounts:
            lbtotalbalnc.Text = VisitorData.CalculateTotalBalance().ToString();
            //???// display number of participant left the event: SELECT COUNT(*) FROM PARTICIPANT WHERE HASCHECKEDIN = 'NO';
            // display present total number of participants:
            lbpvisitor.Text = VisitorData.GetPresentParticipants().ToString();
        }

        private void lbNrVisitorsLeft_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
