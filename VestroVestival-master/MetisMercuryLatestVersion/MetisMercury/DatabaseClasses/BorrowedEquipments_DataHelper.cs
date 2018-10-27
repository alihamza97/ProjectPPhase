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
    class BorrowedEquipments_DH:DataHelper
    {
        public List<BorrowedEquipment> GetBorrowedItems(int EventID,string rfid)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM BORROWEDEQUIPMENTS WHERE EVENTID = " + EventID, connection);
            List<BorrowedEquipment> Nrrows = new List<BorrowedEquipment>();

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

               
                    //else
                    //{
                    //    MessageBox.Show("No items found");
                    //}
                    int ItemID = Convert.ToInt32(r["ITEMID"]);
                    int iD = Convert.ToInt32(r["EVENTID"]);

                    Nrrows.Add(new BorrowedEquipment(iD, ItemID));
                
            }
            catch
            {
                MessageBox.Show("Error occurred  getting hired Equipments.");
            }

            return Nrrows;
        }

        public int GetTotalbORROWEDeQUIP()
        {

            string query = "SELECT COUNT(*) AS DATA FROM BORROWEDEQUIPMENTS";
            MySqlCommand command = new MySqlCommand(query, connection);
            int count = -1;
            try
            {
                connection.Open();
                //  MySqlDataReader r = command.ExecuteReader();

                //   r.Read();
                //int EventID = Convert.ToInt16(r["EVENTID"]);
                //int ITEMID = Convert.ToInt16(r["ITEMID"]);

                count = int.Parse(command.ExecuteScalar() + "");
                return count;
            }
            catch
            {
                //    //in case if there is an error
                MessageBox.Show("error in getting present visitor");
                //    return -1;
            }
            finally
            {
                connection.Close();
            }
            return count;
        }

        public BorrowedEquipment GetAITEM(int ID)
        {
            //  String eventnr = Convert.ToString(ID);
            MySqlCommand command = new MySqlCommand("SELECT * FROM BORROWEDEQUIPMENTS WHERE EVENTID=" + ID, connection);
            BorrowedEquipment Borrowedmaterial = null;

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                r.Read();

                int ITEMSID = Convert.ToInt32(r["ITEMID"]);
                int eventid = Convert.ToInt32(r["EVENTID"]);
            //    DateTime borroweddate =Convert.ToDateTime(r["BORROWED_DATE"]);
          //     DateTime ReturnDate = Convert.ToDateTime(r["RETURN_DATE"]);
                // if(DBNull.Value)
                //if (r["RETURN_DATE"] == DBNull.Value)
                //{
                //    ReturnDate = DateTime.Now; // the visitor doesn't have a reservation.
                //}
                //else
                //{
                //    SpotID = Convert.ToInt32(r["CAMPINGSPOTID"]);
                //}
               

               // String b = borroweddate.ToShortDateString();
                //string c = ReturnDate.ToShortDateString();

                return Borrowedmaterial = new BorrowedEquipment(ITEMSID, eventid);
            }
            catch
            {
                MessageBox.Show("Error occurred.");
            }
            finally
            {
                connection.Close();
            }

            return Borrowedmaterial; // no visitor found.
        }
    }
}
