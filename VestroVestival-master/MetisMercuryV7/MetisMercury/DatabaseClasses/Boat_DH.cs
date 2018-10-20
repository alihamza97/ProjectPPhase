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
    class Boat_DH:DataHelper
    {
        public int GetBookedBoat()
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM BOAT WHERE ISAVAILABLE= 'NO'", connection);

            try
            {
                connection.Open();
                MySqlDataReader R = command.ExecuteReader();

                R.Read();

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
            string Query = "SELECT VISITOR.EVENTID, BOAT.BOATID, BOAT.HASPAID, VISITOR.ISCHECKEDIN " +
                         "FROM BOAT JOIN VISITOR ON " +
                         "(BOAT.HASPAID = VISITOR.EVENTID) " +
                         "WHERE VISITOR.EVENTID = 3"; // NEVER USE ';' !
            
            MySqlCommand command = new MySqlCommand(Query, connection);
            int[] columns = new int[4];

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                int EventID;
                int BoatID;
                int paid;
                int CheckedIn;
                DateTime day;

                while (reader.Read())
                {
                    EventID = Convert.ToInt32(reader["EVENTID"]);
                    BoatID = Convert.ToInt32(reader["BOATID"]);
                    paid = Convert.ToInt32(reader["HASPAID"]);
                    day = Convert.ToDateTime(reader["DAY"]);

                    if (reader["ISCHECKEDIN"].ToString() == "N")
                        columns[3] = CheckedIn = 0;
                    else
                        columns[3] = CheckedIn = 1;

                    columns[0] = EventID;
                    columns[1] = BoatID;
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

        public Boat GetABoat(int ID)
        {
            //  String eventnr = Convert.ToString(ID);
            MySqlCommand command = new MySqlCommand("SELECT * FROM BOAT WHERE BOATID=" + ID, connection);
            Boat boat = null;

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                r.Read();

                int boatID = Convert.ToInt32(r["BOATID"]);
                //  string rfid = r["RFID"].ToString();

                int NumberofParticipants = Convert.ToInt32(r["NROFPARTICIPANTS"]);
                decimal Price = Convert.ToDecimal(r["PRICE"]);
              DateTime  day = Convert.ToDateTime(r["DAY"]);
                DateTime start = Convert.ToDateTime(r["STARTTIME"]);
                DateTime end = Convert.ToDateTime(r["ENDTIME"]);
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



                string b = day.ToShortDateString();
                string C = start.ToShortTimeString();
                string D = end.ToShortTimeString();
               


                return boat = new Boat(boatID, NumberofParticipants, isavailabel,day, start, end, Price, HASPAID);
            }
            catch
            {
                MessageBox.Show("Error occurred.");
            }
            finally
            {
                connection.Close();
            }

            return boat; // no visitor found.
        }
    }
}
