using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ICAMP_Project
{
    public partial class CamperRegister : Form
    {
        public CamperRegister()
        {
            InitializeComponent();
        }
 

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CamperRegister_Load(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;
            password='';database=icamp";

            MySqlConnection conn = null;
            MySqlDataReader reader = null;
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                String cmdText = "SELECT name FROM camper"; // sql command as string
                MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
                reader = cmd.ExecuteReader(); // excute and get into the datareader
                //cmd.ExecuteNonQuery(); Execute with no query
                while (reader.Read())
                {
                    //listBox1.Items.Add(reader.GetString(0)); // get the information as a string at the column index 0
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally // what to do after try/catch is done
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
