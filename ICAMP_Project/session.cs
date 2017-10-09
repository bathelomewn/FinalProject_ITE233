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
    public partial class session : Form
    {

        public session()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("../../session.xml");
			//create new element
			XElement newTag = new XElement("item",
				new XElement("name", sessionName.Text),
				new XElement("startdate", startDate.Value.ToString("yyyy-MM-dd")),
				new XElement("enddate", endDate.Value.ToString("yyyy-MM-dd"))
				);

			//add element to the document under type one element
			xdoc.Element("Type1").Add(newTag);
			//save doc
			xdoc.Save("../../session.xml");
            //reload the form
            session_Load(sender, e);
        }

        private void session_Load(object sender, EventArgs e)
        {
            //Load document
            XDocument xdoc = XDocument.Load("../../session.xml");
        }
    }
}
