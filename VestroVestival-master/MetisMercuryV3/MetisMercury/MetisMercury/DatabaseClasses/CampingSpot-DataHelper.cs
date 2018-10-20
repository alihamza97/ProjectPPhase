using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MetisMercury.Classes;
using MetisMercury.DatabaseClasses;

namespace MetisMercury.DatabaseClasses
{
    class CampingSpot_DH:DataHelper
    {
        //Booked Spots

        public int BookedSpot()
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM CAMPINGSPOT WHERE ISAVAILABLE= 'NO'", connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                reader.Read();

                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch
            {
                // error occured 
                return -1;
            }
        }
        public int[] VistorDetails()
        {
            string Query = ("SELECT VISITOR.EVENTID, visitor.spotid, CAMPINGSPOT.HASPAID, VISITOR.ISCHECKEDIN " +
                         "FROM CAMPINGSPOT JOIN VISITOR ON " +
                         "(CAMPINGSPOT.HASPAID = VISITOR.EVENTID) " +
                         "WHERE VISITOR.EVENTID ="); // NEVER USE ';' !

            MySqlCommand command = new MySqlCommand(Query, connection);
            int[] columns = new int[4];

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int EventID;
                int CampingSpotID;
                int paid;
                int CheckedIn;

                while (reader.Read())
                {
                    EventID = Convert.ToInt32(reader["EVENTID"]);
                    CampingSpotID = Convert.ToInt32(reader["SPOTID"]);
                    paid = Convert.ToInt32(reader["HASPAID"]);

                    if (reader["ISCHECKEDIN"].ToString() == "N")
                        columns[3] = CheckedIn = 0;
                    else
                        columns[3] = CheckedIn = 1;

                    columns[0] = EventID;
                    columns[1] = CampingSpotID;
                    columns[2] = paid;
                    columns[3] = CheckedIn;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while loading.");
            }
            finally
            {
                connection.Close();
            }

            return columns;
        }
        public CampingSpot GetASpot(int ID)
        {
            //  String eventnr = Convert.ToString(ID);
            MySqlCommand command = new MySqlCommand("SELECT * FROM CAMPINGSPOT WHERE CAMPINGSPOTID=" + ID, connection);
            CampingSpot CampingSpot = null;

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                r.Read();

                int CampingSpotID = Convert.ToInt32(r["CAMPINGSPOTID"]);
              //  string rfid = r["RFID"].ToString();

                int NumberofParticipants =Convert.ToInt32 (r["NUMBEROFPARTICIPANTS"]);
                decimal Price =Convert.ToDecimal(r["PRICE"]);
           //     string email = r["EMAIL"].ToString();

                bool isavailabel;

                if (r["ISAVAILABLE"].ToString() == "NO")
                {
                    isavailabel = false;
                }
                else
                {// YES
                    isavailabel = true;
                }

                bool HASPAID;
                if (r["HASPAID"].ToString() == "NO")
                {
                    HASPAID = false;
                }
                else
                {// YES
                    HASPAID = true;
                }

             


                return CampingSpot = new CampingSpot(CampingSpotID,isavailabel,NumberofParticipants,Price,HASPAID);
            }
            catch
            {
                MessageBox.Show("Error occurred.");
            }
            finally
            {
                connection.Close();
            }

            return CampingSpot; // no visitor found.
        }

    }
}
