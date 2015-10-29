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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            sh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //XmlDocument MyXmlDocument = new XmlDocument();
            //MyXmlDocument.Load(Application.StartupPath + "\\AddTokens.xml");
            //XmlElement ParentElement = MyXmlDocument.CreateElement("Token");
            //XmlElement Exchange = MyXmlDocument.CreateElement("Exchange");
            //Exchange.InnerText = "Exchange";
            //XmlElement order_type = MyXmlDocument.CreateElement("order_type");
            //order_type.InnerText = "order_type";
            //XmlElement Inst_type = MyXmlDocument.CreateElement("Inst_type");
            //Inst_type.InnerText = "Inst_type";
            //XmlElement symbol = MyXmlDocument.CreateElement("symbol");
            //symbol.InnerText = "symbol";
            //XmlElement exoiry = MyXmlDocument.CreateElement("exoiry");
            //exoiry.InnerText = "exoiry";
            //XmlElement option_type = MyXmlDocument.CreateElement("option_type");
            //option_type.InnerText = "option_type";
            //XmlElement strike_price = MyXmlDocument.CreateElement("strike_price");
            //strike_price.InnerText = "strike_price";
            //ParentElement.AppendChild(Exchange);
            //ParentElement.AppendChild(order_type);
            //ParentElement.AppendChild(Inst_type);
            //ParentElement.AppendChild(symbol);
            //ParentElement.AppendChild(exoiry);
            //ParentElement.AppendChild(option_type);
            //ParentElement.AppendChild(strike_price);
            //MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            //MyXmlDocument.Save(Application.StartupPath + "\\AddTokens.xml");
            //MessageBox.Show("Records Add Successfully");







        }
        void sh()
        {
            DataSet ds = new DataSet();
            string s = Application.StartupPath;
            ds.ReadXml(s + "\\AddTokens.xml");
            dataGridView1.DataSource = ds.Tables[0];
        
        
        
        
        }
    }
}
