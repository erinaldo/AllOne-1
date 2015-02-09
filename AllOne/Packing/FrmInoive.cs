using AllOne.NhapXuatTon;
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
using WeifenLuo.WinFormsUI.Docking;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace AllOne.Packing
{
    public partial class FrmInvoice : DockContent
    {
        List<SanPhamGia> lstMaSP = new List<SanPhamGia>();
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public string _filePL = System.Windows.Forms.Application.StartupPath + "\\PL\\PROFORMA INVOICE.xlsx";
        public string _filePLNew = System.Windows.Forms.Application.StartupPath + "\\ExportPL\\PROFORMA INVOICE PO ";
        public FrmInvoice()
        {
            InitializeComponent();
        }
        private void LoadInvoiceNo()
        {
            string sql = string.Format("select distinct InvoiceNo from Invoice where Ngaytao between @StartDate and @EndDate");
           SqlParameter []para=new SqlParameter[2];
           para[0] = new SqlParameter("@StartDate", PublicFunction.GetStartDate(dtpStart.Value));
           para[1] = new SqlParameter("@EndDate", PublicFunction.GetStartDate(dtpEnd.Value));

           cboInvoice.DataSource = _db.FillDataTable(sql, para);
           cboInvoice.ValueMember = "InvoiceNo";
           cboInvoice.DisplayMember = "InvoiceNo";
           cboInvoice.SelectedIndex = -1;
        }
        public void ExportExcel()
        {
            _filePLNew = System.Windows.Forms.Application.StartupPath + "\\ExportPL\\PROFORMA INVOICE PO ";
            string invoiceNo = cboInvoice.Text;
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@InvoiceNo", invoiceNo);

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
            _filePLNew = _filePLNew + invoiceNo + ".xlsx";
            //Copy template 

            File.Delete(_filePLNew);
            File.Copy(_filePL, _filePLNew, true);
            //Variance 
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Workbook workBook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet3;
            Range workRange=null;
            //Open file 
            if (File.Exists(_filePLNew))
            {
                workBook = app.Workbooks.Open(_filePLNew, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing);
            }
            else
            {
                workBook = app.Workbooks.Add(Type.Missing);
            }

            workSheet3 = workBook.Sheets[1] as Worksheet;
            workSheet3.Name = "Invoice " + invoiceNo;


            app.Visible = true;
            app.DisplayAlerts = false;
            //'Detail  Sheet 1
           
            //==========================Sheeet 3=======================================================================
            string sql = string.Format("SELECT p.InvoiceNo " +
                                " ,p.[MaSP]" +
                                " ,p.[MaMau]" +
                                " ,p.[TenSP]" +
                                " ,p.[TenDVT]" +
                                " ,p.SetPerPallet " +
                                " ,p.[SoLuong]" +
                                " ,p.[GiaBan]" +
                                " ,p.[ThanhTien]" +
                                " ,sp.Rong,sp.Dai,sp.Cao" +
                                " ,p.W,p.L,p.H,m.Price - 1 as [Percent],p.GiaGoc " +
                            " FROM [AllOne].[dbo].[Invoice] p" +
                            " left join [CTSanPham] sp" +
                            " on sp.MaSP=p.MaSP " +
                            " inner join Mau m" +
                            " on m.MaMau=p.MaMau " +
                            " where p.InvoiceNo='{0}' " +
                            " order by  p.MaSP,p.MaMau ",
                            cboInvoice.Text);
            System.Data.DataTable dtPackD = _db.FillDataTable(sql);
           int iRow = 4;
           workSheet3.Cells[1, 1] = "PROFORMA INVOICE PO " + invoiceNo;
           int  index = 0;
            List<string> lstSP = new List<string>();
            string mySP = "";
            foreach (DataRow r in dtPackD.Rows)
            {
                //'Merge cells 
                if (index > 0)
                {
                    if (mySP != r["MaSP"].ToString())
                    {
                        mySP = r["MaSP"].ToString();
                        lstSP.Clear();
                    }
                    // You have to get original bitmap path here
                    if (!lstSP.Contains(r["Rong"].ToString()))
                    {
                        lstSP.Add(r["Rong"].ToString());
                        workSheet3.Cells[iRow, 8] = r["Rong"].ToString();
                        workSheet3.Cells[iRow, 9] = r["Dai"].ToString();
                        workSheet3.Cells[iRow, 10] = r["Cao"].ToString();
                    }
                    //PalletNo
                    if (r["MaSP"].ToString() == dtPackD.Rows[index - 1]["MaSP"].ToString())
                    {
                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 1], workSheet3.Cells[iRow - 1, 1]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 2], workSheet3.Cells[iRow - 1, 2]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        Microsoft.Office.Interop.Excel.Range oRange1 = (Range)workSheet3.Cells[iRow - 1, 2];
                        Microsoft.Office.Interop.Excel.Range oRange2 = (Range)workSheet3.Cells[iRow, 2];
                        oRange2.RowHeight = oRange1.RowHeight;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 3], workSheet3.Cells[iRow - 1, 3]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 4], workSheet3.Cells[iRow - 1, 4]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 5], workSheet3.Cells[iRow - 1, 5]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 6], workSheet3.Cells[iRow - 1, 6]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 7], workSheet3.Cells[iRow - 1, 7]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 13], workSheet3.Cells[iRow - 1, 13]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }
                    else
                    {
                        workSheet3.Cells[iRow, 1] = r["MaSP"].ToString();
                        workRange = workSheet3.Cells[iRow, 1];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

         
                        workSheet3.Cells[iRow, 3] = r["TenDVT"].ToString();
                        workRange = workSheet3.Cells[iRow, 4];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 4] = r["SetPerPallet"].ToString();
                        workRange = workSheet3.Cells[iRow, 2];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 5] = r["W"].ToString();
                        workRange = workSheet3.Cells[iRow, 3];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 6] = r["L"].ToString();
                        workRange = workSheet3.Cells[iRow, 11];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 7] = r["H"].ToString();
                        workRange = workSheet3.Cells[iRow, 13];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 13] = r["GiaGoc"].ToString();
                        workRange = workSheet3.Cells[iRow, 14];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 1] = r["MaSP"].ToString();
                        workRange = workSheet3.Cells[iRow, 1];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        Microsoft.Office.Interop.Excel.Range oRange = (Range)workSheet3.Cells[iRow, 2];
                        SanPham sp = new SanPham();
                        sp.MaSP_K = r["MaSP"].ToString();
                        _db.GetObject(ref sp);
                        int countSP = Convert.ToInt16(dtPackD.Compute("count(MaSP)", string.Format("MaSP='{0}' and MaMau='{1}' ",
                            sp.MaSP_K, r["MaMau"].ToString())));
                        if (sp.HinhAnh != null)
                        {
                            string imagString = System.Windows.Forms.Application.StartupPath + "\\ConDau.png";
                            PublicFunction.ConvertArrayByteToFile(imagString, sp.HinhAnh);
                            float Left = (float)((double)oRange.Left);
                            float Top = (float)((double)oRange.Top);
                            workSheet3.Shapes.AddPicture(imagString, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left + 5, Top + 5, sp.ImageW, sp.ImageH);
                        }

                        oRange.RowHeight = (sp.ImageH + 10.0) / countSP;


                        oRange = (Range)workSheet3.Cells[iRow, 12];
                        Mau m = new Mau();
                        m.MaMau_K = r["MaMau"].ToString();
                        _db.GetObject(ref m);
                        if (m.Hinh != null)
                        {
                            string imagString = System.Windows.Forms.Application.StartupPath + "\\ConDau.png";
                            PublicFunction.ConvertArrayByteToFile(imagString, m.Hinh);
                            float Left = (float)((double)oRange.Left);
                            float Top = (float)((double)oRange.Top);
                            workSheet3.Shapes.AddPicture(imagString, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left + 5, Top + 15, m.W, m.H);
                            //oRange.RowHeight = (m.H + 10.0);/// countSP;
                        }
                       

                    }


                    //ThanhTien
                    if (r["MaSP"].ToString() == dtPackD.Rows[index - 1]["MaSP"].ToString() &&
                        r["MaMau"].ToString() == dtPackD.Rows[index - 1]["MaMau"].ToString() )
                    {
                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 11], workSheet3.Cells[iRow - 1, 11]];
                        workRange.Merge(Type.Missing);
                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 12], workSheet3.Cells[iRow - 1, 12]];
                        workRange.Merge(Type.Missing);
                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 14], workSheet3.Cells[iRow - 1, 14]];
                        workRange.Merge(Type.Missing);
                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 15], workSheet3.Cells[iRow - 1, 15]];
                        workRange.Merge(Type.Missing);
                        workRange = workSheet3.Range[workSheet3.Cells[iRow, 16], workSheet3.Cells[iRow - 1, 16]];
                        workRange.Merge(Type.Missing);
                    }
                    else
                    {
                        workSheet3.Cells[iRow, 11] = r["SoLuong"].ToString();
                        workRange = workSheet3.Cells[iRow, 11];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 12] = r["MaMau"].ToString();
                        workRange = workSheet3.Cells[iRow, 12];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignTop;

                        workSheet3.Cells[iRow, 14] = r["Percent"].ToString();
                        workRange = workSheet3.Cells[iRow, 14];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 15] = r["GiaBan"].ToString();
                        workRange = workSheet3.Cells[iRow, 15];
                        workRange.NumberFormat = "#,##0.00";
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet3.Cells[iRow, 16] = r["ThanhTien"].ToString();
                        workRange = workSheet3.Cells[iRow, 16];
                        workRange.NumberFormat = "#,##0.00";
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    }
                }
                else
                {
                    mySP = r["MaSP"].ToString();
                    lstSP.Add(r["Rong"].ToString());
                    workSheet3.Cells[iRow, 7] = r["Rong"].ToString();
                    workSheet3.Cells[iRow, 8] = r["Dai"].ToString();
                    workSheet3.Cells[iRow, 9] = r["Cao"].ToString();


                    workSheet3.Cells[iRow, 1] = r["MaSP"].ToString();
                    workSheet3.Cells[iRow, 3] = r["TenDVT"].ToString();
                    workSheet3.Cells[iRow, 4] = r["SetPerPallet"].ToString();
                    workSheet3.Cells[iRow, 5] = r["W"].ToString();
                    workSheet3.Cells[iRow, 6] = r["L"].ToString();
                    workSheet3.Cells[iRow, 7] = r["H"].ToString();
                    workSheet3.Cells[iRow, 8] = r["W"].ToString();
                    workSheet3.Cells[iRow, 9] = r["L"].ToString();
                    workSheet3.Cells[iRow, 10] = r["H"].ToString();

                    workSheet3.Cells[iRow, 11] = r["SoLuong"].ToString();
                    workSheet3.Cells[iRow, 12] = r["MaMau"].ToString();
                    workSheet3.Cells[iRow, 13] = r["GiaGoc"].ToString();
                    workSheet3.Cells[iRow, 14] = r["Percent"].ToString();
                    workSheet3.Cells[iRow, 15] = r["GiaBan"].ToString();
                    workSheet3.Cells[iRow, 16] = r["ThanhTien"].ToString();
                    Microsoft.Office.Interop.Excel.Range oRange = (Range)workSheet3.Cells[iRow, 2];
                    SanPham sp = new SanPham();
                    sp.MaSP_K = r["MaSP"].ToString();
                    _db.GetObject(ref sp);
                    int countSP = Convert.ToInt16(dtPackD.Compute("count(MaSP)", string.Format("MaSP='{0}' and MaMau='{1}' ",
                                                  sp.MaSP_K, r["MaMau"].ToString())));
                    if (sp.HinhAnh != null)
                    {
                        string imagString = System.Windows.Forms.Application.StartupPath + "\\ConDau.png";
                        PublicFunction.ConvertArrayByteToFile(imagString, sp.HinhAnh);
                        float Left = (float)((double)oRange.Left);
                        float Top = (float)((double)oRange.Top);
                        workSheet3.Shapes.AddPicture(imagString, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left + 5, Top + 5, sp.ImageW, sp.ImageH);
                    }
                    oRange.RowHeight = (sp.ImageH + 10.0) / countSP;

                    oRange = (Range)workSheet3.Cells[iRow, 12];
                    Mau m = new Mau();
                    m.MaMau_K = r["MaMau"].ToString();
                    _db.GetObject(ref m);
                    if (m.Hinh != null)
                    {
                        string imagString = System.Windows.Forms.Application.StartupPath + "\\ConDau.png";
                        PublicFunction.ConvertArrayByteToFile(imagString, m.Hinh);
                        float Left = (float)((double)oRange.Left);
                        float Top = (float)((double)oRange.Top);
                        workSheet3.Shapes.AddPicture(imagString, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left + 5, Top + 15, m.W, m.H);
                        //oRange.RowHeight = (m.H + 10.0);/// countSP;
                    }
                  

                    workRange = workSheet3.Cells[iRow, 1];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet3.Cells[iRow, 2];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet3.Cells[iRow, 3];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet3.Cells[iRow, 4];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 5];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 6];
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
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 11];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange = workSheet3.Cells[iRow, 12];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignTop;
                    workRange = workSheet3.Cells[iRow, 13];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange.NumberFormat = "#,##0.00";
                    workRange = workSheet3.Cells[iRow, 15];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange.NumberFormat = "#,##0.00";
                    workRange = workSheet3.Cells[iRow, 16];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    workRange.NumberFormat = "#,##0.00";

                }

                index += 1;
                iRow += 1;
                System.Windows.Forms.Application.DoEvents();
            }
            //'Footer 
            //'Set format 
            workRange = workSheet3.Cells[3, 16];
            workRange.Formula = string.Format("=SUM(P4:P{0})", iRow - 1);

            workRange = workSheet3.Range[workSheet3.Cells[3, 1], workSheet3.Cells[iRow - 1, 16]];
            workRange.Borders.Color = ColorTranslator.ToWin32(Color.Black);
            workRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
    
            workBook.Save();
            //'Release all objects 
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.FinalReleaseComObject(workRange);
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
        private void LoadInvoice()
        {  
            grid.RowCount = 0;
            lstMaSP.Clear();
            string sql = string.Format("select * from Invoice where InvoiceNo='{0}' ",cboInvoice.Text);
            Invoice[] inv = _db.GetObjects<Invoice>(sql);
            if (inv != null)
            {              
                foreach (Invoice sp in inv)
                {
                    grid.Rows.Add();
                    int index = grid.Rows.Count - 1;
                    grid.Rows[index].Cells["SoLuong"].Value = sp.SoLuong;
                    grid.Rows[index].Cells["MaSP"].Value = sp.MaSP_K;
                    grid.Rows[index].Cells["MaMau"].Value = sp.MaMau_K;
                    grid.Rows[index].Cells["TenSP"].Value = sp.TenSP;
                    grid.Rows[index].Cells["TenDVT"].Value = sp.TenDVT;
                    grid.Rows[index].Cells["GiaBan"].Value = sp.GiaBan;
                    grid.Rows[index].Cells["ThanhTien"].Value = sp.ThanhTien;

                    grid.Rows[index].Cells["GiaGoc"].Value = sp.GiaGoc;
                    grid.Rows[index].Cells["SetPerPallet"].Value = sp.SetPerPallet;
                    grid.Rows[index].Cells["W"].Value = sp.W;
                    grid.Rows[index].Cells["L"].Value = sp.L;
                    grid.Rows[index].Cells["H"].Value = sp.H;
                    SanPhamGia spgia = new SanPhamGia();
                    spgia.MaSP_K = sp.MaSP_K;
                    spgia.MaMau_K = sp.MaMau_K;
                    lstMaSP.Add(spgia);
                }
            }
        }
        private void TongCong()
        {
            decimal tongsoluong = 0;
            decimal tongthanhtien = 0;
            foreach (DataGridViewRow r in grid.Rows)
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

        private void grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Control)
            {
                //Tim kiem hang hoa
                FrmTimSanPham frm = new FrmTimSanPham();
                frm.ShowDialog();
                if (frm._list != null)
                {
                    foreach (SanPhamGia sp in frm._list)
                    {
                        if (!lstMaSP.Contains(sp))
                        {
                            grid.Rows.Add();
                            int index = grid.Rows.Count - 1;
                            SanPham obj = new SanPham();         
                            obj.MaSP_K = sp.MaSP_K;
                            _db.GetObject(ref obj);
                            DonViTinh dvt = new DonViTinh();
                            dvt.MaDVT_K = obj.MaDVT;
                            _db.GetObject(ref dvt);
                            Mau mau = new Mau();
                            mau.MaMau_K = sp.MaMau_K;
                            _db.GetObject(ref mau);
                            grid.Rows[index].Cells["SoLuong"].Value = 1;
                            grid.Rows[index].Cells["MaSP"].Value = obj.MaSP_K;
                            grid.Rows[index].Cells["MaMau"].Value = sp.MaMau_K;
                            grid.Rows[index].Cells["TenSP"].Value = obj.TenSP;
                            grid.Rows[index].Cells["SetPerPallet"].Value = obj.SetPerPallet;
                            grid.Rows[index].Cells["W"].Value = obj.W;
                            grid.Rows[index].Cells["L"].Value = obj.L;
                            grid.Rows[index].Cells["H"].Value = obj.H;
                            grid.Rows[index].Cells["GiaGoc"].Value = obj.GiaBan;
                            grid.Rows[index].Cells["TenDVT"].Value = dvt.TenDVT;
                            grid.Rows[index].Cells["GiaBan"].Value = obj.GiaBan*mau.Price;
                            grid.Rows[index].Cells["ThanhTien"].Value = obj.GiaBan* mau.Price;
                        
                            grid.CurrentCell = grid.Rows[index].Cells["SoLuong"];
                            lstMaSP.Add(sp);
                        }
                        else
                        {
                            foreach (DataGridViewRow r in grid.Rows)
                            {
                                if (!r.IsNewRow)
                                {
                                    if (r.Cells["MaSP"].Value.ToString() == sp.MaSP_K && r.Cells["MaMau"].Value.ToString() == sp.MaMau_K)
                                    {
                                        r.Cells["SoLuong"].Value = Convert.ToInt16(r.Cells["SoLuong"].Value) + 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grid.Columns["Xoa"].Index && !grid.CurrentRow.IsNewRow)
            {
                SanPhamGia spg = new SanPhamGia();
                spg.MaMau_K = grid.CurrentRow.Cells["MaMau"].Value.ToString();
                spg.MaSP_K = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                _db.GetObject(ref spg);
                lstMaSP.Remove(spg);
                grid.Rows.Remove(grid.CurrentRow);
            }
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
                return;
            if (grid.Columns["GiaBan"].Index == e.ColumnIndex || grid.Columns["SoLuong"].Index == e.ColumnIndex)
            {
                decimal gianhap = 0;
                decimal soluong = 0;
                try
                {
                    if (grid.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString() != "")
                    {
                        gianhap = Decimal.Parse(grid.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString());
                    }
                }
                catch (Exception)
                {
                    grid.Rows[e.RowIndex].Cells["GiaBan"].Value = 0;
                }
                try
                {
                    if (grid.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString() != "")
                    {
                        soluong = Decimal.Parse(grid.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString());
                    }
                }
                catch (Exception)
                {
                    grid.Rows[e.RowIndex].Cells["SoLuong"].Value = 1;
                }

                grid.Rows[e.RowIndex].Cells["ThanhTien"].Value = soluong * gianhap;
                TongCong();
            }
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (cboInvoice.Text == "")
            {
                PublicFunction.ShowWarning("InvoiceNo không được để trống.");
                cboInvoice.Focus();
                return;
            }

            if (grid.RowCount == 0)
            {
                PublicFunction.ShowWarning("Bạn chưa nhập sản phẩm.");
                return;
            }
            if (PublicFunction.ShowQuestionSave() == DialogResult.Yes)

                try
                {
                    _db.BeginTransaction();
                    _db.ExecuteNonQuery(string.Format("delete from Invoice where invoiceNo='{0}' ", cboInvoice.Text));
                    Invoice obj = new Invoice();
                    obj.InvoiceNo_K = cboInvoice.Text;
                    obj.NgayTao = DateTime.Now;
                    foreach (DataGridViewRow r in grid.Rows)
                    {
                        obj.MaSP_K = r.Cells["MaSP"].Value.ToString();
                        obj.MaMau_K = r.Cells["MaMau"].Value.ToString();
                        obj.TenDVT = r.Cells["TenDVT"].Value.ToString();
                        obj.TenSP = r.Cells["TenSP"].Value.ToString();
                        obj.SetPerPallet = Convert.ToInt32( r.Cells["SetPerPallet"].Value);
                        obj.W = Convert.ToInt32( r.Cells["W"].Value);
                        obj.L = Convert.ToInt32( r.Cells["L"].Value);
                        obj.H = Convert.ToInt32( r.Cells["H"].Value);
                        obj.GiaBan = Convert.ToDecimal(r.Cells["GiaBan"].Value);
                        obj.GiaGoc = Convert.ToDecimal(r.Cells["GiaGoc"].Value);
                        obj.ThanhTien =Convert.ToDecimal( r.Cells["ThanhTien"].Value);
                        obj.SoLuong = Convert.ToInt32(r.Cells["SoLuong"].Value);
                        _db.Insert(obj);                       
                    }
                    _db.Commit();
                    PublicFunction.ShowSuccess();                   
                }
                catch (Exception ex)
                {
                    _db.RollBack();
                    PublicFunction.ShowError(ex, "Save", Name);
                }
        }

        private void FrmPackinglist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtPO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cboInvoice.Text != "")
                {
                    LoadInvoice();
                }
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (PublicFunction.ShowQuestionDelete() == System.Windows.Forms.DialogResult.No)
                    return;
                _db.BeginTransaction();
                _db.ExecuteNonQuery(string.Format("delete from Invoice where InvoiceNo='{0}' ", cboInvoice.Text));
                _db.Commit();
                PublicFunction.ShowSuccess();
            }catch (Exception ex)
            {
                _db.RollBack();
                PublicFunction.ShowError(ex, "Xoa", Name);
            }
        }

        private void bdn_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bttSua_Click(object sender, EventArgs e)
        {
            grid.Columns["SoLuong"].ReadOnly = !grid.Columns["SoLuong"].ReadOnly;
            grid.Columns["GiaBan"].ReadOnly = !grid.Columns["GiaBan"].ReadOnly;
            grid.Columns["W"].ReadOnly = !grid.Columns["W"].ReadOnly;
            grid.Columns["H"].ReadOnly = !grid.Columns["H"].ReadOnly;
            grid.Columns["L"].ReadOnly = !grid.Columns["L"].ReadOnly;
            grid.Columns["SetPerPallet"].ReadOnly = !grid.Columns["SetPerPallet"].ReadOnly;
        }

        private void cboInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInvoice();
        }

        private void bttTaoMoi_Click(object sender, EventArgs e)
        {
            grid.Rows.Clear();
            cboInvoice.Text = "";
            cboInvoice.Focus();
        }

        private void bttXuatExcel_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            LoadInvoiceNo();
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            LoadInvoiceNo();
        }

    }
}
