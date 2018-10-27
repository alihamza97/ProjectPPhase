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

                    rows.Add(new Cafeteria(itemNr, price, name,quantity));
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
        public bool UpdateProduct(int id,decimal price, string productName)
        {
            //if (visitor.IsChekedin)
            //{// visitor is already inside the event.
            //    return false;
            //}

            MySqlCommand command = new MySqlCommand("UPDATE CAFETERIA SET NAME= '" + productName + "', PRICE="+price+" WHERE ITEMNR = " + id, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error updating status of cafeteria.");
            }
            finally
            {
                connection.Close();
            }

            return true;
        }
        public Cafeteria GetItemID(int ID)
        {
            //  String eventnr = Convert.ToString(ID);
            MySqlCommand command = new MySqlCommand("SELECT * FROM CAFETERIA WHERE ITEMNR=" + ID, connection);
            //    Visitor Visitor = null;
            Cafeteria cafe = null;

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                r.Read();

                int ITEMNR = Convert.ToInt32(r["ITEMNR"]);
                decimal price = Convert.ToDecimal(r["PRICE"]);

                string Name = r["NAME"].ToString();

                int quantity = Convert.ToInt16(r["QUANTITY"]);

                //bool isCheckedIn;

                //if (r["ISCHECKEDIN"].ToString() == "NO")
                //{
                //    isCheckedIn = false;
                //}
                //else
                //{// YES
                //    isCheckedIn = true;
                //}

                
                //int spotID;
                //if (r["SPOTID"] == DBNull.Value) 
                //{// in case there is no camping spot
                //    spotID = 0;
                //}
                //else
                //{// The participant/co-camper has a camping spot.
                //    spotID = Convert.ToInt32(r["SPOTID"]);
                //}
                //int boatid;
                //if (r["boatid"] == DBNull.Value)
                //{
                //    boatid = 0;
                //}
                //else
                //{
                //    boatid = Convert.ToInt32(r["boatid"]);
                //}


                return cafe = new Cafeteria(ITEMNR,price,Name,quantity);
            }
            catch
            {
                MessageBox.Show("Error occurred.");
            }
            finally
            {
                connection.Close();
            }

            return cafe; // no visitor found.
        }
    }
}
