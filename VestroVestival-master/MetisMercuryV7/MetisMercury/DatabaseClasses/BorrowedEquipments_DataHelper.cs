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

                while (r.Read())
                {
                    DateTime BorrowDate =Convert.ToDateTime( r["BORROWED_DATE"]);

                    DateTime returnDate=Convert.ToDateTime(r["RETURN_DATE"]);

                    if (r["RETURN_DATE"] == DBNull.Value)
                    {

                        //  string c = returnDate.ToShortDateString();
                        MessageBox.Show("no items found");

                    }
                    //else
                    //{
                    //    MessageBox.Show("No items found");
                    //}
                    int ItemID = Convert.ToInt32(r["ITEMID"]);
                    int iD = Convert.ToInt32(r["EVENTID"]);
                    string b = BorrowDate.ToShortDateString();
                   string c=returnDate.ToShortDateString();
                    Nrrows.Add(new BorrowedEquipment(iD, ItemID, BorrowDate));
                }
            }
            catch
            {
                MessageBox.Show("Error occurred  getting hired Equipments.");
            }

            return Nrrows;
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
                DateTime borroweddate =Convert.ToDateTime(r["BORROWED_DATE"]);
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
               

                String b = borroweddate.ToShortDateString();
                //string c = ReturnDate.ToShortDateString();

                return Borrowedmaterial = new BorrowedEquipment(ITEMSID, eventid, borroweddate);
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
