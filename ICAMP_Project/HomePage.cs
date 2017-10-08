using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICAMP_Project
{
    public partial class HomePage : Form
    {

        DBAccess db = new DBAccess();

        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String namestr = sessionName.Text;
            sessionName.Items.Add(namestr);
        }

        private void sessionAdd_Click(object sender, EventArgs e)
        {
            session session = new session();
            session.Show();
            Hide();
        }

        private void RegisterStudent_Click(object sender, EventArgs e)
        {
            CamperRegister register = new CamperRegister();
            register.ShowDialog();
        }

        private void chooseActivity_Click(object sender, EventArgs e)
        {
            CamperSelectActivities select = new CamperSelectActivities();
            select.ShowDialog();
        }

        private void registerActivity_Click(object sender, EventArgs e)
        {
            CamperRegisterActivities registerActivity = new CamperRegisterActivities();
            registerActivity.ShowDialog();
        }
    }
}
