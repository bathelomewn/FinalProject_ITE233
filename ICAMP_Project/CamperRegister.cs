using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ICAMP_Project
{
    public partial class CamperRegister : Form
    {

        DBAccess db = new DBAccess();
        public CamperRegister()
        {
            InitializeComponent();
        }
 

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CamperRegister_Load(object sender, EventArgs e)
        {
           
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            db.camperRegister(camperName.Text, dtpAdmission.Value.ToString("yyyy/M/d"), dtp2Admission.Value.ToString("yyyy/M/d"), camperBunk.Text, camperNation.Text, nickName.Text, camperAge.Text, camperRestriction.Text,camperMedications.Text,camperTransportation.Text, guard1Name.Text,guard1Email.Text,guard1Phone.Text,guard2Name.Text,guard2Email.Text,guard2Phone.Text);

        }
    }
}
