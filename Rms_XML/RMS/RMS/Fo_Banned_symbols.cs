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
    public partial class Fo_Banned_symbols : Form
    {
        public Fo_Banned_symbols()
        {
            InitializeComponent();
            total();
            fatch();
            total2();
        }
        string s = Application.StartupPath;
        private void button3_Click(object sender, EventArgs e)
        {
            string acnum = "";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            foreach (Object obj in listBox2.SelectedItems)
            {

                listBox1.Items.Add(obj.ToString());

}


            foreach (object o in listBox2.SelectedItems)
                acnum += (acnum == "" ? "" : ", ") + o.ToString();



            XmlDocument MyXmlDocument = new XmlDocument();

            MyXmlDocument.Load(s + "\\Fo_banned_symbols.xml");
            XmlElement ParentElement = MyXmlDocument.CreateElement("Student");
            XmlElement Symbol = MyXmlDocument.CreateElement("Symbol");
            Symbol.InnerText = acnum;
            ParentElement.AppendChild(Symbol);
            MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            MyXmlDocument.Save(s + "\\Fo_banned_symbols.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int i;
            for (i = 0; i <= Convert.ToInt32(listBox1.Items.Count); i++)
            {
                sb.Append(i);


            }

            MessageBox.Show("Banned Symbols = " + (i - 1));
           
        }
        void total2()
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int i;
            for (i = 0; i <= Convert.ToInt32(listBox1.Items.Count); i++)
            {
                sb.Append(i);


            }

            label5.Text = ("" + (i - 1));
        
        
        
        }
        void total()
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int i;
            int j;
            for (i = 0; i <= Convert.ToInt32(listBox2.Items.Count); i++)
            {
                sb.Append(i);


            }

            label4.Text = ("" + (i - 1)); 
        
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dele(); 

        }

        void dele()
        {

            string acnum = "";
         System.Text.StringBuilder sb = new System.Text.StringBuilder();


         foreach (object o in listBox1.SelectedItems)
         
             acnum += (acnum == "" ? "" : ", ") + o.ToString();
             listBox1.Items.Remove(acnum);
                string path = s + "\\Fo_banned_symbols.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode node = doc.SelectSingleNode("//StudentDetails/Student[Symbol='" + acnum + "']");
                node.ParentNode.RemoveChild(node);
                doc.Save(path);
                MessageBox.Show("Selected Record Deleted Successfully");
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //save();
        }
        void save()
        {
            string str;
            DataSet ds = new DataSet();
            
             //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
             //           {
             //               str = (ds.Tables[0].Rows[i][0].ToString());


             //               if (textBox_Entity_id.Text == (ds.Tables[0].Rows[i][0].ToString()))
             //               {
             //                   MessageBox.Show("Duplicate Entity Id");

             //                   return;
                                
             //               }


            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (object item in listBox1.Items)
            {

                sb.Append(item.ToString());
                sb.Append(" ");

                XmlDocument MyXmlDocument = new XmlDocument();

                MyXmlDocument.Load(s + "\\Fo_banned_symbols.xml");
                XmlElement ParentElement = MyXmlDocument.CreateElement("Student");
                XmlElement Symbol = MyXmlDocument.CreateElement("Symbol");
                Symbol.InnerText = sb.ToString();
                ParentElement.AppendChild(Symbol);
                MyXmlDocument.DocumentElement.AppendChild(ParentElement);
                MyXmlDocument.Save(s + "\\Fo_banned_symbols.xml");
                
            }
            MessageBox.Show("Records added Successfully");
        }

        void fatch()
        {

            DataSet ds = new DataSet();
            ds.ReadXml(s + "\\Fo_banned_symbols.xml");
            if (ds != null && ds.HasChanges())
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                     listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());

                }



            }
        
        
        
        }
    }
}
