using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ICAMP_Project
{
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
        }

        private void sessionAdd_Click(object sender, EventArgs e)
        {
            session newSession = new session();
            newSession.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        
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
