using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace client_details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void formNameToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Token_Dlg td = new Token_Dlg();
        //    td.Show();

        //}

        private void visibleColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleColumns vis = new VisibleColumns();
            vis.MdiParent = this;

            vis.Show();
           // this.Close();
        

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepositionColumns re = new RepositionColumns();
            re.MdiParent = this;
            re.Show();
        }

        private void userInputToolStripMenuItem_Click(object sender, EventArgs e)
        {

            User_Input2 us = new User_Input2();
            us.MdiParent = this;
            us.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
