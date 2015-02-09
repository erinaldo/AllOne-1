using CommonDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne.Packing
{
    public partial class FrmPackinglistMaster : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public string _PackNo = "";
        public bool _chon = false;
        public string _filePL = System.Windows.Forms.Application.StartupPath+"\\PL\\INVOICE PACKING LIST.xlsx";
        public string _filePLNew = System.Windows.Forms.Application.StartupPath+"\\ExportPL\\INVOICE PACKING LIST ";
        public FrmPackinglistMaster()
        {
            InitializeComponent();
        }
        public void ExportExcel()
        {
            _filePLNew = System.Windows.Forms.Application.StartupPath + "\\ExportPL\\INVOICE PACKING LIST ";
            string packno = grid.CurrentRow.Cells["PackNo"].Value.ToString();
            SqlParameter []para=new SqlParameter[1];
            para[0]=new SqlParameter("@PackNo",packno);

            CultureInfo oldCI = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            //try 
            //    {
            if (!Directory.Exists("PL"))
            {
                PublicFunction.ShowWarning("Không tìm thấy folder PL. Liên hệ admin để khắc phục lại.");
                return;
            }
            if (!Directory.Exists("ExportPL"))
                Directory.CreateDirectory("ExportPL");
            _filePLNew = _filePLNew + packno + ".xlsx";
            //Copy template 
            
            File.Delete(_filePLNew);
            File.Copy(_filePL,_filePLNew, true);
            //Variance 
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Workbook workBook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet;
            Microsoft.Office.Interop.Excel.Worksheet workSheet2;
            Microsoft.Office.Interop.Excel.Worksheet workSheet3;
            Microsoft.Office.Interop.Excel.Worksheet workSheetD;
            Microsoft.Office.Interop.Excel.Worksheet workSheetN=null;
            Range workRange;
            //Open file 
            if (File.Exists(_filePLNew)) 
            {
                workBook = app.Workbooks.Open(_filePLNew, Type.Missing, 
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, 
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, 
                        Type.Missing, Type.Missing, Type.Missing) ;
            }
            else 
            {
                workBook = app.Workbooks.Add(Type.Missing);
            }

            workSheet = workBook.Sheets[1] as Worksheet;
            workSheet.Name = "IN PO "+packno;
            workSheet2 = workBook.Sheets[2] as Worksheet;
            workSheet2.Name = "PACK PO "+packno;
            workSheet3 = workBook.Sheets[3] as Worksheet;
            workSheet3.Name = string.Format("IN PO {0} PIC-SIZE",packno);
            workSheetD = workBook.Sheets[4] as Worksheet;


            app.Visible = true;
            app.DisplayAlerts = false;
            //'Detail  Sheet 1
            int iRow = 29;
            int stt = 1;
            workSheet.Cells[2, 7] = "PO "+packno;
            workSheet.Cells[4, 4] ="'"+ grid.CurrentRow.Cells["Shipper"].Value.ToString();
            workSheet.Cells[5, 4] = "'" + grid.CurrentRow.Cells["Address"].Value.ToString();
            workSheet.Cells[6, 4] = "'" + grid.CurrentRow.Cells["Consignee"].Value.ToString();
            workSheet.Cells[7, 4] = "'" + grid.CurrentRow.Cells["AddC"].Value.ToString();
            workSheet.Cells[12, 4] = "'" + grid.CurrentRow.Cells["DeliveryAddress"].Value.ToString();
            workSheet.Cells[13, 4] = "'" + grid.CurrentRow.Cells["AddD"].Value.ToString();
            workSheet.Cells[15, 4] = "'" + grid.CurrentRow.Cells["Term"].Value.ToString();
            workSheet.Cells[16, 4] = "'" + grid.CurrentRow.Cells["ShipmentFrom"].Value.ToString();
            workSheet.Cells[17, 4] = "'" + grid.CurrentRow.Cells["ShipmentTo"].Value.ToString();
            if (grid.CurrentRow.Cells["ETD"].Value != DBNull.Value)
            {
                workSheet.Cells[18, 4] = "'" + Convert.ToDateTime(grid.CurrentRow.Cells["ETD"].Value).ToString("dd-MMM-yyyy");
            }
            workSheet.Cells[19, 4] = "'" + grid.CurrentRow.Cells["ShippingAgent"].Value.ToString();
            workSheet.Cells[20, 4] = "'" + grid.CurrentRow.Cells["BLNumber"].Value.ToString();
            workSheet.Cells[21, 4] = "'" + grid.CurrentRow.Cells["ContainerNumber"].Value.ToString();
            workSheet.Cells[22, 4] = "'" + grid.CurrentRow.Cells["SealNumber"].Value.ToString();
            workSheet.Cells[23, 4] = "'" + grid.CurrentRow.Cells["FeederVesselName"].Value.ToString();
            System.Data.DataTable tbPO = _db.ExecuteStoreProcedureTB("[sp_LoadPackinglistExport]", para);
            int index = 0;
            object tongtien = tbPO.Compute("sum(ThanhTien)", "");
            foreach (DataRow r in tbPO.Rows)
            {
                //'Merge cells 
                if (index > 0)
                {
                    //'MaSP 
                    if (r["MaSP"].ToString() == tbPO.Rows[index - 1]["MaSP"].ToString())
                    {
                        workRange = workSheet.Range[workSheet.Cells[iRow, 1], workSheet.Cells[iRow - 1, 1]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet.Range[workSheet.Cells[iRow, 2], workSheet.Cells[iRow - 1, 2]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet.Range[workSheet.Cells[iRow, 3], workSheet.Cells[iRow - 1, 3]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet.Range[workSheet.Cells[iRow, 4], workSheet.Cells[iRow - 1, 4]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }
                    else
                    {
                        stt += 1;
                        workSheet.Cells[iRow, 1] = stt;
                        workRange = workSheet.Cells[iRow, 1];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet.Cells[iRow, 2] = r["MaSP"].ToString();
                        workRange = workSheet.Cells[iRow, 2];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet.Cells[iRow, 3] = r["TenSP"].ToString();
                        workRange = workSheet.Cells[iRow, 3];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet.Cells[iRow, 4] = r["TenDVT"].ToString();
                        workRange = workSheet.Cells[iRow, 4];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        
                    }
                }
                else
                {
                    workSheet.Cells[iRow, 1] = stt;
                    workSheet.Cells[iRow, 2] = r["MaSP"].ToString();
                    workSheet.Cells[iRow, 3] = r["TenSP"].ToString();
                    workSheet.Cells[iRow, 4] = r["TenDVT"].ToString();

                    workRange = workSheet.Cells[iRow, 1];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet.Cells[iRow, 2];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet.Cells[iRow, 3];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet.Cells[iRow, 4];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    
                }
                // You have to get original bitmap path here

               workSheet.Cells[iRow, 5] = r["SoLuong"].ToString();
                workSheet.Cells[iRow, 6] = r["MaMau"].ToString();
                workSheet.Cells[iRow, 7] = r["GiaBan"].ToString();
                workSheet.Cells[iRow, 8] = r["ThanhTien"].ToString();

                workRange = workSheet.Cells[iRow, 5];
                workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                workRange = workSheet.Cells[iRow, 6];
                workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                workRange = workSheet.Cells[iRow, 7];
                workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                workRange.NumberFormat = "#,##0.00";
                workRange = workSheet.Cells[iRow, 8];
                workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                workRange.NumberFormat = "#,##0.00";

                iRow += 1;
                index += 1;
                System.Windows.Forms.Application.DoEvents();
            }
            // 'Footer 
            // 'Set format 
            workRange = workSheet.Cells[iRow, 5];
            workRange.Formula = string.Format("=SUM(E29:E{0})",iRow-1);

            workRange = workSheet.Cells[iRow, 8];
            workRange.Formula = string.Format("=SUM(H29:H{0})",iRow-1);

            workRange = workSheet.Cells[iRow+2, 2];
            workRange.Formula = "In Words: "+VNCurrency.ConvertNumberToStringUSD(tongtien.ToString(),false);
            workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

            workRange = workSheet.Range[workSheet.Cells[29, 1], workSheet.Cells[iRow - 1, 8]];
            workRange.Borders.Color = ColorTranslator.ToWin32(Color.Black);
            workRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            //=============================Sheet 2========================================================
            string sql = string.Format("select * from Pallet where PackNo='{0}' ", grid.CurrentRow.Cells["PackNo"].Value.ToString());
            System.Data.DataTable dtPallet = _db.FillDataTable(sql);
             iRow = 8;
             stt = 1;
            workSheet2.Cells[2, 1] = "PO " + packno;
            workSheet2.Cells[3, 4] = "'" + grid.CurrentRow.Cells["PackinglistNumber"].Value.ToString();
            workSheet2.Cells[4, 4] = "'" + grid.CurrentRow.Cells["ContainerNumber"].Value.ToString();
            workSheet2.Cells[3, 11] = "'" +Convert.ToDateTime( grid.CurrentRow.Cells["PLDate"].Value).ToString("dd-MMM-yyyy");
            workSheet2.Cells[4, 12] = "'" + grid.CurrentRow.Cells["SealNumber"].Value.ToString();
             index = 0;
            foreach (DataRow r in dtPallet.Rows)
            {
                //'Merge cells 
                if (index > 0)
                {
                    //PalletNo
                    if (r["PalletNo"].ToString() == dtPallet.Rows[index - 1]["PalletNo"].ToString())
                    {
                        workRange = workSheet2.Range[workSheet2.Cells[iRow, 1], workSheet2.Cells[iRow - 1, 1]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet2.Range[workSheet2.Cells[iRow, 7], workSheet2.Cells[iRow - 1, 7]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet2.Range[workSheet2.Cells[iRow, 8], workSheet2.Cells[iRow - 1, 8]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet2.Range[workSheet2.Cells[iRow, 9], workSheet2.Cells[iRow - 1, 9]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet2.Range[workSheet2.Cells[iRow, 10], workSheet2.Cells[iRow - 1, 10]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet2.Range[workSheet2.Cells[iRow, 11], workSheet2.Cells[iRow - 1, 11]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet2.Range[workSheet2.Cells[iRow, 13], workSheet2.Cells[iRow - 1, 13]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet2.Range[workSheet2.Cells[iRow, 14], workSheet2.Cells[iRow - 1, 14]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }else
                    {
                        workSheet2.Cells[iRow, 1] = r["PalletNo"].ToString();
                        workRange = workSheet2.Cells[iRow, 1];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet2.Cells[iRow, 7] = r["W"].ToString();
                        workRange = workSheet2.Cells[iRow, 3];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet2.Cells[iRow, 8] = r["L"].ToString();
                        workRange = workSheet2.Cells[iRow, 4];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet2.Cells[iRow, 9] = r["H"].ToString();
                        workRange = workSheet2.Cells[iRow, 2];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet2.Cells[iRow, 10] = r["UnitPallet"].ToString();
                        workRange = workSheet2.Cells[iRow, 3];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet2.Cells[iRow, 11] = "1";
                        workRange = workSheet2.Cells[iRow, 11];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet2.Cells[iRow, 13] = r["GrossWeight"].ToString();
                        workRange = workSheet2.Cells[iRow, 13];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet2.Cells[iRow,14] = r["CBM"].ToString();
                        workRange = workSheet2.Cells[iRow, 14];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    }
                    //'MaSP 
                    if (r["MaSP"].ToString() == dtPallet.Rows[index - 1]["MaSP"].ToString() &&
                        r["PalletNo"].ToString() == dtPallet.Rows[index - 1]["PalletNo"].ToString())
                    {
                        workRange = workSheet2.Range[workSheet2.Cells[iRow, 2], workSheet2.Cells[iRow - 1, 2]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet2.Range[workSheet2.Cells[iRow, 3], workSheet2.Cells[iRow - 1, 3]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet2.Range[workSheet2.Cells[iRow, 4], workSheet2.Cells[iRow - 1, 4]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }
                    else
                    {
                        workSheet2.Cells[iRow, 2] = r["MaSP"].ToString();
                        workRange = workSheet2.Cells[iRow, 2];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet2.Cells[iRow, 3] = r["TenSP"].ToString();
                        workRange = workSheet2.Cells[iRow, 3];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet2.Cells[iRow, 4] = r["TenDVT"].ToString();
                        workRange = workSheet2.Cells[iRow, 4];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    }
                }
                else
                {
                    workSheet2.Cells[iRow, 1] = r["PalletNo"].ToString();
                    workSheet2.Cells[iRow, 2] = r["MaSP"].ToString();
                    workSheet2.Cells[iRow, 3] = r["TenSP"].ToString();
                    workSheet2.Cells[iRow, 4] = r["TenDVT"].ToString();
                    workSheet2.Cells[iRow, 7] = r["W"].ToString();
                    workSheet2.Cells[iRow, 8] = r["L"].ToString();
                    workSheet2.Cells[iRow, 9] = r["H"].ToString();
                    workSheet2.Cells[iRow, 10] = r["UnitPallet"].ToString();
                    workSheet2.Cells[iRow, 11] = "1";
                    workSheet2.Cells[iRow, 13] = r["GrossWeight"].ToString();
                    workSheet2.Cells[iRow, 14] = r["CBM"].ToString();

                    workRange = workSheet2.Cells[iRow, 1];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet2.Cells[iRow, 2];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet2.Cells[iRow, 3];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet2.Cells[iRow, 4];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet2.Cells[iRow, 11];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                }
                // You have to get original bitmap path here

                //workSheet2.Cells[iRow, 2] = r.Cells["MaSP"].Value.ToString();
                //workSheet2.Cells[iRow, 3] = r.Cells["TenSP"].Value.ToString();
                //workSheet2.Cells[iRow, 4] = r.Cells["TenDVT"].Value.ToString();
                workSheet2.Cells[iRow, 5] = r["SoLuong"].ToString();
                workSheet2.Cells[iRow, 6] = r["MaMau"].ToString();
                workSheet2.Cells[iRow, 12] = r["NetWeight"].ToString();

                workRange = workSheet2.Cells[iRow, 5];
                workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                workRange = workSheet2.Cells[iRow, 6];
                workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                workRange = workSheet2.Cells[iRow, 12];
                workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                index += 1;
                iRow += 1;
                System.Windows.Forms.Application.DoEvents();
            }
            // 'Footer 
            // 'Set format 
            workRange = workSheet2.Cells[iRow, 5];
            workRange.Formula = string.Format("=SUM(E8:E{0})", iRow - 1);
            workRange = workSheet2.Cells[iRow, 10];
            workRange.Formula = string.Format("=SUM(J8:J{0})", iRow - 1);
            workRange = workSheet2.Cells[iRow, 11];
            workRange.Formula = string.Format("=SUM(K8:K{0})", iRow - 1);
            workRange = workSheet2.Cells[iRow, 13];
            workRange.Formula = string.Format("=SUM(M8:M{0})", iRow - 1);
            workRange = workSheet2.Cells[iRow, 14];
            workRange.Formula = string.Format("=SUM(N8:N{0})", iRow - 1);
            workRange = workSheet2.Range[workSheet2.Cells[8, 1], workSheet2.Cells[iRow , 14]];
            workRange.Borders.Color = ColorTranslator.ToWin32(Color.Black);
            workRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            //==========================Sheeet 3=======================================================================
             sql = string.Format("SELECT pl.PalletNo "+
                                 " ,p.[MaSP]"+
                                 " ,p.[MaMau]"+
                                 " ,p.[TenSP]"+
                                 " ,p.[TenDVT]"+
                                 " ,pl.[SoLuong]"+
                                 " ,[GiaBan]"+
                                 " ,pl.[SoLuong]*GiaBan as [ThanhTien]" +
	                             " ,sp.Rong,sp.Dai,sp.Cao"+
                                 " ,pl.W,pl.L,pl.H,UnitPallet,NetWeight,GrossWeight,CBM"+
                             " FROM [AllOne].[dbo].[Packinglist2] p"+
                             " left join [CTSanPham] sp"+
                             " on sp.MaSP=p.MaSP "+
                             " inner join (select * from Pallet where PackNo='{0}')pl "+
                             " on pl.MaSP=p.MaSP and pl.MaMau=p.MaMau "+
                             " where p.PackNo='{0}' "+
                             " order by pl.PalletNo,p.MaSP ",
                             grid.CurrentRow.Cells["PackNo"].Value.ToString());
            System.Data.DataTable dtPackD = _db.FillDataTable(sql);
            iRow = 8;
            stt = 1;
            workSheet3.Cells[2, 1] = "PO " + packno;
            workSheet3.Cells[3, 4] = "'" + grid.CurrentRow.Cells["PackinglistNumber"].Value.ToString();
            workSheet3.Cells[4, 4] = "'" + grid.CurrentRow.Cells["ContainerNumber"].Value.ToString();
            workSheet3.Cells[3, 16] = "'" + Convert.ToDateTime(grid.CurrentRow.Cells["PLDate"].Value).ToString("dd-MMM-yyyy");
            workSheet3.Cells[4, 17] = "'" + grid.CurrentRow.Cells["SealNumber"].Value.ToString();
               index = 0;
             List<string> lstSP = new List<string>();
             string mySP = "";
            foreach (DataRow r in dtPackD.Rows)
            {
                //'Merge cells 
                if (index > 0)
                {
                    if (mySP != r["MaSP"].ToString() || r["PalletNo"].ToString() != dtPackD.Rows[index - 1]["PalletNo"].ToString())
                    {
                        mySP = r["MaSP"].ToString();
                        lstSP.Clear();
                    }
                    // You have to get original bitmap path here
                    if (!lstSP.Contains(r["Rong"].ToString()))
                    {
                        lstSP.Add(r["Rong"].ToString());
                        workSheet3.Cells[iRow, 4] = r["Rong"].ToString();
                        workSheet3.Cells[iRow, 5] = r["Dai"].ToString();
                        workSheet3.Cells[iRow, 6] = r["Cao"].ToString();
                    }
                    //PalletNo
                    if (r["PalletNo"].ToString() == dtPackD.Rows[index - 1]["PalletNo"].ToString())
                    {
                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 1], workSheet3.Cells[iRow - 1, 1]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 12], workSheet3.Cells[iRow - 1, 12]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 13], workSheet3.Cells[iRow - 1, 13]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 14], workSheet3.Cells[iRow - 1, 14]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 15], workSheet3.Cells[iRow - 1, 15]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 16], workSheet3.Cells[iRow - 1, 16]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 18], workSheet3.Cells[iRow - 1, 18]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 19], workSheet3.Cells[iRow - 1, 19]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }
                    else
                    {
                        workSheet3.Cells[iRow, 1] = r["PalletNo"].ToString();
                        workRange = workSheet3.Cells[iRow, 1];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 12] = r["W"].ToString();
                        workRange = workSheet3.Cells[iRow, 3];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 13] = r["L"].ToString();
                        workRange = workSheet3.Cells[iRow, 4];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 14] = r["H"].ToString();
                        workRange = workSheet3.Cells[iRow, 2];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 15] = r["UnitPallet"].ToString();
                        workRange = workSheet3.Cells[iRow, 3];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 16] = "1";
                        workRange = workSheet3.Cells[iRow, 11];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 18] = r["GrossWeight"].ToString();
                        workRange = workSheet3.Cells[iRow, 13];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 19] = r["CBM"].ToString();
                        workRange = workSheet3.Cells[iRow, 14];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    }
                    //'MaSP 
                    if (r["MaSP"].ToString() == dtPackD.Rows[index - 1]["MaSP"].ToString() &&
                        r["PalletNo"].ToString() == dtPackD.Rows[index - 1]["PalletNo"].ToString())
                    {

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 2], workSheet3.Cells[iRow - 1, 2]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 3], workSheet3.Cells[iRow - 1, 3]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        Microsoft.Office.Interop.Excel.Range oRange1 = (Range)workSheet3.Cells[iRow - 1, 3];
                        Microsoft.Office.Interop.Excel.Range oRange2 = (Range)workSheet3.Cells[iRow, 3];
                        oRange2.RowHeight = oRange1.RowHeight;

                    }
                    else
                    {
                        workSheet3.Cells[iRow, 2] = r["MaSP"].ToString();
                        workRange = workSheet3.Cells[iRow, 2];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        Microsoft.Office.Interop.Excel.Range oRange = (Range)workSheet3.Cells[iRow, 3];
                        SanPham sp = new SanPham();
                        sp.MaSP_K = r["MaSP"].ToString();
                        _db.GetObject(ref sp);
                        int countSP = Convert.ToInt16(dtPackD.Compute("count(MaSP)", string.Format("MaSP='{0}' and PalletNo='{1}' ",
                            sp.MaSP_K, r["PalletNo"].ToString())));
                        if (sp.HinhAnh != null)
                        {
                            string imagString = System.Windows.Forms.Application.StartupPath + "\\ConDau.png";
                            PublicFunction.ConvertArrayByteToFile(imagString, sp.HinhAnh);
                            float Left = (float)((double)oRange.Left);
                            float Top = (float)((double)oRange.Top);
                            workSheet3.Shapes.AddPicture(imagString, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left + 5, Top + 5, sp.ImageW, sp.ImageH);
                        }

                        oRange.RowHeight = (sp.ImageH + 10.0) / countSP;

                    }
                    //DVT
                    if (r["MaSP"].ToString() == dtPackD.Rows[index - 1]["MaSP"].ToString() &&
                       r["PalletNo"].ToString() == dtPackD.Rows[index - 1]["PalletNo"].ToString())
                    {
                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 7], workSheet3.Cells[iRow - 1, 7]];
                        workRange.Merge(Type.Missing);
                    }
                    else
                    {
                        workSheet3.Cells[iRow, 7] = r["TenDVT"].ToString();
                        workRange = workSheet3.Cells[iRow, 7];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }


                    //ThanhTien
                    if (r["MaSP"].ToString() == dtPackD.Rows[index - 1]["MaSP"].ToString() &&
                        r["MaMau"].ToString() == dtPackD.Rows[index - 1]["MaMau"].ToString() &&
                        r["PalletNo"].ToString() == dtPackD.Rows[index - 1]["PalletNo"].ToString())
                    {
                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 8], workSheet3.Cells[iRow - 1, 8]];
                        workRange.Merge(Type.Missing);
                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 9], workSheet3.Cells[iRow - 1, 9]];
                        workRange.Merge(Type.Missing);
                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 10], workSheet3.Cells[iRow - 1, 10]];
                        workRange.Merge(Type.Missing);
                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 11], workSheet3.Cells[iRow - 1, 11]];
                        workRange.Merge(Type.Missing);
                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 17], workSheet3.Cells[iRow - 1, 17]];
                        workRange.Merge(Type.Missing);
                    }
                    else
                    {
                        workSheet3.Cells[iRow, 8] = r["SoLuong"].ToString();
                        workRange = workSheet3.Cells[iRow, 8];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        workSheet3.Cells[iRow, 9] = r["MaMau"].ToString();
                        workRange = workSheet3.Cells[iRow, 9];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        workSheet3.Cells[iRow, 10] = r["GiaBan"].ToString();
                        workRange = workSheet3.Cells[iRow, 10];
                        workRange.NumberFormat = "#,##0.00";
                        workRange = workSheet3.Cells[iRow, 10];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        workSheet3.Cells[iRow, 11] = r["ThanhTien"].ToString();
                        workRange = workSheet3.Cells[iRow, 11];
                        workRange.NumberFormat = "#,##0.00";
                        workRange = workSheet3.Cells[iRow, 11];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 17] = r["NetWeight"].ToString();
                        workRange = workSheet3.Cells[iRow, 17];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }
                }
                else
                {
                    mySP = r["MaSP"].ToString();
                    lstSP.Add(r["Rong"].ToString());
                    workSheet3.Cells[iRow, 4] = r["Rong"].ToString();
                    workSheet3.Cells[iRow, 5] = r["Dai"].ToString();
                    workSheet3.Cells[iRow, 6] = r["Cao"].ToString();


                    workSheet3.Cells[iRow, 1] = r["PalletNo"].ToString();
                    workSheet3.Cells[iRow, 2] = r["MaSP"].ToString();
                    workSheet3.Cells[iRow, 12] = r["W"].ToString();
                    workSheet3.Cells[iRow, 13] = r["L"].ToString();
                    workSheet3.Cells[iRow, 14] = r["H"].ToString();
                    workSheet3.Cells[iRow, 15] = r["UnitPallet"].ToString();
                    workSheet3.Cells[iRow, 16] = "1";
                    workSheet3.Cells[iRow, 17] = r["NetWeight"].ToString();
                    workSheet3.Cells[iRow, 18] = r["GrossWeight"].ToString();
                    workSheet3.Cells[iRow, 19] = r["CBM"].ToString();

                    workSheet3.Cells[iRow, 7] = r["TenDVT"].ToString();
                    workSheet3.Cells[iRow, 8] = r["SoLuong"].ToString();
                    workSheet3.Cells[iRow, 9] = r["MaMau"].ToString();
                    workSheet3.Cells[iRow, 10] = r["GiaBan"].ToString();
                    workSheet3.Cells[iRow, 11] = r["ThanhTien"].ToString();


                    Microsoft.Office.Interop.Excel.Range oRange = (Range)workSheet3.Cells[iRow, 3];
                    SanPham sp = new SanPham();
                    sp.MaSP_K = r["MaSP"].ToString();
                    _db.GetObject(ref sp);
                    int countSP = Convert.ToInt16(dtPackD.Compute("count(MaSP)", string.Format("MaSP='{0}' and PalletNo='{1}' ",
                                                  sp.MaSP_K, r["PalletNo"].ToString())));
                    if (sp.HinhAnh != null)
                    {
                        string imagString = System.Windows.Forms.Application.StartupPath + "\\ConDau.png";
                        PublicFunction.ConvertArrayByteToFile(imagString, sp.HinhAnh);
                        float Left = (float)((double)oRange.Left);
                        float Top = (float)((double)oRange.Top);
                        workSheet3.Shapes.AddPicture(imagString, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left + 5, Top + 5, sp.ImageW, sp.ImageH);
                    }


                    oRange.RowHeight = (sp.ImageH + 10.0) / countSP;


                    workRange = workSheet3.Cells[iRow, 1];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet3.Cells[iRow, 2];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet3.Cells[iRow, 3];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet3.Cells[iRow, 7];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 8];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 9];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 10];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange.NumberFormat = "#,##0.00";
                    workRange = workSheet3.Cells[iRow, 11];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange.NumberFormat = "#,##0.00";
                    workRange = workSheet3.Cells[iRow, 12];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 13];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 14];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 15];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 16];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 17];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 18];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 19];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                }
                    

               
                index += 1;
                iRow += 1;
                System.Windows.Forms.Application.DoEvents();
            }
             //'Footer 
             //'Set format 
            workRange = workSheet3.Cells[iRow, 8];
            workRange.Formula = string.Format("=SUM(H8:H{0})", iRow - 1);
            workRange = workSheet3.Cells[iRow, 11];
            workRange.Formula = string.Format("=SUM(K8:K{0})", iRow - 1);
            workRange = workSheet3.Cells[iRow, 15];
            workRange.Formula = string.Format("=SUM(O8:O{0})", iRow - 1);
            workRange = workSheet3.Cells[iRow, 16];
            workRange.Formula = string.Format("=SUM(P8:P{0})", iRow - 1);
            workRange = workSheet3.Cells[iRow, 18];
            workRange.Formula = string.Format("=SUM(R8:R{0})", iRow - 1);
            workRange = workSheet3.Cells[iRow, 19];
            workRange.Formula = string.Format("=SUM(S8:S{0})", iRow - 1);

            workRange = workSheet3.Cells[iRow + 2, 2];
            workRange.Formula = "In Words: " + VNCurrency.ConvertNumberToStringUSD(tongtien.ToString(), false);
            workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

            workRange = workSheet3.Range[workSheet3.Cells[8, 1], workSheet3.Cells[iRow - 1, 19]];
            workRange.Borders.Color = ColorTranslator.ToWin32(Color.Black);
            workRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            //Add Pallet No -------------------------------------------
            string sqlPalletNo = string.Format("  SELECT * " +
                                     " FROM [AllOne].[dbo].[Pallet] " +
                                     " where PackNo='{0}' " +
                                     " order by PalletNo desc,MaSP ",packno);
            System.Data.DataTable dtPalletNo = _db.FillDataTable(sqlPalletNo);
            if (dtPalletNo.Rows.Count > 0)
            {
                string plNo = "";
                int indexP = 4;
                foreach (DataRow r in dtPalletNo.Rows)
                {
                    if (plNo != r["PalletNo"].ToString())
                    {
                        indexP = 4;
                        plNo = r["PalletNo"].ToString();
                        workSheetD.Copy(Type.Missing, workSheet3);
                        workSheetN = workBook.Sheets[4] as Worksheet;
                        workSheetN.Name = string.Format(r["PalletNo"].ToString());
                        workSheetN.Cells[1, 1] = "PALLET No. " + workSheetN.Name.PadLeft(2,'0');
                    }
                    workSheetN.Cells[indexP,1 ] = r["MaSP"].ToString();
                    workSheetN.Cells[indexP, 3] = r["TenDVT"].ToString();
                    workSheetN.Cells[indexP, 4] = r["SoLuong"].ToString();
                    workSheetN.Cells[indexP, 5] = r["MaMau"].ToString();
                    indexP++;
                }
            }
            workBook.Save();
            //'Release all objects 
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.FinalReleaseComObject(workRange);
            Marshal.FinalReleaseComObject(workSheet);
            Marshal.FinalReleaseComObject(workSheet2);
            Marshal.FinalReleaseComObject(workSheet3);
            Marshal.FinalReleaseComObject(workBook);
            Marshal.FinalReleaseComObject(app);
            //    }
            //catch ( Exception ex)
            //{
            //    PublicFunction.ShowError(ex, "ExportExcel", Name);
            //}

            Thread.CurrentThread.CurrentCulture = oldCI;

        }
        private void TongCong()
        {
            decimal tongsoluong = 0;
            decimal tongthanhtien = 0;
            foreach (DataGridViewRow r in gridD.Rows)
            {
                if (!r.IsNewRow && r.Cells["SoLuong"].Value != null)
                {
                    if (r.Cells["SoLuong"].Value.ToString() != "")
                        tongsoluong += Convert.ToDecimal(r.Cells["SoLuong"].Value);
                }
                if (!r.IsNewRow && r.Cells["ThanhTien"].Value != null)
                {
                    if (r.Cells["ThanhTien"].Value.ToString() != "")
                        tongthanhtien += Convert.ToDecimal(r.Cells["ThanhTien"].Value);
                }
            }
            txtTongSL.Text = tongsoluong.ToString("N0");
            txtTongTien.Text = tongthanhtien.ToString("N3");
        }
        private void LoadPackinglist()
        {
            string sql = string.Format("sp_LoadPackinglist");
            SqlParameter []para=new SqlParameter[3];
            para[0] = new SqlParameter("@StartDate",PublicFunction.GetStartDate(dtpStart.Value));
            para[1] = new SqlParameter("@EndDate", PublicFunction.GetStartDate(dtpEnd.Value));
            para[2] = new SqlParameter("@PacKNo", txtPackNo.Text);
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.ExecuteStoreProcedureTB(sql,para);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }
        private void LoadPackinglist2()
        {
            string sql = string.Format("sp_LoadPackinglistDetail");
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@PackNo", grid.CurrentRow.Cells["PackNo"].Value.ToString());
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.ExecuteStoreProcedureTB(sql, para);
            bdnD.BindingSource = bdsource;
            gridD.DataSource = bdsource;
            TongCong();
        }
        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            LoadPackinglist();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.CurrentRow !=null)
            {
                LoadPackinglist2();
            }
        }
        private void txtPackNo_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource != null)
            {
                if (txtPackNo.Text == "")
                {
                    bdn.BindingSource.Filter = "";
                }
                else
                {
                    bdn.BindingSource.Filter = string.Format(" PackNo like '%{0}%' ", txtPackNo.Text);
                }
            }
        }

        private void bttChon_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow != null)
            {
                _PackNo = grid.CurrentRow.Cells["PackNo"].Value.ToString();
                Close();
            }
        }

        private void FrmPackinglistMaster_Shown(object sender, EventArgs e)
        {
            bttChon.Visible = _chon;
            bttThoat.Visible = _chon;
            bttXuatPL.Visible = !_chon;
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttXuatPL_Click(object sender, EventArgs e)
        {
            if (grid.CurrentRow == null || gridD.RowCount == 0)
            {
                PublicFunction.ShowWarning("Bạn chưa chọn Packinglist cần xuất.");
                return;
            }
            else
            {
                ExportExcel();
                PublicFunction.ShowSuccess();
            }
        }

        private void txtPackNo_KeyDown(object sender, KeyEventArgs e)
        {
            if  (e.KeyCode==Keys.Enter)
            {
                bttTimKiem.PerformClick();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
