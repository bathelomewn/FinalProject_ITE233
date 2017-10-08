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
    public partial class session : Form
    {
        DBAccess db = new DBAccess();

        public session()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            db.sessionRegister(sessionName.Text, startDate.Value.ToString("yyyy/M/d"), endDate.Value.ToString("yyyy/M/d"));
        }
    }
}
