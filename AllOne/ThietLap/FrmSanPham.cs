using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonDB;
using System.Globalization;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne.ThietLap
{
    public partial class FrmSanPham : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public void ExportExcel()
        {
            CultureInfo oldCI = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            //try 
            //    {
            //if (! Directory.Exists("") )
            //    Directory.CreateDirectory("") ;

            //Copy template 
            //UpLoadFile(_fileSource, _fileTemp, True) 
            //Variance 
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Workbook workBook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet;
            Range workRange;
            //'Open file 
            //if (File.Exists("")) 
            //{
            //    workBook = app.Workbooks.Open("_fileTemp", Type.Missing, 
            //            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, 
            //            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, 
            //            Type.Missing, Type.Missing, Type.Missing) ;
            //}
            //else 
            //{
            workBook = app.Workbooks.Add(Type.Missing);
            //}

            workSheet = workBook.Sheets[1] as Worksheet;
            workSheet.Name = "Price";
            app.Visible = true;
            app.DisplayAlerts = false;
            //'Write data 
            //'Header 
            // workSheet.Cells[3, 2] = "";
            //workSheet.Cells(5, 2) = "ISSUED : " & dtpMonday.Value.ToString("yyyy-MM-dd HH:mm") 
            //'Detail 
            int iRow = 6;
            int stt = 1;
            System.Data.DataTable dtExport = _db.ExecuteStoreProcedureTB("sp_LoadCTSanPham");
            workSheet.Cells[5, 1] = "No.";
            workSheet.Cells[5, 2] = "Code";
            workSheet.Cells[5, 3] = "Picture and name";
            workSheet.Cells[5, 4] = "Unit";
            workSheet.Cells[5, 5] = "W";
            workSheet.Cells[5, 6] = "L";
            workSheet.Cells[5, 7] = "H";
            workSheet.Cells[5, 8] = "Kg";
            workSheet.Cells[5, 9] = "Giá nhập";
            workSheet.Cells[5, 10] = "Giá bán";
            workRange = workSheet.Cells[5, 1];
            workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            workRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            workRange = workSheet.Cells[5, 2];
            workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            workRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            workRange = workSheet.Cells[5, 3];
            workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            workRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            workRange = workSheet.Cells[5, 4];
            workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            workRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            workRange = workSheet.Cells[5, 5];
            workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            workRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            workRange = workSheet.Cells[5, 6];
            workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            workRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            workRange = workSheet.Cells[5, 7];
            workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            workRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            workRange = workSheet.Cells[5, 8];
            workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            workRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            workRange = workSheet.Cells[5, 9];
            workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            workRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            workRange = workSheet.Cells[5, 10];
            workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
            workRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
            for (int i = 0; i <= dtExport.Rows.Count - 1; i = i + 1)
            {
                //'Merge cells 
                if (i > 0)
                {
                    //'MaSP 
                    if (dtExport.Rows[i]["MaSP"].ToString() == dtExport.Rows[i - 1]["MaSP"].ToString())
                    {
                        workRange = workSheet.Range[workSheet.Cells[iRow, 1], workSheet.Cells[iRow - 1, 1]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet.Range[workSheet.Cells[iRow, 2], workSheet.Cells[iRow - 1, 2]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workRange = workSheet.Range[workSheet.Cells[iRow, 3], workSheet.Cells[iRow - 1, 3]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                        Microsoft.Office.Interop.Excel.Range oRange1 = (Range)workSheet.Cells[iRow - 1, 3];
                        Microsoft.Office.Interop.Excel.Range oRange2 = (Range)workSheet.Cells[iRow, 3];
                        oRange2.RowHeight = oRange1.RowHeight;
                    }
                    else
                    {
                        stt += 1;
                        workSheet.Cells[iRow, 1] = stt;
                        workRange = workSheet.Cells[iRow, 1];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        workSheet.Cells[iRow, 2] = dtExport.Rows[i]["MaSP"];
                        workRange = workSheet.Cells[iRow, 2];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                        Microsoft.Office.Interop.Excel.Range oRange = (Range)workSheet.Cells[iRow, 3];
                        SanPham sp = new SanPham();
                        sp.MaSP_K = dtExport.Rows[i]["MaSP"].ToString();
                        _db.GetObject(ref sp);
                        System.Data.DataTable dtCT = _db.FillDataTable(string.Format("select MaSP from CTSanPham where MaSP='{0}' ", sp.MaSP_K));
                        if (sp.HinhAnh != null)
                        {
                            string imagString = System.Windows.Forms.Application.StartupPath + "\\ConDau.png";
                            PublicFunction.ConvertArrayByteToFile(imagString, sp.HinhAnh);
                            float Left = (float)((double)oRange.Left);
                            float Top = (float)((double)oRange.Top);
                            workSheet.Shapes.AddPicture(imagString, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left+5, Top+5,sp.ImageW, sp.ImageH);
                        }

                        oRange.RowHeight = (sp.ImageH + 20.0) / dtCT.Rows.Count;
                        //oRange.ColumnWidth = 50;
                    }
                    //TenSP 
                    if (dtExport.Rows[i]["TenSP"].ToString() == dtExport.Rows[i - 1]["TenSP"].ToString())
                    {
                        workRange = workSheet.Range[workSheet.Cells[iRow, 3], workSheet.Cells[iRow - 1, 3]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                    }
                    else
                    {
                        workSheet.Cells[iRow, 3] = dtExport.Rows[i]["TenSP"];
                        workRange = workSheet.Cells[iRow, 3];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;
                    }
                    // MaDVT 
                    if (dtExport.Rows[i]["TenDVT"].ToString() == dtExport.Rows[i - 1]["TenDVT"].ToString() &&
                        dtExport.Rows[i]["MaSP"].ToString() == dtExport.Rows[i - 1]["MaSP"].ToString())
                    {
                        workRange = workSheet.Range[workSheet.Cells[iRow, 4], workSheet.Cells[iRow - 1, 4]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }
                    else
                    {
                        workSheet.Cells[iRow, 4] = dtExport.Rows[i]["TenDVT"];
                        workRange = workSheet.Cells[iRow, 4];
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }

                    if (dtExport.Rows[i]["GiaNhap"].ToString() == dtExport.Rows[i - 1]["GiaNhap"].ToString())
                    {
                        workRange = workSheet.Range[workSheet.Cells[iRow, 9], workSheet.Cells[iRow - 1, 9]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }
                    else { workSheet.Cells[iRow, 9] = dtExport.Rows[i]["GiaNhap"]; }

                    if (dtExport.Rows[i]["GiaBan"].ToString() == dtExport.Rows[i - 1]["GiaBan"].ToString())
                    {
                        workRange = workSheet.Range[workSheet.Cells[iRow, 10], workSheet.Cells[iRow - 1, 10]];
                        workRange.Merge(Type.Missing);
                        workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                    }
                    else { workSheet.Cells[iRow, 10] = dtExport.Rows[i]["GiaBan"]; }
                }
                else
                {
                    workSheet.Cells[iRow, 1] = stt;
                    workSheet.Cells[iRow, 2] = dtExport.Rows[i]["MaSP"];
                    workSheet.Cells[iRow, 3] = dtExport.Rows[i]["TenSP"];
                    workSheet.Cells[iRow, 4] = dtExport.Rows[i]["MaDVT"];
                    workSheet.Cells[iRow, 9] = dtExport.Rows[i]["GiaNhap"];
                    workSheet.Cells[iRow, 10] = dtExport.Rows[i]["GiaBan"];

                    workRange = workSheet.Cells[iRow, 1];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet.Cells[iRow, 2];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet.Cells[iRow, 3];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;

                    workRange = workSheet.Cells[iRow, 4];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    workRange = workSheet.Cells[iRow, 9];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignBottom;

                    workRange = workSheet.Cells[iRow, 10];
                    workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    Microsoft.Office.Interop.Excel.Range oRange = (Range)workSheet.Cells[iRow, 3];
                    SanPham sp = new SanPham();
                    sp.MaSP_K = dtExport.Rows[i]["MaSP"].ToString();
                    _db.GetObject(ref sp);
                    System.Data.DataTable dtCT = _db.FillDataTable(string.Format("select MaSP from CTSanPham where MaSP='{0}' ", sp.MaSP_K));
                    if (sp.HinhAnh != null)
                    {
                        string imagString = System.Windows.Forms.Application.StartupPath + "\\ConDau.png";
                        PublicFunction.ConvertArrayByteToFile(imagString, sp.HinhAnh);
                        float Left = (float)((double)oRange.Left);
                        float Top = (float)((double)oRange.Top);
                        workSheet.Shapes.AddPicture(imagString, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left+5, Top+5, sp.ImageW, sp.ImageH);
                    }

                    
                    oRange.RowHeight = (sp.ImageH + 20.0) / dtCT.Rows.Count;
                    oRange.ColumnWidth = 30;

                }
                // You have to get original bitmap path here

                //workSheet.Cells[iRow, 2] = dtExport.Rows[i]["MaSP"];
                //workSheet.Cells[iRow, 3] = dtExport.Rows[i]["TenSP"];
                //workSheet.Cells[iRow, 4] = dtExport.Rows[i]["MaDVT"];
                workSheet.Cells[iRow, 5] = dtExport.Rows[i]["Rong"];
                workSheet.Cells[iRow, 6] = dtExport.Rows[i]["Dai"];
                workSheet.Cells[iRow, 7] = dtExport.Rows[i]["Cao"];
                workSheet.Cells[iRow, 8] = dtExport.Rows[i]["CanNang"];
                workSheet.Cells[iRow, 9] = dtExport.Rows[i]["GiaNhap"];
                workSheet.Cells[iRow, 10] = dtExport.Rows[i]["GiaBan"];

                workRange = workSheet.Cells[iRow, 5];
                workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                workRange = workSheet.Cells[iRow, 6];
                workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                workRange = workSheet.Cells[iRow, 7];
                workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                workRange = workSheet.Cells[iRow, 8];
                workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                workRange = workSheet.Cells[iRow, 9];
                workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                workRange.NumberFormat = "#,##0.00";
                workRange = workSheet.Cells[iRow, 10];
                workRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                workRange.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                workRange.NumberFormat = "#,##0.00";

                iRow += 1;
                System.Windows.Forms.Application.DoEvents();
            }
            // 'Footer 
            // 'Set format 
            workRange = workSheet.Range[workSheet.Cells[5, 1], workSheet.Cells[iRow - 1, 10]];
            workRange.Borders.Color = ColorTranslator.ToWin32(Color.Black);
            workRange.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;
            //'Save file 

            workBook.Save();
            //'Release all objects 
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.FinalReleaseComObject(workRange);
            Marshal.FinalReleaseComObject(workSheet);
            Marshal.FinalReleaseComObject(workBook);
            Marshal.FinalReleaseComObject(app);
            //    }
            //catch ( Exception ex)
            //{
            //    PublicFunction.ShowError(ex, "ExportExcel", Name);
            //}

            Thread.CurrentThread.CurrentCulture = oldCI;

        }
        private void LoadDataNhomSP()
        {
            string sql = string.Format("  " +
                                       " select MaNhom,TenNhom from NhomSanPham order by TenNhom ");
            cboNhomSP.ComboBox.DataSource = _db.FillDataTable(sql);
            cboNhomSP.ComboBox.DisplayMember = "TenNhom";
            cboNhomSP.ComboBox.ValueMember = "MaNhom";
            cboNhomSP.SelectedIndex = 0;

            string sqlNCC = string.Format("  select MaNCC,TenNCC from NhaCungCap order by TenNCC ");
            cboNCC.ComboBox.DataSource = _db.FillDataTable(sqlNCC);
            cboNCC.ComboBox.DisplayMember = "TenNCC";
            cboNCC.ComboBox.ValueMember = "MaNCC";
        }
        public void LoadAll()
        {
            string sql = string.Format("sp_LoadSanPham");
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _db.ExecuteStoreProcedureTB(sql);
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
        }
        private void SuaSanPham()
        {
            FrmThemSanPham frm = new FrmThemSanPham();
            frm.Owner = this;
            frm._frmstate = PublicFunction.FormState.Edit;
            frm._id = grid.CurrentRow.Cells["MaSP"].Value.ToString();
            frm.ShowDialog();
            LoadAll();
        }
        private void XoaSanPham()
        {
            if (PublicFunction.ShowQuestionDelete() == System.Windows.Forms.DialogResult.Yes)
            {
                SanPham obj = new SanPham();
                obj.MaSP_K = grid.CurrentRow.Cells["MaSP"].Value.ToString();
                _db.Delete(obj);
                LoadAll();
            }
        }
        public FrmSanPham()
        {
            InitializeComponent();
        }

        private void bttThemMoi_Click(object sender, EventArgs e)
        {
            FrmThemSanPham frm = new FrmThemSanPham();
            frm.Owner = this;
            frm.ShowDialog();
            LoadAll();
        }

        private void bttXuatExcel_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == grid.Columns["Xoa"].Index)
                {
                    XoaSanPham();
                }
                if (e.ColumnIndex == grid.Columns["Sua"].Index)
                {
                    SuaSanPham();
                }
            }
        }

        private void FrmSanPham_Shown(object sender, EventArgs e)
        {
            LoadAll();
            LoadDataNhomSP();
        }

          private void cboNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNhomSP.ComboBox.ValueMember != "" && cboNhomSP.ComboBox.DisplayMember != "")
            {
                if (cboNhomSP.Text == "<---Tất cả--->" || cboNhomSP.Text == "")
                {
                    bdn.BindingSource.Filter = "";
                }
                else
                {
                    bdn.BindingSource.Filter = string.Format(" TenNhom='{0}' ", cboNhomSP.Text);
                }
            }
        }

         
          private void txtMaSP_TextChanged(object sender, EventArgs e)
          {
              if (txtMaSP.Text == "Mã sản phẩm")
                  return;
              if (txtMaSP.Text == "")
              {
                  bdn.BindingSource.Filter = "";
              }
              else
              {
                  bdn.BindingSource.Filter = string.Format(" MaSP like '%{0}%' ", txtMaSP.Text);
              }
          }

          private void txtTenSP_TextChanged(object sender, EventArgs e)
          {
              if (txtTenSP.Text == "Tên sản phẩm")
                  return;
              if ( txtTenSP.Text == "")
              {
                  bdn.BindingSource.Filter = "";
              }
              else
              {
                  bdn.BindingSource.Filter = string.Format(" TenSP like '%{0}%' ", txtTenSP.Text);
              }
          }

          private void txtMaSP_Leave(object sender, EventArgs e)
          {
              if (txtMaSP.Text == "")
              {
                  txtMaSP.ForeColor = Color.Gray;
                  txtMaSP.Text = "Mã sản phẩm";
              }
          }

          private void txtMaSP_Enter(object sender, EventArgs e)
          {
              if (txtMaSP.Text == "Mã sản phẩm")
              {
                  txtMaSP.ForeColor = Color.Black;
                  txtMaSP.Text = "";
              }
          }

          private void txtTenSP_Enter(object sender, EventArgs e)
          {
              if (txtTenSP.Text == "Tên sản phẩm")
              {
                  txtTenSP.ForeColor = Color.Black;
                  txtTenSP.Text = "";
              }
          }

          private void txtTenSP_Leave(object sender, EventArgs e)
          {
              if (txtTenSP.Text == "")
              {
                  txtTenSP.ForeColor = Color.Gray;
                  txtTenSP.Text = "Tên sản phẩm";
              }
          }

          private void mnuSua_Click(object sender, EventArgs e)
          {
              if (grid.CurrentRow !=null)
              {
                  SuaSanPham();
              }
          }

          private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
          {
              if (grid.CurrentRow != null)
              {
                  XoaSanPham();
              }
          }

          private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
          {
              if (cboNCC.ComboBox.ValueMember != "" && cboNCC.ComboBox.DisplayMember != "")
              {
                  if (cboNCC.Text == "<---Tất cả--->" || cboNCC.Text == "")
                  {
                      bdn.BindingSource.Filter = "";
                  }
                  else
                  {
                      bdn.BindingSource.Filter = string.Format(" TenNCC='{0}' ", cboNCC.Text);
                  }
              }
          }
    }
}
