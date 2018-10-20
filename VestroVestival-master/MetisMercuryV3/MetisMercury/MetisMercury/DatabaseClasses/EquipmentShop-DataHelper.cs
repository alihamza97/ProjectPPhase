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
    class EquipmentShop_DH:DataHelper
    {
        public List<EquipmentShop> GetEquipments()
        {
            string Query = "SELECT * FROM EQUIPMENTSSHOP";
            MySqlCommand command = new MySqlCommand(Query, connection);

            List<EquipmentShop> items = new List<EquipmentShop>();

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                int ItemID;
                decimal price;
                string name;

                while (r.Read())
                {
                   ItemID = Convert.ToInt32(r["ITEMID"]);
                    price = Convert.ToDecimal(r["PRICE"]);
                    name = r["NAME"].ToString();

                    items.Add(new EquipmentShop(ItemID, name, price));
                }
            }
            catch (Exception)
            {
                // Error.
            }
            finally
            {
                connection.Close();
            }

            return items;
        }

        public decimal GettTotalBalance(string RFIDNr)
        {
            string SQL = "select presentbalance from visitor where rfid= '" + RFIDNr + "'";

            MySqlCommand command = new MySqlCommand(SQL, connection);

            decimal balnc = 0; //balance
            try
            {
                connection.Open();
                balnc = Convert.ToDecimal(command.ExecuteScalar());
                

            }
            catch (Exception )
            {
                MessageBox.Show("Error occured");
            }
            finally
            {
                connection.Close();
            }
            return balnc;
        }

        public bool ReturnProduct(int ItemID, DateTime ReturnDate, string RFID)
        {
            string Query = "select EVENTID from VISITOR where rfid = '" + RFID + "'";
            int idnr = 0;
            MySqlCommand command = new MySqlCommand(Query, connection);
            try
            {
                connection.Open();
                idnr = Convert.ToInt32(command.ExecuteScalar());
            }
            catch
            {
               MessageBox.Show("error occured while getting IDNr of Visitor");
            }
            finally
            {
                connection.Close();
            }

            string b = ReturnDate.ToShortDateString();
            Query = "UPDATE EQUIPMENTSSHOP SET RETURN_DATE = " + b + " WHERE EVENTID = " + idnr + " AND ITEMID = " + ItemID;
      
            command = new MySqlCommand(Query, connection);
            try
            {
                connection.Open();
                int NumberOfChanges = command.ExecuteNonQuery();
                if (NumberOfChanges == 0)
                { return false; }
                else
                    return true;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;

        }
       //public int CheckForId(Visitor visitor)
       // {
       //     return visitor.EventID;
       // }

        public bool BorrowProduct(int ItemID, DateTime BorrowDate, string RFID)
        {
           
            string Query = "select EVENTID from visitor where rfid = '" + RFID + "'";

        

            int idNr=0;



           // idNr++;

            MySqlCommand command = new MySqlCommand(Query, connection);
            try
            {
                connection.Open();
               
              
                idNr = Convert.ToInt32(command.ExecuteScalar());
            }
            catch
            {
                MessageBox.Show("error occurred while getting ID of customer");
            }
            finally
            {
                connection.Close();
            }

            string b = BorrowDate.ToShortDateString();
            Query = "insert into BORROWEDEQUIPMENTS(BORROWED_DATE, ITEMID, EVENTID) VALUES(" + b + "," + ItemID + ", " + idNr + ")";
          
            command = new MySqlCommand(Query, connection);
            try
            {
                connection.Open();
                int NumberChanges = command.ExecuteNonQuery();
                if (NumberChanges == 0)
                { return false; }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

    }
}
