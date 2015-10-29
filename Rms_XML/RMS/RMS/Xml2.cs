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
    public partial class Xml2 : Form
    {
        public Xml2()
        {
            InitializeComponent();
           // sp();
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = Application.StartupPath;
            try
            {
                XmlTextReader xmlreader1 = new XmlTextReader("D:\\Dropboxdata\\Rms\\RMS\\RMS\\bin\\Debug\\MyXmlFile.xml");
                XmlTextReader xmlreader2 = new XmlTextReader("D:\\Dropboxdata\\Rms\\RMS\\RMS\\bin\\Debug\\XML2.xml");

                DataSet ds = new DataSet();
                ds.ReadXml(xmlreader1);
                DataSet ds2 = new DataSet();
                ds2.ReadXml(xmlreader2);
                ds.Merge(ds2);
               // ds2.Merge(ds);
                ds.WriteXml("D:\\Dropboxdata\\Rms\\RMS\\RMS\\bin\\Debug\\Books.xml");
               
                MessageBox.Show("Completed merging XML documents");
            }
            catch (System.Exception ex)
                
            {
                MessageBox.Show(ex.Message);
                 
            }




        }
        void sp()
        {

            DataSet ds = new DataSet();
            string s = Application.StartupPath;
            ds.ReadXml("D:\\Dropboxdata\\Rms\\RMS\\RMS\\bin\\Debug\\Books.xml");

            //  ds.ReadXml("D:\\Dropboxdata\\Rms\\RMS\\RMS\\MyXmlFile.xml");
            // if (ds != null && ds.HasChanges())
            // {
            // XmlGridView.DataSource = ds;
            // XmlGridView.DataBind();


          //  dataGridView1.DataSource = ds.Tables[0] ;



            // }




            DataTable dtAll = ds.Tables[0].Copy();
            for (var i = 1; i < ds.Tables.Count; i++)
            {
                dtAll.Merge(ds.Tables[i]);
            }
           // dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dtAll;
        
        }




        void display()
        {
            DataSet ds = new DataSet();
            string s = Application.StartupPath;
            ds.ReadXml("D:\\Dropboxdata\\Rms\\RMS\\RMS\\bin\\Debug\\Books.xml");

           // DataSet ds = entDal.enter();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].DataPropertyName = "ID";

            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[1].DataPropertyName = "Name";

            dataGridView1.Columns[2].Name = "Course";
            dataGridView1.Columns[2].HeaderText = "Course";
            dataGridView1.Columns[2].DataPropertyName = "Course";

            dataGridView1.Columns[3].Name = "College";
            dataGridView1.Columns[3].HeaderText = "College";
            dataGridView1.Columns[3].DataPropertyName = "College";

            dataGridView1.Columns[4].Name = "I";
            dataGridView1.Columns[4].HeaderText = "I";
            dataGridView1.Columns[4].DataPropertyName = "I";

            dataGridView1.Columns[5].Name = "N";
            dataGridView1.Columns[5].HeaderText = "N";
            dataGridView1.Columns[5].DataPropertyName = "N";

            dataGridView1.Columns[6].Name = "C";
            dataGridView1.Columns[6].HeaderText = "C";
            dataGridView1.Columns[6].DataPropertyName = "C";

            dataGridView1.Columns[7].Name = "Co";
            dataGridView1.Columns[7].HeaderText = "Co";
            dataGridView1.Columns[7].DataPropertyName = "Co";



            DataTable dtAll = ds.Tables[0].Copy();
            for (var i = 1; i < ds.Tables.Count; i++)
            {
                dtAll.Merge(ds.Tables[i]);
            }
             dataGridView1.AutoGenerateColumns = true;
            
            dataGridView1.DataSource = dtAll;

            dataGridView2.AutoGenerateColumns = true;

            dataGridView2.DataSource = dtAll;





        }
    }
}
