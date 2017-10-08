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

        public void sessionRegister(string sessionName, string startdate, string enddate)
        {
            
            string query = "INSERT INTO camp_session(SESSION_NAME, SESSION_START_DATE,SESSION_END_DATE) VALUES('" + sessionName + "', '"+ startdate + "', '" + enddate + "')";

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void camperRegister(string name, string startdate, string enddate, string bunk, string nationality, string nickname, string age, string restriction, string medication, string transportation, string p1name, string p1email, string p1phone, string p2name,  string p2email, string p2phone)
        {                                                                                                                                                                                                                                                                         
            string query = "INSERT INTO camp_student(NAME, START_DATE,END_DATE, STUDENT_BUNK, NATIONALITY, PREFERED_NAME, AGE, RESTRICTION, MEDICATIONS, TRANSPORTATION, PARENT1_NAME, PARENT1_EMAIL, PARENT1_PHONE, PARENT2_NAME, PARENT2_EMAIL, PARENT2_PHONE) VALUES('" + name + "', '" + startdate + "', '" + enddate + "', '" + bunk + "', '" + nationality + "', '" + nickname + "', '" + age + "', '" + restriction + "', '" + medication + "', '" + transportation + "', '" + p1name + "', '" + p1email + "', '" + p1phone + "', '" + p2name + "', '" + p2email + "', '" + p2phone + "')";

            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }


    }
}
