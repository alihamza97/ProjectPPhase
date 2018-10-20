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
        MetisMercury.DatabaseClasses.Ticket_DataHelper ticketData;
        MetisMercury.DatabaseClasses.CampingSpot_DH campingSpotData;
        MetisMercury.DatabaseClasses.Invoice_DH invoiceData;
        MetisMercury.DatabaseClasses.Visitor_DataHelper VisitorData;
        MetisMercury.DatabaseClasses.Boat_DH boatdata;


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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Interval = 3000;
            //timer1.Enabled = true;

            //// display total number of sold ticket:
            //lbTotalNrSoldTickets.Text = ticketData.GetTicket().ToString();
            //// display total number of booked spots:
            //lbTotalNrBookedSpots.Text = campingSpotData.BookedSpot().ToString();
            //// display total number of sold supplies:
            //lbTotalNrSoldItems.Text = invoiceData.GetTotalSoldItems().ToString();
            //// display total balance of all accounts:
            //lbTotalBalance.Text = VisitorData.CalculateTotalBalance().ToString();
            ////???// display number of participant left the event: SELECT COUNT(*) FROM PARTICIPANT WHERE HASCHECKEDIN = 'NO';
            //// display present total number of participants:
            //lbNrTotalNrVisitors.Text = VisitorData.GetPresentParticipants().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lbTotalNrSoldTickets.Text = ticketData.GetTicket().ToString();
            // display total number of booked spots:
            lbTotalNrBookedSpots.Text = campingSpotData.BookedSpot().ToString();
            // display total number of sold supplies:
            lbTotalNrSoldItems.Text = invoiceData.GetTotalSoldItems().ToString();
            boatinfo.Text = boatdata.GetBookedBoat().ToString();
            // display total balance of all accounts:
            lbTotalBalance.Text = VisitorData.CalculateTotalBalance().ToString();
            //???// display number of participant left the event: SELECT COUNT(*) FROM PARTICIPANT WHERE HASCHECKEDIN = 'NO';
            // display present total number of participants:
            lbNrTotalNrVisitors.Text = VisitorData.GetPresentParticipants().ToString();
        }
    }
}
