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
    public partial class Select : Form
    {
        public static string parameter, portfalio, Token_1, Token_2;
        public string sy = "";
        string s = Application.StartupPath;
        public Select()
        {
            InitializeComponent();
            select();

        }

        public void sho(string Exchan, string order_typ, string Inst_ty, string symb, string exoi, string option_ty, string strike_pri)
        {

     
            XmlDocument MyXmlDocument = new XmlDocument();
            MyXmlDocument.Load(Application.StartupPath + "\\AddTokens.xml");
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
            ParentElement.AppendChild(Exchange);
            ParentElement.AppendChild(order_type);
            ParentElement.AppendChild(Inst_type);
            ParentElement.AppendChild(symbol);
            ParentElement.AppendChild(exoiry);
            ParentElement.AppendChild(option_type);
            ParentElement.AppendChild(strike_price);
            MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            MyXmlDocument.Save(Application.StartupPath + "\\AddTokens.xml");

            MessageBox.Show("Records Add Successfully");
            dataGridView1.Rows[0].Cells[2].Value = symb;
          
        }


        /// <summary>
        /// ////////////////////////////////////////////////////////////////////Add Token2 ////////////////////////////////////////////////////////
        /// 
        /// 
        /// 
        /// 
        public void sho2(string Exchan, string order_typ, string Inst_ty, string symb, string exoi, string option_ty, string strike_pri, string to1)
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
            ParentElement.AppendChild(Exchange);
            ParentElement.AppendChild(order_type);
            ParentElement.AppendChild(Inst_type);
            ParentElement.AppendChild(symbol);
            ParentElement.AppendChild(exoiry);
            ParentElement.AppendChild(option_type);
            ParentElement.AppendChild(strike_price);
            MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            MyXmlDocument.Save(Application.StartupPath + "\\addToken2.xml");

            MessageBox.Show("Records Add Successfully");
            dataGridView1.Rows[0].Cells[2].Value = to1;
            dataGridView1.Rows[0].Cells[3].Value = symb;
          
        }
        /// </summary>
   


        void select()
        {
            
          
            string b = "";
            string c = "";

            DataSet ds = new DataSet();
        
            ds.ReadXml(s + "\\RepositionColumns.xml");
            if (ds != null && ds.HasChanges())
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    b = ds.Tables[0].Rows[i][0].ToString();
                   
                   
                       dataGridView1.Rows.Add(b.ToString());
                       
                    
                }
        

                //////////////////////////////////////////////////////////////////////////////////////////////////////

                
               
              //  dataGridView1.Rows.Add(b.ToString());
                //////////////////////////////////////////////////////////////////////////////////////////////////////////


              

            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // string g = a;


            parameter = (string)dataGridView1.Rows[0].Cells[0].Value;
            portfalio = (string)dataGridView1.Rows[0].Cells[1].Value;
            Token_1 = (string)dataGridView1.Rows[0].Cells[2].Value;
            Token_2 = (string)dataGridView1.Rows[0].Cells[3].Value;



            XmlDocument MyXmlDocument = new XmlDocument();
            MyXmlDocument.Load(Application.StartupPath + "\\UserParameter.xml");
            XmlElement ParentElement = MyXmlDocument.CreateElement("Parameters");
            XmlElement PARAMETER = MyXmlDocument.CreateElement("PARAMETER");
            PARAMETER.InnerText = parameter;
            XmlElement PORTFOLIO = MyXmlDocument.CreateElement("PORTFOLIO");
            PORTFOLIO.InnerText = portfalio;
            XmlElement TOKEN_1 = MyXmlDocument.CreateElement("TOKEN_1");
            TOKEN_1.InnerText = Token_1;
            XmlElement TOKEN_2 = MyXmlDocument.CreateElement("TOKEN_2");
            TOKEN_2.InnerText = Token_2;

            ParentElement.AppendChild(PARAMETER);
            ParentElement.AppendChild(PORTFOLIO);
            ParentElement.AppendChild(TOKEN_1);
            ParentElement.AppendChild(TOKEN_2);
          
            MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            MyXmlDocument.Save(Application.StartupPath + "\\UserParameter.xml");

            MessageBox.Show("Records Add Successfully");
            this.Close();

            VisibleColumns f = new VisibleColumns();
            f.Show();


        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
    

            

            Token_Dlg td = new Token_Dlg();
        this.Close();
       td.Show();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           // if (e.ColumnIndex == 0)
            //    if(e.RowIndex==0)
            //{
           // dataa d = new dataa();


               //a = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
               // b = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
               //c = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
               //d = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();




           // }


           
        }
        class dataa
        {

            public string parameter { get; set; }
            public string portfalio { get; set; }
            public string Token_1 { get; set; }
            public string Token_2 { get; set; }

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //a = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //b = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //c = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //d = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void addToken2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Token_1 = (string)dataGridView1.Rows[0].Cells[2].Value;
            string Token_2 = (string)dataGridView1.Rows[0].Cells[3].Value;
            Token_Dlg2 td = new Token_Dlg2();
            td.lavesho(Token_1);
            this.Close();
            td.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
  
}
