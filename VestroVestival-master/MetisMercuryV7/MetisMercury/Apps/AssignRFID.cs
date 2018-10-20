using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetisMercury.Classes;
using MetisMercury.DatabaseClasses;

namespace MetisMercury.Apps
{
    public partial class AssignRFID : Form
    {
        private AssigntTicket_DataHelper RDH;

        public AssignRFID()
        {
            InitializeComponent();
            RDH = new AssigntTicket_DataHelper();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //string rfid;
            //String fname;
            //decimal balance;

            //if (tbName.Text != "" && tbrfid.Text != "" && tbBalance.Text != "")
            //{
            //    rfid = Convert.ToString(tbrfid.Text);
            //    balance = Convert.ToDecimal(tbBalance.Text);
            //    fname = Convert.ToString(tbName.Text);
            //   int nrAdded=  RDH.AssignTheRFID(rfid, balance, fname);

            //    if (nrAdded > 0)
            //    {
            //        MessageBox.Show("Succesfully added to the database");
            //   }
            //    else
            //   {
            //       MessageBox.Show("Error while assigning rfid to the visitor");
            //   }
            //}
            string rfid;
            String fname;
            decimal balance;
            Visitor vistor = null;
            if (tbrfid.Text != "")
            {
                rfid = Convert.ToString(tbrfid.Text);
                //balance = Convert.ToDecimal(tbBalance.Text);
                //fname = Convert.ToString(tbName.Text);
                //int nrAdded = RDH.AssignTheRFID(rfid, balance, fname);
                RDH.UpdateRFIDStatus(vistor, rfid);

                //if (nrAdded > 0)
                //{
                MessageBox.Show("Succesfully added to the database");
                //}
                //else
                //{
                //   MessageBox.Show("Error while assigning rfid to the visitor");
                // }
            }
        }

        private void btnLoadAllStudents_Click(object sender, EventArgs e)
        {
            //List<AssignRfid> list;
            //list = RDH.get();

            //this.listBox1.Items.Clear();
            //foreach (AssignRfid f in list)
            //{
            //    listBox1.Items.Add(f.ToString());
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbrfid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
