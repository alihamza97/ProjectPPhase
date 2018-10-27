using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetisMercury.Classes;
namespace MetisMercury.DatabaseClasses
{
    class BoatReservation_DH : DataHelper
    {
        public BoatReservation GetReservation(int EventID, int BoatID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM BOATRESERVATION WHERE EVENTID = " + EventID + " AND BOATID = " + BoatID + "", connection);
            BoatReservation BoatReservation = null;
            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                bool x = r.Read();

                if (r["EVENTID"] == DBNull.Value)
                {
                    EventID = 0; // the participant doesn't have a reservation.
                }
                else
                {
                    EventID = Convert.ToInt32(r["EVENTID"]);
                }

                if (r["BOATID"] == DBNull.Value) // DBNull.Value for (null) values
                {
                    BoatID = 0; // the participant doesn't have a reservation.
                }
                else
                {
                    BoatID = Convert.ToInt32(r["BOATID"]);
                }

                bool CurrentlyCheckedIn;
                if (r["PRESENTLYCHECKEDIN"].ToString() == "YES")
                {
                    CurrentlyCheckedIn = true;
                }
                else
                {
                    CurrentlyCheckedIn = false;
                }

                return BoatReservation = new BoatReservation(EventID,BoatID,CurrentlyCheckedIn); // reservation found.
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }

            return BoatReservation; // no reservation 
        }


        public bool UpdateCheckingStatus(BoatReservation BoatReservation)
        {
            if (BoatReservation.PresentlyChekdin)
            {// participant is already inside the  lake.
                return false;
            }

            MySqlCommand command = new MySqlCommand("UPDATE BOATRESERVATION SET PRESENTLYCHECKEDIN = 'YES' WHERE EVENTID = " + BoatReservation.EventID, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Error Occured.");
            }
            finally
            {
                connection.Close();
            }

            return true;
        }
    }
}
