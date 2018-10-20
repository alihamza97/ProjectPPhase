using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetisMercury.Classes;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MetisMercury.DatabaseClasses
{
    class Cafeteria_DataHelper:DataHelper
    {
        public List<Cafeteria> getItems()
        {
            string Query = "SELECT * FROM CAFETERIA";
            MySqlCommand command = new MySqlCommand(Query, connection);

            List<Cafeteria> rows = new List<Cafeteria>();

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                int itemNr;
                decimal price;
                string name;
                int quantity;
                int shopNr;

                while (r.Read())
                {
                    itemNr = Convert.ToInt32(r["ITEMNR"]);
                    price = Convert.ToDecimal(r["PRICE"]);
                    name = r["NAME"].ToString();
                //    shopNr = Convert.ToInt32(r["SHOPNR"]);
                    quantity = Convert.ToInt32(r["QUANTITY"]);

                    rows.Add(new Cafeteria( price, name,quantity));
                }
            }
            catch
            {
                MessageBox.Show("Couldnt Load items");
            }
            finally
            {
                connection.Close();
            }
            return rows;
        }

        public bool BuyProduct(string RFID, decimal NewBalNC)
        {
            string Query = "UPDATE VISITOR SET PRESENTBALANCE = " + NewBalNC + " WHERE RFID='" + RFID + "'";
            MySqlCommand command = new MySqlCommand(Query, connection);
            try
            {
                connection.Open();
                int NumberChanges = command.ExecuteNonQuery();
                if (NumberChanges == 0)
                { return false; }
                else
                    return true;
            }
            catch
            {
                MessageBox.Show("Couldnt LOAD please try again");
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public decimal GetPresentBalance(string RFID)
        {
            string Query = "SELECT PRESENTBALANCE FROM VISITOR WHERE RFID = '" + RFID + "'";
            MySqlCommand command = new MySqlCommand(Query, connection);
            decimal balnce = 0;
            try
            {
                connection.Open();
                balnce = Convert.ToDecimal(command.ExecuteScalar());

            }
            catch(Exception)
            {
                MessageBox.Show("Couldnt Load");
            }
            finally
            {
                connection.Close();
            }
            return balnce;
        }

    }
}
