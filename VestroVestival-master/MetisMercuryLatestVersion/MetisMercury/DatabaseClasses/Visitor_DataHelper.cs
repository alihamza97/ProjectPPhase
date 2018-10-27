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
    class Visitor_DataHelper:DataHelper
    {
        
        public void CheckOut(string RFID)
        {
            MySqlCommand command = new MySqlCommand("UPDATE VISITOR SET RFID=NULL WHERE RFID = '" + RFID + "'", connection);

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                r.Read();
                command.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Do not scan twice");
                     // MessageBox.Show("error occurred while checkingout.");
            }
            finally
            {
                connection.Close();
            }
        }

        public int getabsentvisitor()
        {

            string query = "SELECT COUNT(*) AS DATA FROM VISITOR WHERE RFID IS NULL";
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
                //    return count;


            }
            return count;
        }
        public int GetPresentParticipants()
        {

            string query = "SELECT COUNT(*) AS DATA FROM VISITOR";
           MySqlCommand command = new MySqlCommand(query, connection);
            int count = -1;
            try
            {
            connection.Open();
             //  MySqlDataReader r = command.ExecuteReader();

            //   r.Read();
                //int EventID = Convert.ToInt16(r["EVENTID"]);
                //int ITEMID = Convert.ToInt16(r["ITEMID"]);

                 count= int.Parse(command.ExecuteScalar()+"");
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


        public int CalculateTotalBalance()
        {

            string query = "SELECT SUM(PRESENTBALANCE) AS DATA FROM VISITOR";
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



        public Visitor GetVisitor(string RFID)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM VISITOR WHERE RFID='" + RFID + "'", connection);
            Visitor Visitor = null;

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                r.Read();

                int EventID = Convert.ToInt16(r["EVENTID"]);
                decimal PresentBalance = Convert.ToDecimal(r["PRESENTBALANCE"]);
                string lName = r["LNAME"].ToString();
                string fName = r["FNAME"].ToString();
                string email = r["EMAIL"].ToString();

                bool hasCheckedIn;
                if (r["HASCHECKEDIN"].ToString() == "NO")
                {
                    hasCheckedIn = false;
                }
                else
                {// YES
                    hasCheckedIn = true;
                }

                bool statusOfPayment;
                if (r["STATUSOFPAYMENT"].ToString() == "NO")
                {
                    statusOfPayment = false;
                }
                else
                {// YES
                    statusOfPayment = true;
                }
                string rfid = r["RFID"].ToString();

              

                

                return Visitor = new Visitor(EventID,PresentBalance, fName, lName, email, hasCheckedIn, statusOfPayment, rfid);
            }

            catch (Exception)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }

        }

        /// <summary>
        /// Retrieves details about a participant under a given Event ID.
        /// </summary>
        /// <param name="ID">Given account ID.</param>
        /// <returns>Participant</returns>
        public Visitor GetAVisitor(int ID)
        {
          //  String eventnr = Convert.ToString(ID);
            MySqlCommand command = new MySqlCommand("SELECT * FROM VISITOR WHERE EVENTID=" + ID, connection );
            Visitor Visitor = null;

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                r.Read();

                int eventid = Convert.ToInt32(r["EVENTID"]);
                string rfid = r["RFID"].ToString();

                string lName = r["LNAME"].ToString();
                string fName = r["FNAME"].ToString();
                string email = r["EMAIL"].ToString();

                //bool isCheckedIn;

                //if (r["ISCHECKEDIN"].ToString() == "NO")
                //{
                //    isCheckedIn = false;
                //}
                //else
                //{// YES
                //    isCheckedIn = true;
                //}

                bool hasCheckedIn;
                if (r["HASCHECKEDIN"].ToString() == "NO")
                {
                    hasCheckedIn = false;
                }
                else
                {// YES
                    hasCheckedIn = true;
                }

                bool statusOfPayment;

                if (r["STATUSOFPAYMENT"].ToString() == "NO")
                {
                    statusOfPayment = false;
                }
                else
                {// YES
                    statusOfPayment = true;
                }

                decimal currentBalance = Convert.ToDecimal(r["PRESENTBALANCE"]);

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


                return Visitor = new Visitor(eventid, currentBalance, fName, lName, email, hasCheckedIn, statusOfPayment,rfid);
            }
            catch
            {
                MessageBox.Show("Error occurred.");
            }
            finally
            {
                connection.Close();
            }

            return Visitor; // no visitor found.
        }

       
        /// get all visitor details from the database.
      
       
        public List<Visitor> GetAllVisitors()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM VISITOR WHERE RFID=", connection);

            List<Visitor> Nrrows = new List<Visitor>();

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                while (r.Read())
                {
                    int EventID = Convert.ToInt16(r["EVENTID"]);
                    string RFID = r["RFID"].ToString();

                    string lName = r["LNAME"].ToString();
                    string fName = r["FNAME"].ToString();
                    string email = r["EMAIL"].ToString();

                    bool isCheckedIn;
                    if (r["ISCHECKEDIN"].ToString() == "NO")
                    {
                        isCheckedIn = false;
                    }
                    else
                    {
                        isCheckedIn = true;
                    }

                    bool hasCheckedIn;
                    if (r["HASCHECKEDIN"].ToString() == "NO")
                    {
                        hasCheckedIn = false;
                    }
                    else
                    {
                        hasCheckedIn = true;
                    }

                    bool StatusOfPayment;

                    if (r["STATUSOFPAYMENT"].ToString() == "NO")
                    {
                        StatusOfPayment = false;
                    }
                    else
                    {
                        StatusOfPayment = true;
                    }

                    decimal PresentBalance = Convert.ToDecimal(r["PRESENTBALANCE"]);

                    //int spotID;
                    //if (r["SPOTID"] == DBNull.Value) 
                    //{
                    //    spotID = 0; // The VISITOR doesn't have a camping spot.
                    //}
                    //else
                    //{
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


                    Nrrows.Add(new Visitor(EventID, PresentBalance, fName, lName, email, isCheckedIn, StatusOfPayment, RFID));
                }
            }
            catch
            {
                MessageBox.Show("Error occur while getting all participant");
            }
            finally
            {
                connection.Close();
            }

            return Nrrows;
        }

        /// <summary>
        /// Assigns the RFID tag number to the participant and updates their check-in status.
       
        /// <returns>Check-in status</returns>
        public bool UpdateRFIDStatus(int id,string TagNr)
        {
            //if (visitor.IsChekedin)
            //{// visitor is already inside the event.
            //    return false;
            //}

            MySqlCommand command = new MySqlCommand("UPDATE VISITOR SET RFID = '" + TagNr + "' WHERE EVENTID = " + id, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error updating status of RFID.");
            }
            finally
            {
                connection.Close();
            }

            return true;
        }

        public int AssignTicket(int id, decimal balance, string fname,string lname,string ticketType)
        {   //Probably you expected a return-value of type bool:
            //true if the query was executed succesfully and false otherwise.
            //But what if you executed a delete-query? Or an update-query?
            //The return-value is teh number of records affected.
            //string Query = string.Format("INSERT INTO BUYTICKET(EVENTID,PRESENTBALANCE,FNAME,LNAME,TICKETTYPE)" +
            //     "VALUES({0}, {1}, {2}, {3}, {4})", id, balance, fname,lname,ticketType);
            String Query = "INSERT INTO BUYTICKETS VALUES (" +
                "'" + id + "'," + balance + "," + fname + "," + lname + "," + ticketType + ")";

            MySqlCommand command = new MySqlCommand(Query, connection);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch
            {
                
              MessageBox.Show("Error");
                return -1; //which means the try-block was not executed succesfully, so  . . .
            }
            finally
            {
                connection.Close();
            }
        }



    }
}
