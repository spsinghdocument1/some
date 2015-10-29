using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RMS
{
    public partial class Select : Form
    {
        string s = Application.StartupPath;
        public Select()
        {
            InitializeComponent();
            select();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // if (e.ColumnIndex == 4)
            //  {

            // textBox_id.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();





            // }
        }


        void select()
        {

            string b = "";
            DataSet ds = new DataSet();
            ds.ReadXml(s + "\\RepositionColumns.xml");
            if (ds != null && ds.HasChanges())
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    b = ds.Tables[0].Rows[i][0].ToString();

                    // comboBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                    // dataGridView1.Columns.Add(ds.Tables[0].Rows[i][0].ToString());
                   // dataGridView1.Columns.Add("h", b.ToString());
                    dataGridView1.Rows.Add( b.ToString());

                }

            }
        }
    }
}
