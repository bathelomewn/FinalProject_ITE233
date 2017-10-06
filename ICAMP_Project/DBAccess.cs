using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICAMP_Project
{
    class DBAccess
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBAccess()
        {
            initConnection();
        }

        public MySqlConnection initConnection()
        {

            server = "localhost";
            database = "icamp";
            uid = "root";
            password = "";

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + ";";

            connection = new MySqlConnection(connectionString);

            return connection;

        }
    }
}
