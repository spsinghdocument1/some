using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace RMS
{
    public partial class Xml : Form
    {
        string s = Application.StartupPath;
        public Xml()
        {
            InitializeComponent();
            Get_Xml();
            display();
            Display_lavel();
            combo();
        }

        void Get_Xml()
        {
            DataSet ds = new DataSet();
              string s = Application.StartupPath;
             ds.ReadXml(s+ "\\MyXmlFile.xml");

          //  ds.ReadXml("D:\\Dropboxdata\\Rms\\RMS\\RMS\\MyXmlFile.xml");
           // if (ds != null && ds.HasChanges())
           // {
                // XmlGridView.DataSource = ds;
                // XmlGridView.DataBind();


                dataGridView1.DataSource = ds.Tables[0];
           // }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert_Text();


        }



        void Insert_Text()
        {

            XmlDocument MyXmlDocument = new XmlDocument();

            MyXmlDocument.Load(s + "\\MyXmlFile.xml");

            XmlElement ParentElement = MyXmlDocument.CreateElement("Student");

            XmlElement ID = MyXmlDocument.CreateElement("ID");

            ID.InnerText = textBox_id.Text;

            XmlElement Name = MyXmlDocument.CreateElement("Name");

            Name.InnerText = textBox_name.Text;

            XmlElement Course = MyXmlDocument.CreateElement("Course");

            Course.InnerText = textBox_course.Text;

            XmlElement College = MyXmlDocument.CreateElement("College");

            College.InnerText = textBox_college.Text;

            ParentElement.AppendChild(ID);

            ParentElement.AppendChild(Name);

            ParentElement.AppendChild(Course);

            ParentElement.AppendChild(College);

            MyXmlDocument.DocumentElement.AppendChild(ParentElement);

            // MyXmlDocument.Save(Server.MapPath("~/MyXmlFile.xml"));
            MyXmlDocument.Save(s + "\\MyXmlFile.xml");
            MessageBox.Show("Records added Successfully");
            Get_Xml();

        }


        void display()
        {

            DataSet ds = new DataSet();
            ds.ReadXml(s + "\\MyXmlFile.xml");
            if (ds != null && ds.HasChanges())
            {
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.Columns[0].Name = "ID";
                dataGridView2.Columns[0].HeaderText = "ID";
                dataGridView2.Columns[0].DataPropertyName = "ID";

                dataGridView2.Columns[1].Name = "Name";
                dataGridView2.Columns[1].HeaderText = "Name";
                dataGridView2.Columns[1].DataPropertyName = "Name";

                dataGridView2.Columns[2].Name = "Course";
                dataGridView2.Columns[2].HeaderText = "Course";
                dataGridView2.Columns[2].DataPropertyName = "Course";

                dataGridView2.Columns[3].Name = "College";
                dataGridView2.Columns[3].HeaderText = "College";
                dataGridView2.Columns[3].DataPropertyName = "College";



                dataGridView2.DataSource = ds.Tables[0];



            }


        }


        void Display_lavel()
        {

            DataSet ds = new DataSet();
            ds.ReadXml(s + "\\MyXmlFile.xml");
            if (ds != null && ds.HasChanges())
            {

                if (ds.Tables[0].Rows.Count >= 1)
                {
                    DataRow dr = ds.Tables[0].Rows[3];


                    label4.Text = dr[0].ToString();
                    label5.Text = dr[2].ToString();


                }

            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }


        void combo()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(s + "\\MyXmlFile.xml");
            if (ds != null && ds.HasChanges())
            {
                //for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                //{
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                   // comboBox1.Items.Add(ds.Tables[0].Columns[i].ColumnName);
                    comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());

                }



            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string a, b, c, d, r, f, g, h;

            if (e.ColumnIndex == 4)
            {

                textBox_id.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox_name.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_course.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_college.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();



               
            }


            if (e.ColumnIndex == 5)
            {
                
               


                DataSet ds = dataGridView2.DataSource as DataSet;

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string acnum = row.Cells[0].Value.ToString();

                    string path = s + "\\MyXmlFile.xml";
                    XmlDocument doc = new XmlDocument();
                    doc.Load(path);
                    XmlNode node = doc.SelectSingleNode("//StudentDetails/Student[ID='" + acnum + "']");
                    node.ParentNode.RemoveChild(node);
                    doc.Save(path);

                    MessageBox.Show("Selected Record Deleted Successfully");

                    Get_Xml();



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
          


             // string root, b, c, d;

            string acnum = textBox_id.Text;
         


             // string path = s + "\\MyXmlFile.xml";
             // XmlDocument doc = new XmlDocument();
             // string acnum = textBox_id.Text;
             // doc.Load(path);
             //// XmlNode node = doc.SelectSingleNode("//StudentDetails/Student[Name='" + acnum + "']");
         

             // // the easiest way to create a new node to add to a document is to just clone an existing node
             // XmlNode node = doc.SelectSingleNode("//StudentDetails/Student[ID='" + acnum + "']");
           
             // XmlNode newnode = node.CloneNode(true);
             // // update element values for the new node
             // newnode.SelectSingleNode("Course").InnerText = textBox_course.Text;
             // newnode.SelectSingleNode("College").InnerText = textBox_college.Text;
            
             // // append the new node to the document
             // doc.DocumentElement.AppendChild(newnode);

             // // update the gridview to refresh display
             // XmlNodeList titles = doc.GetElementsByTagName(path);

             // //node.ParentNode.RemoveChild(node);

             // doc.Save();


          //  XmlElement element= new XmlElement();
           
           

            //string path = s + "\\MyXmlFile.xml";
            //XmlDocument doc = new XmlDocument();
            //string acnum = textBox_id.Text;
            //doc.Load(path);

            //string id = textBox_id.Text;
          
            //foreach (XmlElement elementt in doc.DocumentElement)
            //{
            //    //if (elementt.Name == "Student" && elementt.Attributes["ID"].Value == id)
            //    if (elementt.Name == "Student" && elementt.InnerXml["ID"].Value == id)
            //    {
            //        foreach (XmlNode node in elementt)
            //        {
            //            if (node.Name == "Name")
            //            {
            //                node.InnerText = textBox_name.Text; ;
            //            }

            //            if (node.Name == "Course")
            //            {
            //                node.InnerText = textBox_course.Text;
            //            }

            //            if (node.Name == "College")
            //            {
            //                node.InnerText = textBox_college.Text;
            //            }
            //        }
            //    }
            //}
            //doc.Save(s + "\\MyXmlFile.xml");        


            //XmlDocument xml = new XmlDocument();

            //xml.Load(s + "\\MyXmlFile.xml");

            //XmlNodeList elements = xml.SelectNodes("//StudentDetails/Student[ ID='" + acnum + "']");

            //foreach (XmlNode element in elements)
            //{
            //    if (element.InnerText == "Name")
            //    {
            //        XmlNode newvalue = xml.CreateElement("MODIFIED");
            //        element.ReplaceChild(newvalue, element);

            //        xml.Save(s + "\\MyXmlFile.xml");
            //    }
            //}


            //XElement xe = XElement.Load("XML FILE PATH");
            //XElement oldnode = xe.Element("DETAILS");
            //XElement newnode = new XElement("ITEMDETAILS", oldnode.Elements());
            //foreach (var item in oldnode.Attributes())
            //{
            //    newnode.SetAttributeValue(item.Name, item.Value);
            //}
            //xe.Add(newnode);
            //oldnode.Remove();





           


            MessageBox.Show("Selected Record Update Successfully");
             Get_Xml();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {


            DataSet ds = dataGridView2.DataSource as DataSet;

          //  DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string acnum = textBox_delete.Text;

            string path = s + "\\MyXmlFile.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            //XmlNode node = doc.SelectSingleNode("//StudentDetails/Student[ID='" + acnum + "']");

            XmlNode node  = doc.SelectSingleNode("//StudentDetails/Student[ Name='" + acnum + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(path);

            MessageBox.Show("Selected Record Deleted Successfully");

            Get_Xml();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //DataSet ds = new DataSet();
            //ds.ReadXml(s + "\\MyXmlFile.xml");
            //int xmlRow = Convert.ToInt32(textBox_id.Text);



            //ds.Tables[0].Rows[xmlRow]["Name"] = textBox_name.Text;
            //ds.Tables[0].Rows[xmlRow]["Course"] = textBox_course.Text;
            //ds.Tables[0].Rows[xmlRow]["College"] = textBox_college.Text;
          
            //ds.WriteXml(s + "\\MyXmlFile.xml");
            //Get_Xml();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //XmlDocument xml = new XmlDocument();

            //xml.Load(s + "\\MyXmlFile.xml");

            //XmlNodeList elements = xml.SelectNodes("//StudentDetails/Student[ ID='" + textBox_id.Text + "']");

            //foreach (XmlElement element in elements)
            //{

         

            //  //  if (element.SelectSingleNode("//StudentDetails/Student[ Name]").InnerText == "Pankaj")

            //    if (element.SelectSingleNode("//Name").InnerText == "Alarm1")
            //            // if (element.SelectSingleNode("//StudentDetails/Student[ Name]").InnerText == "Pankaj")
            //    {
            //        XmlNode newvalue = xml.CreateElement(textBox_name.Text);
            //        element.ReplaceChild(newvalue, element);

            //        xml.Save(s + "\\MyXmlFile.xml");
            //    }
            //}
            string a = Application.StartupPath;

            int acnum = Convert.ToInt32(textBox_id.Text);
            string path = a + "\\MySPXmlFile.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("//StudentDetails/Student[ ID='" + textBox_id.Text + "']");
            node.ParentNode.RemoveChild(node);
            doc.Save(path);




            ////If there is no current file, then create a new one

            if (!System.IO.File.Exists(path))
            {
                //Create neccessary nodes
                XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
                XmlComment comment = doc.CreateComment("This is an XML Generated File");

                doc.AppendChild(declaration);
                doc.AppendChild(comment);
            }
            //If there is already a file
            else
            {
                //    //Load the XML File
                doc.Load(path);

            }
            XmlElement id = doc.CreateElement("ID");
            XmlElement name = doc.CreateElement("Name");
            XmlElement Subroot = doc.CreateElement("Course");
            XmlElement BankName = doc.CreateElement("College");
           

            //Add the values for each nodes




           name.InnerText = textBox_name.Text;
            //AccountNumber.InnerText = row.Cells[3].ToString();

            //BankType.InnerText = row.Cells[4].ToString();
            //Balance.InnerText = row.Cells[5].ToString();

            ////Construct the document
            //doc.AppendChild(root);
            //root.AppendChild(Subroot);
            //Subroot.AppendChild(BankName);
            //Subroot.AppendChild(AccountNumber);
            //Subroot.AppendChild(BankType);
            //Subroot.AppendChild(Balance);
            doc.Save(path);
            MessageBox.Show("Selected Record Edited Successfully");
           
        }
       

    }
}

