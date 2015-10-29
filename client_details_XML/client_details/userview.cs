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
    public partial class userview : Form
    {
        public userview()
        {
            InitializeComponent();
            show();
        }
        void show()
        {
            string PORTFOLIO = "PARAMETER";
            DataSet ds = new DataSet();
            string s = Application.StartupPath;
            string path = s + "\\InsertToken.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("//TokensDetails/Token[ parameter='" + PORTFOLIO + "']");
            string parameter = (node.SelectSingleNode("parameter").InnerText);
            string portfolio = (node.SelectSingleNode("portfolio").InnerText);
            string AddTokenn = (node.SelectSingleNode("AddTokenn").InnerText);
            dataGridView1.Columns.Add(parameter, parameter);
            dataGridView1.Columns.Add(portfolio, portfolio);
            for (int i = 1; i <= Convert.ToInt64(AddTokenn); i++)
            {
                dataGridView1.Columns.Add("Token_" + i, "Token_" + i);
            }



            ///////////////////////////////////////////////////////////////////////////////////////////
           
     
            DataSet ds2 = new DataSet();
            ds2.ReadXml(s + "\\UserInput.xml");
            if (ds2 != null && ds2.HasChanges())
            {
                string datagrd = "";
                for (int i = -1; i < ds2.Tables[0].Rows.Count; i++)
                {
                    
                    if (i == 0 || i == -1)
                    {

                    }
                    else
                    {
                       // datagrd = datagrd + ds2.Tables[0].Rows[i][0].ToString();
                        datagrd =  ds2.Tables[0].Rows[i][0].ToString();
                    }

                    dataGridView1.Rows.Add(datagrd.ToString());
                }


            }
        }
        

            //////////////////////////////////////// Insert //////////////////////////////////////////

        void inert()
        {
            string parameter="", portfalioo="", Token="",user="";
            string datagrd = "";
            parameter = (string)dataGridView1.Rows[0].Cells[0].Value;
            portfalioo = (string)dataGridView1.Rows[0].Cells[1].Value;
            if (portfalioo == null)
            {
                MessageBox.Show("Please Insert portfalio");
                return;
            }
 ////////////////////////////////////////////////////////////////////
            XmlDocument MyXmlDocument = new XmlDocument();
            MyXmlDocument.Load(Application.StartupPath + "\\UserView2.xml");
            XmlElement ParentElement = MyXmlDocument.CreateElement("Parameters");
            XmlElement PARAMETER = MyXmlDocument.CreateElement("PARAMETER");
            PARAMETER.InnerText = parameter;
            XmlElement portfalio = MyXmlDocument.CreateElement("portfalio");
            portfalio.InnerText = portfalioo;
            ParentElement.AppendChild(PARAMETER);
            ParentElement.AppendChild(portfalio);

            //////////////////////////////////////////// TOken ADD  ////////////////////////

            string PORTFOLIO = "PARAMETER";
            DataSet ds = new DataSet();
            string s = Application.StartupPath;
            string path = s + "\\InsertToken.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("//TokensDetails/Token[ parameter='" + PORTFOLIO + "']");
            string AddTokenn = (node.SelectSingleNode("AddTokenn").InnerText);
            for (int i = 1; i <= Convert.ToInt64(AddTokenn); i++)
            {
               // dataGridView1.Columns.Add("Token_" + i, "Token_" + i);
                 Token = Convert.ToString("Token_" + i);
                 XmlElement pToken = MyXmlDocument.CreateElement(Token);
                

                Token = (string)dataGridView1.Rows[0].Cells[1 + i].Value;
                pToken.InnerText = Token;
                ParentElement.AppendChild(pToken);

            }
            ////////////////////////////////////////////////////////////////////////// User Add  //////////////////
            DataSet ds2 = new DataSet();
            
            ds2.ReadXml(s + "\\UserInput.xml");
            if (ds2 != null && ds2.HasChanges())
            {
                
                for (int i = 1; i < ds2.Tables[0].Rows.Count; i++)
                {
                  
                    //if (i == 0 || i == -1)
                    //{

                    //}
                  //  else
                   // {
                        datagrd = Convert.ToString( ds2.Tables[0].Rows[i][0].ToString());

                        XmlElement datagrdd = MyXmlDocument.CreateElement(datagrd.Replace(" ",""));
                      
                        user = (string)dataGridView1.Rows[1+i].Cells[1].Value;
                        datagrdd.InnerText = user;
                        ParentElement.AppendChild(datagrdd);
                    //}

                    //dataGridView1.Rows.Add(""+datagrd.ToString());
                }


            }


            ////////////////////////////////////////////////////////////////////////////////////////////////


            MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            MyXmlDocument.Save(Application.StartupPath + "\\UserView2.xml");

            MessageBox.Show("Records Add Successfully");
        
        
        }
       

        /// /////////////////////////////////////////////////////////////
       ///////////////////////////////////////////////////////////////////// SHow Token //////////////////////////////

        public void sho2(string Exchan, string order_typ, string Inst_ty, string symb, string exoi, string option_ty, string strike_pri, string to1)
        {


            XmlDocument MyXmlDocument = new XmlDocument();
            MyXmlDocument.Load(Application.StartupPath + "\\addTokens.xml");
            XmlElement ParentElement = MyXmlDocument.CreateElement("Token");
            XmlElement Exchange = MyXmlDocument.CreateElement("Exchange");
            Exchange.InnerText = Exchan;
            XmlElement order_type = MyXmlDocument.CreateElement("order_type");
            order_type.InnerText = order_typ;
            XmlElement Inst_type = MyXmlDocument.CreateElement("Inst_type");
            Inst_type.InnerText = Inst_ty;
            XmlElement symbol = MyXmlDocument.CreateElement("symbol");
            symbol.InnerText = symb;
            XmlElement exoiry = MyXmlDocument.CreateElement("exoiry");
            exoiry.InnerText = exoi;
            XmlElement option_type = MyXmlDocument.CreateElement("option_type");
            option_type.InnerText = option_ty;
            XmlElement strike_price = MyXmlDocument.CreateElement("strike_price");
            strike_price.InnerText = strike_pri;
            XmlElement Token_1 = MyXmlDocument.CreateElement("Token_1");
            Token_1.InnerText = to1;

            ParentElement.AppendChild(Exchange);
            ParentElement.AppendChild(order_type);
            ParentElement.AppendChild(Inst_type);
            ParentElement.AppendChild(symbol);
            ParentElement.AppendChild(exoiry);
            ParentElement.AppendChild(option_type);
            ParentElement.AppendChild(strike_price);
            ParentElement.AppendChild(Token_1);
            MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            MyXmlDocument.Save(Application.StartupPath + "\\addTokens.xml");

          //  MessageBox.Show("Records Add Successfully");

            
            dataGridView1.Rows[0].Cells[2].Value = to1;

        }

        public void sho3(string Exchan, string order_typ, string Inst_ty, string symb, string exoi, string option_ty, string strike_pri, string to1 ,string to2)
        {


            XmlDocument MyXmlDocument = new XmlDocument();
            MyXmlDocument.Load(Application.StartupPath + "\\addToken2.xml");
            XmlElement ParentElement = MyXmlDocument.CreateElement("Token");
            XmlElement Exchange = MyXmlDocument.CreateElement("Exchange");
            Exchange.InnerText = Exchan;
            XmlElement order_type = MyXmlDocument.CreateElement("order_type");
            order_type.InnerText = order_typ;
            XmlElement Inst_type = MyXmlDocument.CreateElement("Inst_type");
            Inst_type.InnerText = Inst_ty;
            XmlElement symbol = MyXmlDocument.CreateElement("symbol");
            symbol.InnerText = symb;
            XmlElement exoiry = MyXmlDocument.CreateElement("exoiry");
            exoiry.InnerText = exoi;
            XmlElement option_type = MyXmlDocument.CreateElement("option_type");
            option_type.InnerText = option_ty;
            XmlElement strike_price = MyXmlDocument.CreateElement("strike_price");
            strike_price.InnerText = strike_pri;
            XmlElement Token_1 = MyXmlDocument.CreateElement("Token_1");
            Token_1.InnerText = to1;
            XmlElement Token_2 = MyXmlDocument.CreateElement("Token_2");
            Token_2.InnerText = to2;

            ParentElement.AppendChild(Exchange);
            ParentElement.AppendChild(order_type);
            ParentElement.AppendChild(Inst_type);
            ParentElement.AppendChild(symbol);
            ParentElement.AppendChild(exoiry);
            ParentElement.AppendChild(option_type);
            ParentElement.AppendChild(strike_price);
            ParentElement.AppendChild(Token_1);
            ParentElement.AppendChild(Token_2);

            MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            MyXmlDocument.Save(Application.StartupPath + "\\addToken2.xml");

           // MessageBox.Show("Records Add Successfully");
         

            dataGridView1.Rows[0].Cells[2].Value = to1;
            dataGridView1.Rows[0].Cells[3].Value = to2;

        }


        
        /// ///////////////////////////////////////////////////////////// END ////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {


            inert();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string w = (string)dataGridView1.Rows[0].Cells[2].Value;
            if (w== null)
            {
                Add_Token at = new Add_Token();
                this.Close();
                at.Show();
            }
            else
            {

                Add_Token at = new Add_Token();
                at.firsttoken(w);
                this.Close();
                at.Show();
            
            
            }



        }

        private void userview_Load(object sender, EventArgs e)
        {
        }
    }
}
