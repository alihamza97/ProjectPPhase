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
        public List<EquipmentsShop> GetEquipments()
        {
            string Query = "SELECT * FROM EQUIPMENTSSHOP";
            MySqlCommand command = new MySqlCommand(Query, connection);

            List<EquipmentsShop> items = new List<EquipmentsShop>();

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

                    items.Add(new EquipmentsShop(ItemID, name, price));
                }
            }
            catch 
            {
                 MessageBox.Show(""); // Error.
            }
            finally
            {
                connection.Close();
            }

            return items;
        }

        public int GetVistorFromDataBase(int id, string RFIDNr)
        {
            string SQL = "select EVENTID from visitor where rfid= '" + RFIDNr + "'";

            MySqlCommand command = new MySqlCommand(SQL, connection);

            // int  ID = 0; //balance
            try
            {
                connection.Open();
                id = Convert.ToInt32(command.ExecuteScalar());


            }
            catch (Exception)
            {
                MessageBox.Show("Error occured");
            }
            finally
            {
                connection.Close();
            }
            return id;
        }

        public decimal GettTotalBalance(string RFIDNr)
        {
            string SQL = "SELECT PRESENTBALANCE FROM VISITOR WHERE RFID= '" + RFIDNr + "'";

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
        public bool UpdateItem(int id, decimal price, string productName)
        {
            //if (visitor.IsChekedin)
            //{// visitor is already inside the event.
            //    return false;
            //}

            MySqlCommand command = new MySqlCommand("UPDATE EQUIPMENTSSHOP SET NAME= '" + productName + "', PRICE=" + price + " WHERE ITEMID = " + id, connection);

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

        public EquipmentsShop GetItemID(int ID)
        {
            //  String eventnr = Convert.ToString(ID);
            MySqlCommand command = new MySqlCommand("SELECT * FROM EQUIPMENTSSHOP WHERE ITEMID=" + ID, connection);
            //    Visitor Visitor = null;
            EquipmentsShop SHOP = null;

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                r.Read();

                int ITEMNR = Convert.ToInt32(r["ITEMID"]);
                decimal price = Convert.ToDecimal(r["PRICE"]);

                string Name = r["NAME"].ToString();

              //  int quantity = Convert.ToInt16(r["QUANTITY"]);

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


                return SHOP = new EquipmentsShop(ITEMNR, Name,price);
            }
            catch
            {
                MessageBox.Show("Error occurred.");
            }
            finally
            {
                connection.Close();
            }

            return SHOP; // no visitor found.
        }

        public bool ReturnProduct(int ItemID,int idnr, DateTime ReturnDate)
        {
            string Query = "select EVENTID from BORROWEDEQUIPMENTS";
          //  int idnr = 0;
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
            Query = "UPDATE BORROWEDEQUIPMENTS SET RETURN_DATE = " + b + " WHERE EVENTID = " + idnr + " AND ITEMID = " + ItemID;
      
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

        public bool BorrowProduct(int ItemID,int idnr,  string RFID)
        {
           
            string Query = "select EVENTID from visitor where rfid = '" + RFID + "'";





          //  int id = 1;

           // idNr++;

            MySqlCommand command = new MySqlCommand(Query, connection);
            try
            {
                connection.Open();
               
              
                idnr = Convert.ToInt32(command.ExecuteScalar());
            }
            catch
            {
                MessageBox.Show("error occurred while getting ID of customer");
            }
            finally
            {
                connection.Close();
            }

       //     string b = BorrowDate.ToShortDateString();
            Query = "insert into BORROWEDEQUIPMENTS(ITEMID,EVENTID) VALUES(" + ItemID+"," + idnr + ")";
          
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

        public bool ReturnItem(int RFID)
        {
            //if (visitor.IsChekedin)
            //{// visitor is already inside the event.
            //    return false;
            //}
          //  string b = RETURNDATE.ToShortDateString();
            MySqlCommand command = new MySqlCommand("DELETE FROM BORROWEDEQUIPMENTS WHERE EVENTID =" + RFID, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error .");
            }
            finally
            {
                connection.Close();
            }

            return true;
        }

    }
}
