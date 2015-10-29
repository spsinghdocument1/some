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
    public partial class User_Input : Form
    {
        public User_Input()
        {
            InitializeComponent();
            display();
            //displayToken();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (textBox_user_Input.Text == "")
            {
                MessageBox.Show("PLZ Insert USER NAME ");
                return;
            
            }
            if (comboBox_Type.Text == "Select")
            {
                MessageBox.Show("PLZ Select Type ");
                return;

            }

            insert();
            display();
        }
        void insert()
        {

            XmlDocument MyXmlDocument = new XmlDocument();
            MyXmlDocument.Load(Application.StartupPath + "\\UserInput.xml");
            XmlElement ParentElement = MyXmlDocument.CreateElement("user");
            XmlElement user_name = MyXmlDocument.CreateElement("user_name");
            user_name.InnerText = textBox_user_Input.Text;
            XmlElement type = MyXmlDocument.CreateElement("type");
            type.InnerText = comboBox_Type.Text;
           

            ParentElement.AppendChild(user_name);
            ParentElement.AppendChild(type);

            
            MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            MyXmlDocument.Save(Application.StartupPath + "\\UserInput.xml");

            MessageBox.Show("Records Add Successfully");
            textBox_user_Input.Text = "";
            display();
        
        }

        ////////////////////////////////////////////////////////////display //////////////

        void display()
        {

            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\UserInput.xml");
            if (ds != null && ds.HasChanges())
            {
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.Columns[0].Name = "user_name";
                dataGridView2.Columns[0].HeaderText = "user_name";
                dataGridView2.Columns[0].DataPropertyName = "user_name";

                dataGridView2.Columns[1].Name = "type";
                dataGridView2.Columns[1].HeaderText = "type";
                dataGridView2.Columns[1].DataPropertyName = "type";

              



                dataGridView2.DataSource = ds.Tables[0];



            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 3)
            {




                DataSet ds = dataGridView2.DataSource as DataSet;

                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                string acnum = row.Cells[0].Value.ToString();

                string path = Application.StartupPath + "\\UserInput.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode node = doc.SelectSingleNode("//users/user[user_name='" + acnum + "']");
                node.ParentNode.RemoveChild(node);
                doc.Save(path);

                MessageBox.Show("Selected Record Deleted Successfully");

                display();



            }
            if (e.ColumnIndex == 2)
            {

                label3.Visible = true;
                label4.Visible = true;
                textBox_user_Input2.Visible = true;
                comboBox_Type2.Visible = true;
                butUpdate.Visible = true;
                label5.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox_user_Input2.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBox_Type2.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();

               // display();



            }

        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            update();


            label3.Visible = false;
            label4.Visible = false;
            textBox_user_Input2.Visible = false;
            comboBox_Type2.Visible = false;
            butUpdate.Visible = false;

        }

        void update()
        {
            if (textBox_user_Input2.Text == "")
            {
                MessageBox.Show("PLZ Insert USER NAME ");
                return;

            }
            if (comboBox_Type2.Text == "Select")
            {
                MessageBox.Show("PLZ Select Type ");
                return;

            }
           

          
            string acnum = label5.Text;
            string path = Application.StartupPath + "\\UserInput.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("//users/user[user_name='" + acnum + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(path);

            XmlDocument MyXmlDocument = new XmlDocument();
            MyXmlDocument.Load(Application.StartupPath + "\\UserInput.xml");
            XmlElement ParentElement = MyXmlDocument.CreateElement("user");
            XmlElement user_name = MyXmlDocument.CreateElement("user_name");
            user_name.InnerText = textBox_user_Input2.Text;
            XmlElement type = MyXmlDocument.CreateElement("type");
            type.InnerText = comboBox_Type2.Text;


            ParentElement.AppendChild(user_name);
            ParentElement.AppendChild(type);


            MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            MyXmlDocument.Save(Application.StartupPath + "\\UserInput.xml");

            MessageBox.Show("Selected Record Update Successfully");

            display();
        
        
        }

        private void buttonToken_Click(object sender, EventArgs e)
        {

        }
        void AddToken()
        {

            XmlDocument MyXmlDocument = new XmlDocument();
            MyXmlDocument.Load(Application.StartupPath + "\\UserInput.xml");
            XmlElement ParentElement = MyXmlDocument.CreateElement("user");
            XmlElement user_name = MyXmlDocument.CreateElement("user_name");
            user_name.InnerText = textBox_user_Input.Text;
            XmlElement type = MyXmlDocument.CreateElement("type");
            type.InnerText = comboBox_Type.Text;


            ParentElement.AppendChild(user_name);
            ParentElement.AppendChild(type);


            MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            MyXmlDocument.Save(Application.StartupPath + "\\UserInput.xml");

            MessageBox.Show("Records Add Successfully");
        
        }

        //void displayToken()
        //{

        //    DataSet ds = new DataSet();
        //    ds.ReadXml(Application.StartupPath + "\\InsertToken.xml");
        //    if (ds != null && ds.HasChanges())
        //    {
        //        dataGridView1.AutoGenerateColumns = false;
        //        dataGridView1.Columns[0].Name = "AddTokenn";
        //        dataGridView1.Columns[0].HeaderText = "AddTokenn";
        //        dataGridView1.Columns[0].DataPropertyName = "AddTokenn";
        //        dataGridView1.DataSource = ds.Tables[0];



        //    }


        //}
    }
}
