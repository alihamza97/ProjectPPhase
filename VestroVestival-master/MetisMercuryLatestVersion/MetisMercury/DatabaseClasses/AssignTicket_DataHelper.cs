using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MetisMercury.Classes;
using System.Windows.Forms;
using MetisMercury.Apps;

namespace MetisMercury.DatabaseClasses
{
    class AssigntTicket_DataHelper:DataHelper
    {

        public int AssignTicket(int id, decimal balance, string lname,string fname, string email,string username,string pwd,string pcode,string street,int HNr,string city,string country,int phoneNr,string ticketType,int checkin,int paymentStatus,string rfid)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?
            //The return-value is teh number of records affected.
                    string Query = string.Format
            ("INSERT INTO `visitor` (`EventID`, `PresentBalance`, `LName`, `FName`, `Email`, `Username`, `Userpassword`, `Postcode`, `Street`, `Housenumber`, `City`, `Country`, `Phonenumber`, `TicketType`, `hasCheckedin`, `StatusOfPayment`, `RFID`)  VALUES ( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}','{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}')"
             , id, balance, lname,fname , email,
             username, pwd, pcode,
             street, HNr, city,
             country, phoneNr, ticketType,
             checkin, paymentStatus, rfid);
            //String Query = "INSERT INTO visitor VALUES (" +
            //   "" + id + "," + balance + ",'" + fname + "','" + lname + "','" + DBNull.Value + "','" + DBNull.Value + "','" + DBNull.Value + "','" + DBNull.Value + "','" + DBNull.Value + "'," + DBNull.Value + ",'" + DBNull.Value + "','" + DBNull.Value + "'," + DBNull.Value + ",'" + DBNull.Value + "'," + DBNull.Value + "," + DBNull.Value + ",'" + DBNull.Value + "')";


            //           string Query = string.Format
            //("INSERT INTO `equipmentsshop` (`ItemID`, `Name`, `Price`) VALUES ('{0}', '{1}', '{2}')",id,DBNull.Value,DBNull.Value);
                      MySqlCommand command = new MySqlCommand(Query, connection);
            
            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch
            {

                MessageBox.Show("Error");

                return -1; //which means the try-block was not executed succesfully, so  . . .
            }
            finally
            {
                connection.Close();
            }
        }

        public int giveticket(int id, string fname/*, string ticketType*/)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?
            //The return-value is teh number of records affected.
            string Query = string.Format("INSERT INTO `tickets` (`TICKETID`, `TICEKTYPE`) VALUES ('{0}', '{1}')",id,DBNull.Value);
            //String Query = "INSERT INTO visitor VALUES (" +
            //    "" + id + "," + balance + ",'" + fname + "','" + lname + "','" + email + "','" + RFID + "')";

            MySqlCommand command = new MySqlCommand(Query, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch
            {

                MessageBox.Show("Error");
                return -1; //which means the try-block was not executed succesfully, so  . . .
            }
            finally
            {
                connection.Close();
            }
        }
        public bool UpdateRFIDStatus(Visitor visitor, string rfid)
        {
            //if (visitor.IsChekedin)
            //{// visitor is already inside the event.
            //    return false;
            //}

            MySqlCommand command = new MySqlCommand("UPDATE VISITOR SET RFID = '" + rfid + "', ISCHECKEDIN = '0' WHERE EVENTID = " + visitor.EventID, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error updating status of RFID.");
            }
            finally
            {
                connection.Close();
            }

            return true;
        }
        //public List<logfile> InsertLogFiles()
        //{
        //    // String sql = "SELECT * FROM RFID";
        //    //MySqlCommand command = new MySqlCommand(, connection);

        //    //List<logfile> temp;
        //    //temp = new List<logfile>();

        //    try
        //    {
            //    connection.Open();
            //    MySqlCommand command = new MySqlCommand("INSERT INTO 'LOGFILES'('Bank");
            //    command.ExecuteReader();

            //    String fname;
            //    string rfid;
            //    decimal balance;
            //    //while (reader.Read())
            //    //{
            //    //    fname = Convert.ToString(reader["FNAME"]);
            //    //    rfid = Convert.ToString(reader["RFID"]);
            //    //    balance = Convert.ToDecimal(reader["BALANCE"]);
            //    //    temp.Add(new AssignRfid(fname, rfid, balance));
            //    //}
            //}
            //catch
            //{
            //    MessageBox.Show("error while loading the students");
            //}
            //finally
            //{
            //    connection.Close();
            //}
          //  return temp;
       // }
    }
}
