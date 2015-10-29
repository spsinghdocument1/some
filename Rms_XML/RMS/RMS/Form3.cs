using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using System.Text;
//using Microsoft.Office.Core;
//using xl = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Collections;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
//using DataAccessLayer.DAL;

namespace RMS
{
    public partial class Form3 : Form
    {
        //private List<xyz> accList;
        //SqlConnection con;
        //DataTable DTAB;

        public struct xyz
        {
            public string ClientCode;
            public string Name;
            public string FunddingValue;
            public string Profit;
            public string NetProfit;
            public string STT;
            public string JobbingBrokerag;
            public string DeliveryBrokerage;
            public string NetProfitLoss;
            public string Interest;
            public string PLAfterSharing;
            public string MinValue;
            public string PLAfterMinValue;
            public string FinancialAdjustment;
            public string Turnover;
            public string IdChrgAuctionPen;
            public string NetOptVal;
        }
        


        public Form3()
        {
            InitializeComponent();
            //con = new SqlConnection("Initial catalog =Spl_WPF; data source = ADMINMAYANK  ; user id =sa ; password = 1234");
            //DTAB = new DataTable();
            //DTAB.Columns.Add("ClientCode", typeof(string));
            //DTAB.Columns.Add("Name", typeof(string));
            //DTAB.Columns.Add("FunddingValue", typeof(string));
            //DTAB.Columns.Add("Profit", typeof(string));
            //DTAB.Columns.Add("NetProfit", typeof(string));
            //DTAB.Columns.Add("STT", typeof(string));
            //DTAB.Columns.Add("JobbingBrokerag", typeof(string));
            //DTAB.Columns.Add("DeliveryBrokerage", typeof(string));
            //DTAB.Columns.Add("NetProfitLoss", typeof(string));          
            //DTAB.Columns.Add("Interest", typeof(string));
            //DTAB.Columns.Add("PLAfterSharing", typeof(string));
            //DTAB.Columns.Add("MinValue", typeof(string));
            //DTAB.Columns.Add("PLAfterMinValue", typeof(string));
            //DTAB.Columns.Add("FinancialAdjustment", typeof(string));

            //DTAB.Columns.Add("Turnover", typeof(string));
          
            
          
            //DTAB.Columns.Add("IdChrgAuctionPen", typeof(string));
            //DTAB.Columns.Add("NetOptVal", typeof(string));

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // funnn();
           // fun();
        }

       // public void funnn()
        //{
        //    xl.Application xlApp = new xl.Application();
        //    Object missing = System.Type.Missing;

        //    xl.Workbook wkbook;
        //    xlApp.Application.Workbooks.OpenText(@"C:\\Users\\manish\\Desktop\\New folder (5)\\Window\\WindowsFormsApplication1\\WindowsFormsApplication1\\printsummery27063107 (1).spl",
        //        missing, 3,
        //        xl.XlTextParsingType.xlFixedWidth,
        //        xl.XlTextQualifier.xlTextQualifierNone,
        //        missing, missing, missing, true, missing, missing, missing,
        //        missing, missing, missing, missing, missing, missing);
        //    wkbook = xlApp.ActiveWorkbook;

        //    xl.Worksheet xlWorkSheet = (xl.Worksheet)wkbook.Worksheets.get_Item(1);

        //    var range = xlWorkSheet.UsedRange;
            
        //    int rCnt, cCnt;
            
        //    ArrayList alist = new ArrayList();
            
        //    dataGridView1.DataSource = rangeTable(range);

        //}
        //private DataTable rangeTable(Microsoft.Office.Interop.Excel.Range range)
        //{
        //    DataTable dataTable = new DataTable();
        //    int rowCnt = range.Rows.Count;
        //    int colCnt = range.Columns.Count;

        //    for (int i = 1; i <= rowCnt; i++)
        //    {
        //        DataRow newRow = dataTable.NewRow();
        //        for (int j = 1; j <= colCnt; j++)
        //        {
        //            if (i == 1)
        //            {
        //             //   dataTable.Columns.Add(Convert.ToString(((Microsoft.Office.Interop.Excel.Range)range.get_Item(i, j)).Value2), typeof(string));
        //            }
        //            else
        //            {
        //               // newRow[j - 1] = ((Microsoft.Office.Interop.Excel.Range)range.get_Item(i, j)).Value2;
        //            }
        //        }
        //        if (i > 1)
        //        {
        //            dataTable.Rows.Add(newRow);
        //        }
        //    }
           
        //    return dataTable;
        //}





     //   public void fun()
       // {
         //   xl.Application xlApp = new xl.Application();
         //   Object missing = System.Type.Missing;
        //    DTAB.Rows.Clear();
         //   dataGridView1.Rows.Clear();
         //   xl.Workbook wkbook;
          //  openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
         //   if (openFileDialog1.ShowDialog() == DialogResult.OK)
          //  {
                //  xlApp.Application.Workbooks.OpenText(@"C:\Users\manish\Desktop\New folder (5)\Window\WindowsFormsApplication1\WindowsFormsApplication1\\printSUMMERY01092509.spl",
            //    xlApp.Application.Workbooks.OpenText(openFileDialog1.FileName,
             //     missing, 3,
               //   xl.XlTextParsingType.xlFixedWidth,
               //   xl.XlTextQualifier.xlTextQualifierNone,
                //  missing, missing, missing, true, missing, missing, missing,
                 // missing, missing, missing, missing, missing, missing);
                //  }

          
       
               
          //  wkbook = xlApp.ActiveWorkbook;

            //xl.Worksheet xlWorkSheet = (xl.Worksheet)wkbook.Worksheets.get_Item(1);

            //var range = xlWorkSheet.UsedRange;
            //int rCnt, cCnt;
            //string str;
            //accList = new List<xyz>();
            //DataTable dt = new DataTable();
            //xyz oxyz=new xyz();
            //for (rCnt = 1; rCnt <= range.Rows.Count; rCnt++)
            //{
            //il:
            //    for (cCnt = 1; cCnt <= range.Columns.Count; cCnt++)
            //    {
            //         str = Convert.ToString((range.Cells[rCnt, 1] as xl.Range).Value2);


            //         if ((str == null) || str.Contains("--"))
            //         {
            //             if (rCnt <= range.Rows.Count)
            //             {
            //                 rCnt++;
            //                 goto il;
            //             }
            //             break;
                       
            //         }
            //         else if (str.Length == 1)
            //         {
            //             rCnt++;
            //             goto il;
            //         }
            //         else if (str.Trim() == "Date From" || str.Trim() == "Report Type" || str.Trim() == "Report Tota")
            //         {
            //             rCnt++;
            //             goto il;
            //         }

            //         if (rCnt > 2)
            //         {
            //             if (str.Trim() == "Client Code")
            //             {
            //                 rCnt++;
            //                 goto il;
            //             }
            //         }

            //        switch (cCnt)
            //        { 
            //            case 1:
            //                oxyz.ClientCode = Convert.ToString((range.Cells[rCnt, 1] as xl.Range).Value2);
                          
            //                break;
            //            case 2:
            //                oxyz.FunddingValue = Convert.ToString((range.Cells[rCnt+1, 9] as xl.Range).Value2);
            //                break;
                           

            //            case 3:
            //                oxyz.Name = Convert.ToString((range.Cells[rCnt, 3] as xl.Range).Value2);
            //                break;

            //            case 4:
            //                oxyz.Profit = Convert.ToString((range.Cells[rCnt, 5] as xl.Range).Value2);
            //                break;

            //            case 5:
            //                oxyz.STT = Convert.ToString((range.Cells[rCnt, 6] as xl.Range).Value2);
                          
            //                break;

            //            case 6:
            //                string jbval = Convert.ToString((range.Cells[rCnt, 7] as xl.Range).Value2);
            //                string[] split_v = jbval.Split(' ');
            //                if (split_v.Length > 2)
            //                {
            //                    oxyz.JobbingBrokerag = split_v[0]; // Convert.ToString((range.Cells[rCnt, 7] as xl.Range).Value2);
            //                }
            //                else
            //                    oxyz.JobbingBrokerag = "0.00";
            //                break;

            //            case 7:
            //                  string jbval1 = Convert.ToString((range.Cells[rCnt, 7] as xl.Range).Value2);
            //                string[] split_v1 = jbval1.Split(' ');
            //                foreach (var item in split_v1)
            //                {
            //                    oxyz.DeliveryBrokerage = item;
            //                }

                           
            //               // oxyz.DeliveryBrokerage = split_v1[1]; //Convert.ToString((range.Cells[rCnt, 8] as xl.Range).Value2);
            //                break;

            //            case 8:
            //                oxyz.Interest = Convert.ToString((range.Cells[rCnt, 10] as xl.Range).Value2);
            //                break;

            //            case 9:
            //                oxyz.NetProfitLoss = Convert.ToString((range.Cells[rCnt, 9] as xl.Range).Value2);
            //                break; 
            //            case 10:
            //                oxyz.PLAfterSharing = Convert.ToString((range.Cells[rCnt, 11] as xl.Range).Value2);
                          
            //                break;
            //            case 11:
            //                oxyz.MinValue = Convert.ToString((range.Cells[rCnt+1, 12] as xl.Range).Value2);
            //                break;
            //            case 12:
            //                oxyz.PLAfterMinValue = Convert.ToString((range.Cells[rCnt, 13] as xl.Range).Value2);
            //                break;
            //            case 13:
            //                oxyz.FinancialAdjustment = Convert.ToString((range.Cells[rCnt+1, 14] as xl.Range).Value2);
            //                break;
            //            case 14:
            //                oxyz.IdChrgAuctionPen = Convert.ToString((range.Cells[rCnt+1, 17] as xl.Range).Value2);
            //                break;
            //            case 15:
            //                oxyz.NetOptVal = Convert.ToString((range.Cells[rCnt + 1, 6] as xl.Range).Value2);
            //                break;
                        
            //        }

            //    }
            //dataGridView1.Rows.Add(oxyz.ClientCode, oxyz.Name, oxyz.Profit, oxyz.NetOptVal, oxyz.FunddingValue, oxyz.STT, oxyz.JobbingBrokerag,
            //      oxyz.DeliveryBrokerage, oxyz.NetProfitLoss, oxyz.Interest, oxyz.PLAfterSharing, oxyz.MinValue, oxyz.PLAfterMinValue,
            //        oxyz.FinancialAdjustment, oxyz.IdChrgAuctionPen);

            //DataRow drow = DTAB.NewRow();
            //drow["ClientCode"] = oxyz.ClientCode; drow["Name"] = oxyz.Name; drow["Profit"] = oxyz.Profit;
            //drow["FunddingValue"] = oxyz.FunddingValue; drow["STT"] = oxyz.STT;
            //drow["JobbingBrokerag"] = oxyz.JobbingBrokerag; drow["DeliveryBrokerage"] = oxyz.DeliveryBrokerage;
            //drow["NetProfitLoss"] = oxyz.NetProfitLoss; drow["Interest"] = oxyz.Interest;
            //drow["PLAfterSharing"] = oxyz.PLAfterSharing; drow["MinValue"] = oxyz.MinValue;
            //drow["PLAfterMinValue"] = oxyz.PLAfterMinValue; drow["FinancialAdjustment"] = oxyz.FinancialAdjustment; drow["IdChrgAuctionPen"] = oxyz.IdChrgAuctionPen;
            //drow["NetOptVal"] = oxyz.NetOptVal;
            //DTAB.Rows.Add(drow);
           // }

            //var d = DTAB;


            //using (SqlBulkCopy bulkCopy = new SqlBulkCopy(con))
            //{
            //    //bulkCopy.DestinationTableName = "Employee";
            //    if (con.State == ConnectionState.Closed)
            //    {
            //        con.Open();
            //    }
            //    bulkCopy.DestinationTableName = "SPL_DATA";

            //    //You can mannualy set the column mapping by the following way.
            //    //bulkCopy.ColumnMappings.Add("Employee ID", "Employee Code");
            //    bulkCopy.WriteToServer(DTAB);
            //}
     //   }



    }
}
