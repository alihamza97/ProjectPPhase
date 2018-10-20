using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MetisMercury.Classes;
using System.Windows.Forms;

namespace MetisMercury.DatabaseClasses
{
    class AssignRFID_DataHelper:DataHelper
    {

        public int AssignTheRFID(string rfid, decimal balance, string fname)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?
            //The return-value is teh number of records affected.
            string Query = string.Format("INSERT INTO visitor(FNAME, RFID, BALANCE)" +
                 "VALUES({0}, {1}, {2})", rfid, balance, fname);
            MySqlCommand command = new MySqlCommand(Query, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch
            {
                return -1; // MessageBox.Show("Error");//which means the try-block was not executed succesfully, so  . . .
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
        //public List<AssignRfid> getAssignedRfid()
        //{
        //    String sql = "SELECT * FROM RFID";
        //    MySqlCommand command = new MySqlCommand(sql, connection);

        //    List<AssignRfid> temp;
        //    temp = new List<AssignRfid>();

        //    try
        //    {
        //        connection.Open();
        //        MySqlDataReader reader = command.ExecuteReader();

        //        String fname;
        //        string rfid;
        //        decimal balance;
        //        while (reader.Read())
        //        {
        //            fname = Convert.ToString(reader["FNAME"]);
        //            rfid = Convert.ToString(reader["RFID"]);
        //            balance = Convert.ToDecimal(reader["BALANCE"]);
        //            temp.Add(new AssignRfid(fname,rfid,balance));
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("error while loading the students");
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return temp;
        //}
    }
}
