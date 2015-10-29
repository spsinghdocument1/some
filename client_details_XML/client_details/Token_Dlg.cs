using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using csv;
using Structure;
namespace client_details
{
    public partial class Token_Dlg : Form
    {
        long o = 0;
        struct instru
        {
            
            public string instrument;
        }

        struct exp
        {

            public long expirydate;
        }
        public static DateTime ConvertFromTimestamp(long timstamp)
        {
            DateTime datetime = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            return datetime.AddSeconds(timstamp);
        }

        public Token_Dlg()
        {
            InitializeComponent();
            Exchange();
            order_type();
            InsertType_fun();
          //  InsertType_fun();
        }
        void Exchange()
        {
            List<string> list = new List<string>();
            list.Add("NFO");
            list.Add("SPREAD");
          
            foreach (string ex in list)
            {
               combo_Exchange.Items.Add(ex);
            
            }

           
        }

        List<Contract_File> InsertType_fun()
        {
        byte[]arr=new byte[6];

            CSV_Class.contract_fun();
            string str =CSV_Class.cimlist.Where(a => a.Token.Equals(35011)).First().InstrumentName;
            List<instru> list_instru = new List<instru>();
          
            
            string  ar = "OPTSTK";
            arr = System.Text.UTF8Encoding.ASCII.GetBytes("OPTSTK");

           

          IEnumerable<string>  dis = CSV_Class.cimlist.Select(a => a.InstrumentName).Distinct().ToList();


            

         
            foreach (string ex in dis)
            {
                if (ex == null || ex =="")
                {
                    continue;
                }    
                else
                    comboBInstType.Items.Add(ex);
            }


         
       var v =CSV_Class.cimlist.Select(a=>(a.InstrumentName)).ToList();
            int i = 0;
            char[] a1 =new char[6]{'O','P','T','I','D','X'};
            arr = System.Text.UTF8Encoding.ASCII.GetBytes("OPTSTK");
            bool b=BitConverter.Equals(str, "OPTIDX");
        

           return  CSV_Class.cimlist.ToList();
            
            

        }

     
        void order_type()
        {
            List<string> list = new List<string>();
            list.Add("Normal");
           // list.Add("Srprit");
            list.Add("Spread");
            foreach (string ex in list)
            {

                comboB_OrderType.Items.Add(ex);

            }


        }

        void InstType() {

            IEnumerable<string> symm = CSV_Class.cimlist.Where(a => a.InstrumentName == comboBInstType.Text).Select(q => q.Symbol).Distinct().ToList();

            foreach (string ex in symm)
            {
                if (ex == null || ex == "")
                {
                    continue;
                }
                else
                    comboB_Symbol.Items.Add(ex);

                
            }
            if (comboBInstType.Text == "FUTIVX" || comboBInstType.Text == "FUTIDX" || comboBInstType.Text == "FUTSTK")
            {

                combo_OptionType.Enabled = false;
                combo_StrikePrice.Enabled = false;
            
            
            }
        
        
        }
        void Exoirry()
        {
           

            IEnumerable<long> exp = CSV_Class.cimlist.Where(a => a.Symbol == comboB_Symbol.Text && a.InstrumentName == comboBInstType.Text).Select(r => r.ExpiryDate).ToList();

            foreach (long ex in exp)
            {
               
                string on = ConvertFromTimestamp(ex).ToShortDateString();
             
                    combo_Exoiry.Items.Add(on);
                 o = ex;
            
            }
       
           
        }

        void optionType()
        {

            var op = CSV_Class.cimlist.Where(a => a.ExpiryDate == o && a.InstrumentName == comboBInstType.Text && a.Symbol == comboB_Symbol.Text).First().OptionType;
         
       
           combo_OptionType.Items.Add( op.ToString());
              

        


        }


        void strike_prise()
        {

            var price = CSV_Class.cimlist.Where(a => a.ExpiryDate == o && a.InstrumentName == comboBInstType.Text && a.Symbol == comboB_Symbol.Text && a.OptionType == combo_OptionType.Text).First().StrikePrice;

            combo_StrikePrice.Items.Add(price.ToString());
        
        
        }
        void ok()
        {

            string Exchange = combo_Exchange.Text;
            string order_type=comboB_OrderType.Text;
                string Inst_type=comboBInstType.Text;
                    string  symbol=comboB_Symbol.Text;
                        
                    string exoiry=combo_Exoiry.Text;
                        string option_type=combo_OptionType.Text;
                        string strike_price = combo_StrikePrice.Text;
                        Select se = new Select();
                      
                        se.sho(Exchange, order_type, Inst_type, symbol, exoiry, option_type, strike_price);
                        this.Close();

                  se.Show();

            

           
        
        }


        private void but_ok_Click(object sender, EventArgs e)
        {
            ok();  
            
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void comboBInstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InstType();
        }

        private void comboB_Symbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Exoirry();
        }

        private void combo_Exoiry_SelectedIndexChanged(object sender, EventArgs e)
        {
            optionType();
        }

        private void combo_StrikePrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combo_OptionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            strike_prise(); 
        }

        private void combo_Exchange_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboB_OrderType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
