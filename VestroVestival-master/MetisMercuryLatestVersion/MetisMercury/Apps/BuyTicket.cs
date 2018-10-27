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
            Random rnd = new Random();
            TBCUSID.Text = rnd.Next(0,99999).ToString();
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
            decimal balance=200;
            //Visitor vistor = null;
            string lname;
            int id=0;
            string email;
            string city = null ;
            string postcode=null;
            string coutry=null;
            string username=null;
            string pwd=null;
            string street=null;
            int phoneNr=0;
            int checkin=0;
            int Pstatus=0;
            string rfid=null;
            int housenr=0;
            

            if (TBCUSID.Text != "")
            {
                 id = Convert.ToInt32(TBCUSID.Text);
                //id++;
                ticketType = Convert.ToString(tbticketType.Text);
                //balance = Convert.ToDecimal(TBBALANCE.Text);
               fname = Convert.ToString(TBFNAME.Text);
               lname = Convert.ToString(TBLNAME.Text);
                email = Convert.ToString(tbemail.Text);


                if (FRI.Checked)
                {
                    ticketType = "FRI";
                }
                if (SAT.Checked)
                {
                   ticketType = "SAT";
                }
                if (SUN.Checked)
                {
                    ticketType= "SUN";
                }
                if (FRI.Checked && SAT.Checked)
                {
                   ticketType = "FRI-SAT";
                }
                if (FRI.Checked && SUN.Checked)
                {
                   ticketType= "FRI-SUN";
                }
                if (SAT.Checked && SUN.Checked)
                {
                   ticketType= "SAT-SUN";
                }
                if (FRI.Checked && SAT.Checked && SUN.Checked)
                {
                  ticketType = "FRI-SAT-SUN";
                }
               
               
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

        private void TBCUSID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbticketType_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
