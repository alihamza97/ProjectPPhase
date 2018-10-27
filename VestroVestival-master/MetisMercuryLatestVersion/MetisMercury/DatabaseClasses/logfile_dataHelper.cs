using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetisMercury.Apps;

namespace MetisMercury.DatabaseClasses
{
    class logfile_dataHelper:DataHelper
    {
        public int savelog(string BankAccount, string StartPeriod, string EndPeriod, string NrDepo, string UserAccount,string amount)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?
            //The return-value is teh number of records affected.
            string Query = string.Format("INSERT INTO `logfiles` (`BankAccountID`, `StartDate`, `EndDate`, `NrOfDeposits`, `UserAccount`, `UserAmount`)" +
                 "VALUES('{0}', '{1}', '{2}', '{3}', '{4}','{5}')", BankAccount, StartPeriod,EndPeriod,NrDepo,UserAccount,amount);
            //String Query = "INSERT INTO BUYTICKETS VALUES (" +
            //    "'" + id + "'," + balance + "," + fname + "," + lname + "," + ticketType + ")";

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
    }
}
