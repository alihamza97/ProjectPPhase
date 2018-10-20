using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetisMercury.Classes;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace MetisMercury.DatabaseClasses
{
    class Ticket_DataHelper:DataHelper
    {
        public int GetTicket()
        {
            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM TICKET", connection);

            try
            {
                connection.Open();
                MySqlDataReader r = command.ExecuteReader();

                r.Read();

                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch
            {
                return -1;
            }
        }
    }
}
