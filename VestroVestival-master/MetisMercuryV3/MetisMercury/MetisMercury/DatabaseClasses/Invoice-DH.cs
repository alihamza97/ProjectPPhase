using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MetisMercury.Classes;

namespace MetisMercury.DatabaseClasses
{
    class Invoice_DH:DataHelper
    {
        //TODO
        //this class will insert the data into invoiceline

        public int GetTotalSoldItems()
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM INVOICE", connection);

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                r.Read();

                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch
            {
                //in case if error occurs
                return -1;
            }
        }

        public int GetSoldItems(int itemNr, int invoiceNr, int quantity)
        {
            string Query = string.Format("INSERT INTO INVOICELINE(ITEMNR, INVOICEID, QUANTITY)" +
                "VALUES({0}, {1}, {2})", itemNr, invoiceNr, quantity);

            MySqlCommand command = new MySqlCommand(Query, connection);

            try
            {
                connection.Open();
                int numberOfRows = command.ExecuteNonQuery();
                return numberOfRows;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
