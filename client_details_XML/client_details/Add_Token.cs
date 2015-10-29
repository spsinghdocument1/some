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
    public partial class Add_Token : Form
    {
        long date = 0;
        string token = "";

        /// <summary>
        /// /////////////////////////////////////////////////////First tokem Add ///////////////////////////////////////
        public void firsttoken(string firs)
        {

            label8.Text = firs;

        }



        /// /////////////////////////////////////////////////////   end     ///////////////////////////////////////
        public Add_Token()
        {
            InitializeComponent();
            Exchange();
            order_type();
            InsertType_fun();
        }
        /////////////////////////////////////////////    Exchange  ////////////////////////////////////////////////////////


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
        /////////////////////////////////////////////    ORDER Type  ////////////////////////////////////////////////////////

        void order_type()
        {
            List<string> list = new List<string>();
            list.Add("Normal");
            list.Add("Spread");
            foreach (string ex in list)
            {

                comboB_OrderType.Items.Add(ex);

            }


        }



        //////////////////////////////////////////////////////////////////////////////// Ins type   /////////////////////
        List<Contract_File> InsertType_fun()
        {
            byte[] arr = new byte[6];

            CSV_Class.contract_fun();
            string str = CSV_Class.cimlist.Where(a => a.Token.Equals(35011)).First().InstrumentName;
            //  List<instru> list_instru = new List<instru>();


            string ar = "OPTSTK";
            arr = System.Text.UTF8Encoding.ASCII.GetBytes("OPTSTK");



            IEnumerable<string> dis = CSV_Class.cimlist.Select(a => a.InstrumentName).Distinct().ToList();





            foreach (string ex in dis)
            {
                if (ex == null || ex == "")
                {
                    continue;
                }
                else
                    comboBInstType.Items.Add(ex);
            }



            var v = CSV_Class.cimlist.Select(a => (a.InstrumentName)).ToList();
            int i = 0;
            char[] a1 = new char[6] { 'O', 'P', 'T', 'I', 'D', 'X' };
            arr = System.Text.UTF8Encoding.ASCII.GetBytes("OPTSTK");
            bool b = BitConverter.Equals(str, "OPTIDX");


            return CSV_Class.cimlist.ToList();



        }

        ////////////////////////////////////////////////////////////////////////////////////////// Exoirry  /////////////


        public static DateTime ConvertFromTimestamp(long timstamp)
        {
            DateTime datetime = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            return datetime.AddSeconds(timstamp);
        }
        void Exoirry()
        {
             combo_Exoiry.Items.Clear();

            IEnumerable<long> exp = CSV_Class.cimlist.Where(a => a.Symbol == comboB_Symbol.Text && a.InstrumentName == comboBInstType.Text).Select(r => r.ExpiryDate).ToList();

            foreach (long ex in exp)
            {

                string on = ConvertFromTimestamp(ex).ToShortDateString();

                combo_Exoiry.Items.Add(on);
                date = ex;

            }
          
            combo_OptionType.Items.Clear();
            combo_StrikePrice.Items.Clear();


        }

        private void comboB_Symbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Exoirry();
        }
        /////////////////////////////////////////////////////////////////////////////////////// SYMBOL ////////////////////////

        void InstType()
        {
            comboB_Symbol.Items.Clear();

            IEnumerable<string> symm = CSV_Class.cimlist.Where(a => a.InstrumentName == comboBInstType.Text).Select(q => q.Symbol).Distinct().ToList();

            foreach (string ex in symm)
            {
                if (ex == null || ex == "")
                {
                    continue;
                }
                else
                    comboB_Symbol.Items.Add(ex);
                combo_OptionType.Enabled = true;
                combo_StrikePrice.Enabled = true;
                combo_Exoiry.Items.Clear();
                combo_OptionType.Items.Clear();
                combo_StrikePrice.Items.Clear();

            }
            if (comboBInstType.Text == "FUTIVX" || comboBInstType.Text == "FUTIDX" || comboBInstType.Text == "FUTSTK")
            {

                combo_OptionType.Enabled = false;
                combo_StrikePrice.Enabled = false;
                combo_Exoiry.Items.Clear();
                combo_OptionType.Items.Clear();
                combo_StrikePrice.Items.Clear();


            }


        }
        ///////////////////////////////////////////////////////////////////////////
        void optionType()
        {
            combo_OptionType.Items.Clear();
            string df = comboBInstType.Text;

            var op = CSV_Class.cimlist.Where(a => a.ExpiryDate == date && a.InstrumentName == comboBInstType.Text && a.Symbol == comboB_Symbol.Text).First().OptionType;
         var   tokenw = CSV_Class.cimlist.Where(a => a.ExpiryDate == date && a.Symbol == comboB_Symbol.Text).First().Token;
         token = tokenw.ToString();
            combo_OptionType.Items.Add(op.ToString());

           // combo_Exoiry.Items.Clear();
          
            combo_StrikePrice.Items.Clear();
         


        }

        /// //////////////////////////////////////////////////////////////

     

        //////////////////////////////////////////

        /// //////////////////////////////////////////////////////////////
        void strike_prise()
        {

            var price = CSV_Class.cimlist.Where(a => a.ExpiryDate == date && a.InstrumentName == comboBInstType.Text && a.Symbol == comboB_Symbol.Text && a.OptionType == combo_OptionType.Text).First().StrikePrice;

            combo_StrikePrice.Items.Add(price.ToString());


        }
        //////////////////////////////////////////////////////////////////////end /////////////////
        ////////////////////////////////////////////////////////////////////// OK /////////////////
        void ok()
        {

            string Exchange = combo_Exchange.Text;
            string order_type = comboB_OrderType.Text;
            string Inst_type = comboBInstType.Text;
            string symbol = comboB_Symbol.Text;

            string exoiry = combo_Exoiry.Text;
            string option_type = combo_OptionType.Text;
            string strike_price = combo_StrikePrice.Text;
            string token2 = label8.Text;
            userview se = new userview();
            if (token2 == "label8")
            {

                se.sho2(Exchange, order_type, Inst_type, symbol, exoiry, option_type, strike_price, token);

                this.Close();


                se.Show();
            }
            else
            {
                se.sho3(Exchange, order_type, Inst_type, symbol, exoiry, option_type, strike_price, token, token2);

                this.Close();


                se.Show();
            
            
            }




        }

        //////////////////////////////////////////////////////////////////////end /////////////////

        private void comboBInstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InstType();
        }

        private void combo_OptionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            strike_prise();
        }

        private void combo_Exoiry_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            optionType();
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_ok_Click(object sender, EventArgs e)
        {
            ok();
        }


    }
}
