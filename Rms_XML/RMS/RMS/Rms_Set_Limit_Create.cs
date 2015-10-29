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
    public partial class Rms_Set_Limit_Create : Form
    {
        string s = Application.StartupPath;
        public Rms_Set_Limit_Create()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Insert_Text();

          
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////INSERT/////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        void Insert_Text()
        {
            string str ="";
            string[] a = new string[20];
            DataSet ds = new DataSet();
            ds.ReadXml(s + "\\Rms_set_Limit.xml");
            if (ds != null && ds.HasChanges())
            {
                

                        XmlDocument MyXmlDocument = new XmlDocument();

                        MyXmlDocument.Load(s + "\\Rms_set_Limit.xml");
                



                 //       XmlNodeList nodeList = MyXmlDocument.SelectNodes("//StudentDetailss/EntityId='" + textBox_Entity_id.Text + "']");

                 //foreach (XmlNode node in nodeList)
                 //{


                 //}
                       // MyXmlDocument.Load("D:\\Dropboxdata\\Rms\\RMS\\RMS\\bin\\Debug\\Rms_set_Limit.xml");


                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            str = (ds.Tables[0].Rows[i][0].ToString());


                            if (textBox_Entity_id.Text == (ds.Tables[0].Rows[i][0].ToString()))
                            {
                                MessageBox.Show("Duplicate Entity Id");

                                return;
                                clear();
                            }
                           

                        }

                        
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        XmlElement ParentElement = MyXmlDocument.CreateElement("Student");

                        XmlElement EntityId = MyXmlDocument.CreateElement("EntityId");

                        EntityId.InnerText = textBox_Entity_id.Text;

                        XmlElement BranchId = MyXmlDocument.CreateElement("BranchId");

                        BranchId.InnerText = comboBox_Branch_id.SelectedItem.ToString();



                        XmlElement CashFund = MyXmlDocument.CreateElement("CashFund");

                        CashFund.InnerText = textBox_Cash_Fund.Text;

                        XmlElement MTOMLimit = MyXmlDocument.CreateElement("MTOMLimit");

                        MTOMLimit.InnerText = textBox_M_TO_M_Limit.Text;

                        XmlElement AdditionalFund = MyXmlDocument.CreateElement("AdditionalFund");

                        AdditionalFund.InnerText = textBox_Additional_Fund.Text;

                        XmlElement ExporsureLimit = MyXmlDocument.CreateElement("ExporsureLimit");

                        ExporsureLimit.InnerText = textBox_Exporsure_Limit.Text;



                        XmlElement TotalBuyQtyLimit = MyXmlDocument.CreateElement("TotalBuyQtyLimit");

                        TotalBuyQtyLimit.InnerText = textBox_Total_Buy_Qty_Limit.Text;
                        XmlElement TurnoverLimit = MyXmlDocument.CreateElement("TurnoverLimit");

                        TurnoverLimit.InnerText = textBox_Turnover_Limit.Text;
                        XmlElement TotalSellQtyLimit = MyXmlDocument.CreateElement("TotalSellQtyLimit");

                        TotalSellQtyLimit.InnerText = textBox_total_sell_qty_limit.Text;
                        XmlElement PortfolioLimit = MyXmlDocument.CreateElement("PortfolioLimit");

                        PortfolioLimit.InnerText = textBox_portfolio_limit.Text;
                        XmlElement SingleOrderQtyLimit = MyXmlDocument.CreateElement("SingleOrderQtyLimit");

                        SingleOrderQtyLimit.InnerText = textBox_single_order_qty_limit.Text;
                        XmlElement MaxQtyPerPortfolio = MyXmlDocument.CreateElement("MaxQtyPerPortfolio");

                        MaxQtyPerPortfolio.InnerText = textBox1_Max_Qty_Per_Portfolio.Text;
                        XmlElement SingleOrderValueLimit = MyXmlDocument.CreateElement("SingleOrderValueLimit");

                        SingleOrderValueLimit.InnerText = textBox_single_order_value_limit.Text;
                        XmlElement OSPositionLimit = MyXmlDocument.CreateElement("OSPositionLimit");

                        OSPositionLimit.InnerText = textBox1_O_S_Position_Limit.Text;

                        ParentElement.AppendChild(EntityId);
                        ParentElement.AppendChild(BranchId);
                        ParentElement.AppendChild(CashFund);
                        ParentElement.AppendChild(MTOMLimit);
                        ParentElement.AppendChild(AdditionalFund);
                        ParentElement.AppendChild(ExporsureLimit);
                        ParentElement.AppendChild(TotalBuyQtyLimit);
                        ParentElement.AppendChild(TurnoverLimit);
                        ParentElement.AppendChild(TotalSellQtyLimit);
                        ParentElement.AppendChild(PortfolioLimit);
                        ParentElement.AppendChild(SingleOrderQtyLimit);
                        ParentElement.AppendChild(MaxQtyPerPortfolio);
                        ParentElement.AppendChild(SingleOrderValueLimit);
                        ParentElement.AppendChild(OSPositionLimit);

                        MyXmlDocument.DocumentElement.AppendChild(ParentElement);
                        MyXmlDocument.Save(s + "\\Rms_set_Limit.xml");
                        MessageBox.Show("Records Add Successfully");
                        clear();

                    
                
            }
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////CLEAR///////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        void clear()
        {
            textBox_Entity_id.Text = "";
            textBox_Cash_Fund.Text = "";
            textBox_M_TO_M_Limit.Text = "";
            textBox_Additional_Fund.Text = "";
            textBox_Exporsure_Limit.Text = "";
            textBox_Total_Buy_Qty_Limit.Text = "";
            textBox_Turnover_Limit.Text = "";
            textBox_total_sell_qty_limit.Text = "";
            textBox_portfolio_limit.Text = "";
            textBox_single_order_qty_limit.Text = "";
            textBox1_Max_Qty_Per_Portfolio.Text = "";
            textBox_single_order_value_limit.Text = "";
            textBox1_O_S_Position_Limit.Text = "";



        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            clear();
        }



        //////////////////////////////////////////////////////////////////////////////////////



       
        
    }
}
