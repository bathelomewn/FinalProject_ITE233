using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Linq;

namespace ICAMP_Project
{
    public partial class CamperRegister : Form
    {

   
        public CamperRegister()
        {
            InitializeComponent();
        }

        //save
        private void registerBtn_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("../../camper.xml");
            //create new element
            XElement newTag = new XElement("item",
                new XElement("name", name.Text),
                new XElement("nickname", nickname.Text),
                new XElement("bunk", bunk.Text),
                new XElement("age", age.Text),
                new XElement("nationality", nationality.Text),
                new XElement("restriction", restriction.Text),
                new XElement("medications", medication.Text),
                new XElement("transportation", transpotation.Text),
                new XElement("startdate", StartDate.Value.ToString("yyyy-MM-dd")),
                new XElement("enddate", EndDate.Value.ToString("yyyy-MM-dd")),
                new XElement("nameParent1", nameparent1.Text),
                new XElement("phoneParent1", phoneparent1.Text),
                new XElement("emailParent1", emailparent1.Text),
                new XElement("nameParent2", nameparent2.Text),
                new XElement("phoneParent2", phoneparent2.Text),
                new XElement("emailParent2", emailparent2.Text)
                );
            //add element to the document under type one element
            xdoc.Element("Type1").Add(newTag);
            //save doc
            xdoc.Save("../../camper.xml");
            //reload the form
            CamperRegister_Load(sender, e);
        }


        //load
        private void CamperRegister_Load(object sender, EventArgs e)
        {
            //Load document
            XDocument xdoc = XDocument.Load("../../camper.xml");
            // read items
            var xdocRead = xdoc.Elements("Type1").Elements("item");
            //clear textbox
            selectCamper.Items.Clear();
            //load to combobox for all element name
            foreach (var n in xdocRead)
            {
                selectCamper.Items.Add(n.Element("name").Value.ToString());
            }
            //for bunk selection
            XDocument xdoc2 = XDocument.Load("../../bunks.xml");
            var xdocRead2 = xdoc2.Elements("Type1").Elements("bunk");
            foreach (var n in xdocRead2)
            {
                bunk.Items.Add(n.Value);
            }
            if (bunk.Items.Count > 0)
            {
                bunk.SelectedIndex = 0;
            }
        }


        //select camper
        private void selectCamper_SelectedIndexChanged(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("../../camper.xml");
            var xdocRead = xdoc.Elements("Type1").Elements("item");
            //read for item where element name is same with selectCamper
            var item = xdocRead.Where(a => a.Element("name").Value == selectCamper.Text).Single();
            //get camper info
            name.Text = item.Element("name").Value;
            nickname.Text = item.Element("nickname").Value;
            bunk.Text = item.Element("bunk").Value;
            age.Text = item.Element("age").Value;
            nationality.Text = item.Element("nationality").Value;
            restriction.Text = item.Element("restriction").Value;
            medication.Text = item.Element("medications").Value;
            transpotation.Text = item.Element("transportation").Value;
            StartDate.Text = item.Element("startdate").Value;
            EndDate.Text = item.Element("enddate").Value;
            nameparent1.Text = item.Element("nameParent1").Value;
            phoneparent1.Text = item.Element("phoneParent1").Value;
            emailparent1.Text = item.Element("emailParent1").Value;
            nameparent2.Text = item.Element("nameParent2").Value;
            phoneparent2.Text = item.Element("phoneParent2").Value;
            emailparent2.Text = item.Element("emailParent2").Value;
        }


        //delete
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("../../camper.xml");
            var xdocRead = xdoc.Elements("Type1").Elements("item");
            //delete the element where name is same with selectCamper
            xdocRead.Where(a => a.Element("name").Value == selectCamper.Text).Single().Remove();
            //save doc
            xdoc.Save("../../camper.xml");
            //reload form
            CamperRegister_Load(sender, e);
        }


        //update
        private void updateBtn_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load("../../camper.xml");
            var xdocRead = xdoc.Elements("Type1").Elements("item");
            var item = xdocRead.Where(a => a.Element("name").Value == selectCamper.Text).Single();
            // change camper info
            //item.Element("name").Value = name.Text; // cannot edit name
            item.Element("nickname").Value = nickname.Text;
            item.Element("bunk").Value = bunk.Text;
            item.Element("age").Value = age.Text;
            item.Element("nationality").Value = nationality.Text;
            item.Element("restriction").Value = restriction.Text;
            item.Element("medications").Value = medication.Text;
            item.Element("transportation").Value = transpotation.Text;
            item.Element("startdate").Value = StartDate.Value.ToString("yyyy-MM-dd");
            item.Element("enddate").Value = EndDate.Value.ToString("yyyy-MM-dd");
            item.Element("nameParent1").Value = nameparent1.Text;
            item.Element("phoneParent1").Value = phoneparent1.Text;
            item.Element("emailParent1").Value = emailparent1.Text;
            item.Element("nameParent2").Value = nameparent2.Text;
            item.Element("phoneParent2").Value = phoneparent2.Text;
            item.Element("emailParent2").Value = emailparent2.Text;
            //save doc that was changed
            xdoc.Save("../../camper.xml");
        }
    }
}
