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
    public partial class VisibleColumns : Form
    {
        string s = Application.StartupPath;
        public VisibleColumns()
        {
            InitializeComponent();
            datagrFATCH_Colum();
        }
        void datagrFATCH_Colum()
        {
            string b = "";
            string c = "";
            DataSet ds = new DataSet();
            ds.ReadXml(s + "\\visible.xml");
            if (ds != null && ds.HasChanges())
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    b = ds.Tables[0].Rows[i][0].ToString();

                    // comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                    // dataGridView1.Columns.Add(ds.Tables[0].Rows[i][0].ToString());
                    dataGridView1.Columns.Add("h", b.ToString());
                   // dataGridView1.Rows.Add("f");

                }




            }
            DataSet ds2 = new DataSet();
            ds2.ReadXml(s + "\\UserView2.xml");
            if (ds2 != null && ds2.HasChanges())
            {
                for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                {
                    // c = ds2.Tables[0].Rows[i][0].ToString();

                    c = ds2.Tables[0].Rows[i][1].ToString();
                    dataGridView1.Rows.Add( c.ToString());
                    // dataGridView1.Rows.Add("f");

                }




            }


        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string PORTFOLIO;

           
            if (e.ColumnIndex == -1)
            {

                PORTFOLIO = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                //textBox_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                Modfy s = new Modfy();
                s.select_sho(PORTFOLIO);
                this.Close();
                s.Show();
            }
            

           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Select toD = new Select();
            ////Token_Dlg toD = new Token_Dlg();
            //this.Close();
            //toD.Show();

            userview uv = new userview();
            uv.MdiParent = this.ParentForm;

            this.Close();
            uv.Show();
        }

        private void btnModfy_Click(object sender, EventArgs e)
        {
            string PORTFOLIO;
        
           
            PORTFOLIO = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
            Modfy s = new Modfy();
            s.select_sho(PORTFOLIO);
            this.Close();
            s.Show();
          

        }
    }
}
