using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace client_details
{
    public partial class RepositionColumns : Form
    {
        string s = Application.StartupPath;
        public RepositionColumns()
        {
            InitializeComponent();
            fatch();
            fatch2();
        }
        /// <summary>
        /// ///////////////////////////////////////////////first list box display  //////////////////////////////////////////////////////////////////////////////
        /// </summary>
        void fatch()
        {

            DataSet ds = new DataSet();
            ds.ReadXml(s + "\\RepositionColumns.xml");
            if (ds != null && ds.HasChanges())
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    listBox2.Items.Add(ds.Tables[0].Rows[i][0].ToString());

                }



            }



        }
        /// ///////////////////////////////////////////////second list box display  //////////////////////////////////////////////////////////////////////////////
        void fatch2()
        {

            DataSet ds = new DataSet();
            ds.ReadXml(s + "\\visible.xml");
            if (ds != null && ds.HasChanges())
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());

                }



            }



        }
        /// ///////////////////////////////////////////////insert  //////////////////////////////////////////////////////////////////////////////
        void insert()
        {
            string acnum = "";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (Object obj in listBox2.SelectedItems)
            {

                listBox1.Items.Add(obj.ToString());
                // listBox2.Items.Remove(obj.ToString());

            }


            foreach (object o in listBox2.SelectedItems)
                acnum += (acnum == "" ? "" : ", ") + o.ToString();
            listBox2.Items.Remove(acnum);


            XmlDocument MyXmlDocument = new XmlDocument();
            MyXmlDocument.Load(s + "\\visible.xml");
            XmlElement ParentElement = MyXmlDocument.CreateElement("Student");
            XmlElement Symbol = MyXmlDocument.CreateElement("Symbol");
            Symbol.InnerText = acnum;
            ParentElement.AppendChild(Symbol);
            MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            MyXmlDocument.Save(s + "\\visible.xml");
            string path = s + "\\RepositionColumns.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("//StudentDetails/Student[ Symbol='" + acnum + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(s + "\\RepositionColumns.xml");
            // MessageBox.Show("Records added Successfully");


        }


        void remove()
        {

            string acnum = "";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (Object obj in listBox1.SelectedItems)
            {

                listBox2.Items.Add(obj.ToString());


            }


            foreach (object o in listBox1.SelectedItems)
                acnum += (acnum == "" ? "" : ", ") + o.ToString();
            listBox1.Items.Remove(acnum);


            XmlDocument MyXmlDocument = new XmlDocument();
            MyXmlDocument.Load(s + "\\RepositionColumns.xml");
            XmlElement ParentElement = MyXmlDocument.CreateElement("Student");
            XmlElement Symbol = MyXmlDocument.CreateElement("Symbol");
            Symbol.InnerText = acnum;
            ParentElement.AppendChild(Symbol);
            MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            MyXmlDocument.Save(s + "\\RepositionColumns.xml");
            string path = s + "\\visible.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("//StudentDetails/Student[ Symbol='" + acnum + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(s + "\\visible.xml");
            //MessageBox.Show("Records added Successfully");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            remove();
        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{
           
        //}

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
