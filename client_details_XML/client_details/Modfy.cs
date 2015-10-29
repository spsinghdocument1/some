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
    public partial class Modfy : Form
    {
        string s = Application.StartupPath;
        public Modfy()
        {
            InitializeComponent();
          //  select();
            //show();
        }


        

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////
        public void select_sho(string PORTFOLIO2)
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
            dataGridView2.Columns.Add(parameter, parameter);
            dataGridView2.Columns.Add(portfolio, portfolio);
            for (int i = 1; i <= Convert.ToInt64(AddTokenn); i++)
            {
                dataGridView2.Columns.Add("Token_" + i, "Token_" + i);
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
                        datagrd = ds2.Tables[0].Rows[i][0].ToString();
                    }

                    dataGridView2.Rows.Add(datagrd.ToString());
                }


            }

            ///////////////////////////////////////////////////////////////////////////////////

            label1.Text = PORTFOLIO2;
            string ab = "";
            dataGridView2.Rows[0].Cells[1].Value = PORTFOLIO2;

            string path2 = s + "\\UserView2.xml";
            XmlDocument doc2 = new XmlDocument();
            doc2.Load(path2);
            XmlNode node2 = doc2.SelectSingleNode("//User_Parameters/Parameters[ portfalio='" + PORTFOLIO2 + "']");
    
           
            dataGridView2.Rows[0].Cells[0].Value = (node2.SelectSingleNode("PARAMETER").InnerText);
            dataGridView2.Rows[0].Cells[2].Value = (node2.SelectSingleNode("Token_1").InnerText);
            dataGridView2.Rows[0].Cells[3].Value = (node2.SelectSingleNode("Token_2").InnerText);
            dataGridView2.Rows[2].Cells[1].Value = (node2.SelectSingleNode("MAXQTY").InnerText);
            dataGridView2.Rows[3].Cells[1].Value = (node2.SelectSingleNode("BNSFOIFF").InnerText);
            dataGridView2.Rows[4].Cells[1].Value = (node2.SelectSingleNode("BFNSQTY").InnerText);
        }



      ////////////////////////////////////////////////////////////////////////////////////////////////////


        private void btnAdd_Click(object sender, EventArgs e)
        {


            string de = label1.Text;
            //  DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            //string parameter = (string)dataGridView1.Rows[0].Cells[0].Value;
            //string portfalio = (string)dataGridView1.Rows[0].Cells[1].Value;
            
            //string Token_1 = (string)dataGridView1.Rows[0].Cells[2].Value;
            //string Token_2 = (string)dataGridView1.Rows[0].Cells[3].Value;
            string path = s + "\\UserView2.xml";
            ////////////////////////////////////////////////////////Delete//////////////////////////////////////////////////////
            string path2 = s + "\\UserView2.xml";
            XmlDocument doc2 = new XmlDocument();
            doc2.Load(path2);
            XmlNode node2 = doc2.SelectSingleNode("//User_Parameters/Parameters[ portfalio='" +de + "']");
    
            node2.ParentNode.RemoveChild(node2);
            doc2.Save(path2);
            ///////////////////////////////////////////////////////// Update////////////////////////////////////////////////////

            inert();
            //XmlDocument MyXmlDocument = new XmlDocument();
            //MyXmlDocument.Load(Application.StartupPath + "\\UserParameter.xml");
            //XmlElement ParentElement = MyXmlDocument.CreateElement("Parameters");
            //XmlElement PARAMETER = MyXmlDocument.CreateElement("PARAMETER");
            //PARAMETER.InnerText = parameter;
            //XmlElement PORTFOLIO = MyXmlDocument.CreateElement("PORTFOLIO");
            //PORTFOLIO.InnerText = portfalio;
            //XmlElement TOKEN_1 = MyXmlDocument.CreateElement("TOKEN_1");
            //TOKEN_1.InnerText = Token_1;
            //XmlElement TOKEN_2 = MyXmlDocument.CreateElement("TOKEN_2");
            //TOKEN_2.InnerText = Token_2;

            //ParentElement.AppendChild(PARAMETER);
            //ParentElement.AppendChild(PORTFOLIO);
            //ParentElement.AppendChild(TOKEN_1);
            //ParentElement.AppendChild(TOKEN_2);

            //MyXmlDocument.DocumentElement.AppendChild(ParentElement);
            //MyXmlDocument.Save(Application.StartupPath + "\\UserParameter.xml");

            MessageBox.Show("Selected Record Update Successfully");
            //this.Close();
            //VisibleColumns vs = new VisibleColumns();
            //vs.Show();

        }

        /////////////////////////////////////////////////////////////////////////////////////  Edit  //////////////////////////////
        void inert()
        {
            string parameter = "", portfalioo = "", Token = "", user = "";
            string datagrd = "";
            parameter = (string)dataGridView2.Rows[0].Cells[0].Value;
            portfalioo = (string)dataGridView2.Rows[0].Cells[1].Value;
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


                Token = (string)dataGridView2.Rows[0].Cells[1 + i].Value;
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
                    datagrd = Convert.ToString(ds2.Tables[0].Rows[i][0].ToString());

                    XmlElement datagrdd = MyXmlDocument.CreateElement(datagrd.Replace(" ", ""));

                    user = (string)dataGridView2.Rows[1 + i].Cells[1].Value;
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


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    }
}
