using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace MetisMercury.DatabaseClasses
{
    class DataHelper
    {
        protected MySqlConnection connection;
        private string ConnString;

        public DataHelper()
        {
            ConnString = "server=localhost;" +//local server
                                    "database=prop;" +
                                    "user id=root;" +
                                    "password=   UHEMWdFBZSdrsAPA;" +
                                    "connect timeout=30;";
            //ConnString = "server=studmysql01.fhict.local;" +//local server
            //                        "database=dbi314865;" +
            //                        "user id=dbi314865;" +
            //                        "password=BogdanAndJeroen;" +
            //                        "connect timeout=30;";
            connection = new MySqlConnection(ConnString);
        }
    }
}
