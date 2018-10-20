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
    class CampingReservation_DataHelper:DataHelper
    {
        public CampingReservation GetReservation(int EventID, int SpotID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM CAMPINGRESERVATION WHERE EVENTID = " + EventID + " AND CAMPINGSPOTID = " + SpotID + "", connection);
            CampingReservation CampingReservation = null;
            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                bool x = r.Read();

                if (r["EVENTID"] == DBNull.Value)
                {
                    EventID = 0; // the visitor doesn't have a reservation.
                }
                else
                {
                    EventID = Convert.ToInt32(r["EVENTID"]);
                }

                if (r["SPOTID"] == DBNull.Value) 
                {
                    SpotID = 0; // the visitor doesn't have a reservation.
                }
                else
                {
                    SpotID = Convert.ToInt32(r["CAMPINGSPOTID"]);
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

                return CampingReservation = new CampingReservation(EventID, SpotID, CurrentlyCheckedIn); // reservation found.
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }

            return CampingReservation; // no reservation 
        }

        
        public bool UpdateCheckingStatus(CampingReservation CampingReservation)
        {
            if (CampingReservation.PresentlyChekedIn)
            {// visitor is already inside the camping ground.
                return false;
            }

            MySqlCommand command = new MySqlCommand("UPDATE CAMPINGRESERVATION SET PRESENTLYCHECKEDIN = 'YES' WHERE EVENTID = " + CampingReservation.EventID, connection);

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
