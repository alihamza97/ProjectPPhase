using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetisMercury.Classes;
using MetisMercury.DatabaseClasses;
using MySql.Data.MySqlClient;

namespace MetisMercury.Apps
{
    public partial class LogFiles : Form
    {
        private logfile_dataHelper LogData=null;
        private List<logfile> mylog;
        DataHelper datahelper = null;
        public LogFiles()
        {
            InitializeComponent();
            mylog = new List<logfile>();
            LogData = new logfile_dataHelper();
             datahelper = new DataHelper();
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                
                try
                {
                    fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    //   String s;
                    // s = sr.ReadLine();
                    string bankaccount;
                    bankaccount = sr.ReadLine();
                    while (bankaccount != null)
                    {
             //   s = sr.ReadLine();  
                    //   listBox1.Items.Add(s);
                        string  start, end, nrdeposit, useraccount, useramount,logid;
                        //logid = sr.ReadLine();
                      //  s = sr.ReadLine();
                        bankaccount = sr.ReadLine();
                        start = sr.ReadLine();                    
                        end = sr.ReadLine();
                       // nrdeposit = sr.ReadLine();
                        useraccount = sr.ReadLine();
                        nrdeposit = sr.ReadLine();
                        useramount = sr.ReadLine();
                        // listBox1.Items.Add(s);
                        // foreach(ListBox items in listBox1.Items)
                        //  label1.Text = s;
                      //  s = sr.ReadLine();
                        logfile temp = new logfile(bankaccount, start, end, nrdeposit, useraccount, useramount);
                        mylog.Add(temp);
                        bankaccount = sr.ReadLine();
                        //bankaccount = sr.ReadLine();
                     // s = sr.ReadLine();  
                    
                      
                    }
                  
                }
                catch (IOException)
                {
                    MessageBox.Show("something went wrong, IOException was thrown");
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
                MessageBox.Show("*************loading is done*********************");
            }
            else
            {
                MessageBox.Show("there was an error opening the windows");
            }


            foreach (var v in mylog)
            {
                int nrAdded = LogData.savelog((v.BankAccountID), v.StartDate, v.EndDate, v.NrOfDeposit, v.UserAccount, v.amount);
                if (nrAdded > 0)
                {
                    MessageBox.Show("successfully added to the database");
                }
                else
                {
                    MessageBox.Show("you made an error please try again");
                }
            }


        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
                    
                    
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
