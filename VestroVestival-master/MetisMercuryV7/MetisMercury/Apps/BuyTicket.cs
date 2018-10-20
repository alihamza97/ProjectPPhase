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

namespace MetisMercury.Apps
{
    public partial class BuyTicket : Form
    {
        private AssigntTicket_DataHelper ticketData;

        public BuyTicket()
        {
            InitializeComponent();
            ticketData = new AssigntTicket_DataHelper();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string ticketType;
            string fname;
            decimal balance;
            Visitor vistor = null;
            string lname;
            int id;
            string email;
            string city;
            string postcode;
            string coutry;
            string username;
            string pwd;
            string street;
            int phoneNr;
            int checkin;
            int Pstatus;
            string rfid;
            int housenr;


            if (TBCUSID.Text != "")
            {
                id = Convert.ToInt32(TBCUSID.Text);
                ticketType = Convert.ToString(tbticketType.Text);
                balance = Convert.ToDecimal(TBBALANCE.Text);
               fname = Convert.ToString(TBFNAME.Text);
               lname = Convert.ToString(TBLNAME.Text);
                email = Convert.ToString(tbemail.Text);
                pwd = Convert.ToString(tbpwd.Text);
                housenr = Convert.ToInt32(tbhousenr.Text);
                username = Convert.ToString(tbusername.Text);
                postcode = Convert.ToString(tbpostcode.Text);
                city = Convert.ToString(tbcity.Text);
                coutry = Convert.ToString(tbcountry.Text);
                rfid = Convert.ToString(tbrfid.Text);
                street = Convert.ToString(tbstreet.Text);
                phoneNr = Convert.ToInt32(tbphone.Text);
                checkin = Convert.ToInt32(tbcheckin.Text);
                Pstatus = Convert.ToInt32(tbstatus.Text);





                //int nrAdded = RDH.AssignTheRFID(rfid, balance, fname);
                // RDH.UpdateRFIDStatus(vistor, rfid);

                int nrAdded =  ticketData.AssignTicket(id,balance,lname,fname,email,username,pwd,postcode,street,housenr,city,coutry,phoneNr,ticketType,checkin,Pstatus,rfid);
                if (nrAdded > 0)
                {
                MessageBox.Show("Succesfully added to the database");
                }
                else
                {
                   MessageBox.Show("Error while BUYING TICKET to the visitor");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
