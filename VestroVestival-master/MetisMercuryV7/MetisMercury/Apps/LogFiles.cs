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

namespace MetisMercury.Apps
{
    public partial class LogFiles : Form
    {
        private logfile_dataHelper LogData=null;
        private List<logfile> mylog;
        public LogFiles()
        {
            InitializeComponent();
            mylog = new List<logfile>();
            LogData = new logfile_dataHelper();
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
                    String s;
                    s = sr.ReadLine();
               //     BankAccountnr = sr.ReadLine();
                    while (s != null)
                    {
                      listBox1.Items.Add(s);
                        //    s = sr.ReadLine();
                        s = sr.ReadLine();
                       
                        //startPeriod = Convert.ToString(sr.ReadLine());
                        //Endperiod = Convert.ToString(sr.ReadLine());
                        //nrDepo = Convert.ToString(sr.ReadLine());

                        //  BankAccountnr = sr.ReadLine();
                      //  userAccount = sr.ReadLine();
                     
                   //   amount = Convert.ToString(sr.ReadLine());
                      //  BankAccountnr = sr.ReadLine();
                        // this.mylog.Add(new logfile(BankAccountnr, startPeriod, Endperiod, userAccount, nrDepo, amount));
                    //    logfile = new logfile(BankAccountnr, startPeriod, Endperiod, userAccount, nrDepo, amount);
                        //   mylog.Add(logfile);
                        //listBox1.Items.Add(BankAccountnr);
                      //  listBox1.Items.Add(mylog);
                        //foreach(logfile f in mylog)
                        //{
                        //    listBox1.Items.Add(f);
                        //}
                    }
                }
                catch (IOException)
                {
                    listBox1.Items.Add("something went wrong, IOException was thrown");
                }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
                listBox1.Items.Add("*************loading is done*********************");
            }
            else
            {
                MessageBox.Show("there was an error opening the windows");
            }

    }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            string bankaccount;
            string start;
            string end;
            int logid;
            int nrdepo;
            string useraccount;
            decimal amount;
            bankaccount = lbbankacnt.Text;
            start = lbstart.Text;
            end = lbend.Text;
            logid = Convert.ToInt32(lblogid.Text);
            nrdepo = Convert.ToInt32(lbnrdepo.Text);
            useraccount = lbuseracnt.Text;
            amount = Convert.ToDecimal(lbamount.Text);

            int nradded = LogData.AssignTicket(logid, bankaccount, start, end, nrdepo, useraccount, amount);
            if (nradded > 0)
            {
                MessageBox.Show("successfully added to the database");
            }
            else
            {
                MessageBox.Show("you made an error please try again");
            }
        }
    }
}
