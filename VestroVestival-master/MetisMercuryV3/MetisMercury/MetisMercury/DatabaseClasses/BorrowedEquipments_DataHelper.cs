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
        public List<BorrowedEquipment> GetBorrowedItems(int EventID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM BORROWEDEQUIPMENTS WHERE EVENTID = " + EventID, connection);
            List<BorrowedEquipment> Nrrows = new List<BorrowedEquipment>();

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                while (r.Read())
                {
                    String BorrowDate = r["BORROWED_DATE"].ToString();

                    string returnDate;
                    if (r["RETURN_DATE"] != DBNull.Value)
                    {
                        returnDate = r["RETURN_DATE"].ToString();
                    }
                    else
                    {
                        returnDate = "No items found.";
                    }
                    int ItemID = Convert.ToInt32(r["EQUIPMENTID"]);
                    int iD = Convert.ToInt32(r["EVENTID"]);

                    Nrrows.Add(new BorrowedEquipment(iD, ItemID, BorrowDate, returnDate));
                }
            }
            catch
            {
                MessageBox.Show("Error occurred  getting hired Equipments.");
            }

            return Nrrows;
        }
    }
}
