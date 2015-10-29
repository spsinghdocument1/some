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
    public partial class User_Input2 : Form
    {
        public User_Input2()
        {
            InitializeComponent();
            displayDataGrid();
            Display_lavel();
        }
        //////////////////////////////////////////////// Data grid View ////////////////////////////////////

        void displayDataGrid()
        {

            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\UserInput.xml");
            if (ds != null && ds.HasChanges())
            {
                dataGridView1.AutoGenerateColumns = false;
              dataGridView1.Columns[0].Name = "user_name";
                dataGridView1.Columns[0].HeaderText = "user_name";
               
                
                    dataGridView1.Columns[0].DataPropertyName = "user_name";
                
                dataGridView1.Columns[1].Name = "type";
                dataGridView1.Columns[1].HeaderText = "type";
               dataGridView1.Columns[1].DataPropertyName = "type";





                dataGridView1.DataSource = ds.Tables[0];



            }


        }
        /// /////////////////////////////////////////////// End  //////////////////////////////////////
    
      /// /////////////////////////////////////////////// Insert  //////////////////////////////////////
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
          //  save_token();
            MessageBox.Show("Records Add Successfully");
            textBox_user_Input.Text = "";
            //textBox_Token.Text = "";
            displayDataGrid();

        }
        /// /////////////////////////////////////////////// End  //////////////////////////////////////
       ////////////////////////////////////////////////// Update /////////////////////////////////////
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
           // update_Token();
            MessageBox.Show("Selected Record Update Successfully");

            displayDataGrid();
            //label7.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
          //  textBoxtok2.Visible = false;
            textBox_user_Input2.Visible = false;
            comboBox_Type2.Visible = false;
            butUpdate.Visible = false;


        }

        /// /////////////////////////////////////////////// End  //////////////////////////////////////

        /// /////////////////////////////////////////////// Token add & Update  //////////////////////////////////////
        void Display_lavel()
        {

            DataSet ds = new DataSet();
            ds.ReadXml(Application.StartupPath + "\\InsertToken.xml");
            if (ds != null && ds.HasChanges())
            {
                if (ds.Tables[0].Rows.Count >= 1)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    labelToken.Text = dr[2].ToString();
                }
            }
        }
       
        void EDITupdate_Token()
        {

            string acnum = labelToken.Text;
            string path = Application.StartupPath + "\\InsertToken.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("//TokensDetails/Token[AddTokenn='" + acnum + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(path);


            XmlDocument MyXmlDocument = new XmlDocument();
            MyXmlDocument.Load(Application.StartupPath + "\\InsertToken.xml");
            XmlElement ParentElement = MyXmlDocument.CreateElement("Token");
            XmlElement parameter = MyXmlDocument.CreateElement("parameter");
            parameter.InnerText = "PARAMETER";
            XmlElement portfolio = MyXmlDocument.CreateElement("portfolio");
            portfolio.InnerText = "PORTFOLIO";
            XmlElement AddTokenn = MyXmlDocument.CreateElement("AddTokenn");
            AddTokenn.InnerText = textBox_tok_up.Text;
            ParentElement.AppendChild(parameter);
            ParentElement.AppendChild(portfolio);
            ParentElement.AppendChild(AddTokenn);
            MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            MyXmlDocument.Save(Application.StartupPath + "\\InsertToken.xml");
            Display_lavel();

        }
       

        /// /////////////////////////////////////////////// End  //////////////////////////////////////
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataSet ds = dataGridView1.DataSource as DataSet;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string acnum = row.Cells[0].Value.ToString();
                string path = Application.StartupPath + "\\UserInput.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode node = doc.SelectSingleNode("//users/user[user_name='" + acnum + "']");
                node.ParentNode.RemoveChild(node);
                doc.Save(path);
                MessageBox.Show("Selected Record Deleted Successfully");
                displayDataGrid();

            }
            if (e.ColumnIndex == 2)
            {
                //textBoxtok2.Text = labelToken.Text;
                //label7.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
               // textBoxtok2.Visible = true;
                textBox_user_Input2.Visible = true;
                comboBox_Type2.Visible = true;
                butUpdate.Visible = true;
                label5.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox_user_Input2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBox_Type2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                // display();



            }
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
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void butTok_Edit_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
                textBox_tok_up.Visible = true;
                but_Token_Update.Visible = true;
                textBox_tok_up.Text = labelToken.Text;

        }

        private void but_Token_Update_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            textBox_tok_up.Visible = false;
            but_Token_Update.Visible = false;
            EDITupdate_Token();

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    userview u = new userview();
        //    u.Show();
        //}
    }
}
