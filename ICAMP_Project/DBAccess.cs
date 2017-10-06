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

        //adding new student
        public void InsertStudent(string name, string start_date, string leave_date, string student_bunk, string nationality, string prefered_name, int age, string restriction, string medication, string transportation, string p1name, string p1email, string p1phone, string p2name, string p2email, string p2phone)
        {
            string query = "INSERT INTO camp_student(Name, START_DATE,LEAVE_DATE,STUDENT_BUNK,NATIONALITY,PREFERED_NAME,AGE,RESTRICTION,MEDICATIONS,TRANSPORTATION, PARENT1_NAME,PARENT1_EMAIL,PARENT1_PHONE, PARENT2_NAME,PARENT2_EMAIL,PARENT2_PHONE) VALUES('" + name + "','" + start_date + "', '" + leave_date + "', '" + student_bunk + "', '" + nationality + "', '" + prefered_name + "', '" + age + "', '" + restriction + "', '" + medication + "', '" + transportation + "', '" + p1name + "', '" + p1email + "', '" + p1phone + "', '" + p2name + "', '" + p2email + "', '" + p2phone + "')";

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
