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
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne.ThietLap
{
    public partial class FrmThemKho : DockContent
    {
    
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public CommonDB.PublicFunction.FormState _frmstate = CommonDB.PublicFunction.FormState.AddNew;
        public string _id;
        private string TaoMaKho()
        {
            string makho = "";
            object max = _db.ExecuteScalar("select max(MaKho) from Kho ");
            if (max is DBNull)
            {
                makho = "01";
            }else
            {
                makho = (Convert.ToInt16(max) + 1).ToString().PadLeft(2, '0');
            }
            return makho;
        }

        private void TaoMoi()
        {
            txtMaKho.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtNguoiDaiDien.Text = "";
            txtTenKho.Text = "";
            ckoChonLamKhoBan.Checked = false;
            txtTenKho.Focus();
        }
        public FrmThemKho()
        {
            InitializeComponent();
        }

       private void FrmThemKho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
            if (e.KeyCode == Keys.S && e.Control)
            {
                bttLuu.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKho.Text.Trim()=="")
            {
                PublicFunction.ShowWarning("Tên kho không được để trống.");
                txtTenKho.Focus();
                return;
            }
            try
            {
                Kho obj = new Kho();
                obj.MaKho_K = txtMaKho.Text;
                obj.TenKho = txtTenKho.Text;
                obj.DiaChi = txtDiaChi.Text;
                obj.DienThoai = txtDienThoai.Text;
                obj.NguoiDaiDien = txtNguoiDaiDien.Text;
                if (rdoSP.Checked)
                    obj.Loai = CommonDB.PublicFunction.HangHoa.SanPham.ToString();
                else
                    obj.Loai = CommonDB.PublicFunction.HangHoa.NguyenLieu.ToString();

                obj.KhoBan = ckoChonLamKhoBan.Checked;
                if (txtMaKho.Text == "")
                {
                    obj.MaKho_K = TaoMaKho();
                    _db.Insert(obj);                    
                }else
                {
                    _db.Update(obj);
                    Close();
                }
                //PublicFunction.ShowSuccess();
                TaoMoi();
                (this.Owner as FrmDSKho).LoadAll();
            }
            catch (Exception ex)
            {
                PublicFunction.ShowError(ex, "bttLuu_Click", Name);
            }
        }

        private void FrmThemKho_Shown(object sender, EventArgs e)
        {
            if (_frmstate == PublicFunction.FormState.Edit)
            {
                txtTenKho.Focus();
                txtMaKho.Text = _id;
                Kho obj = new Kho();
                obj.MaKho_K = _id;
                _db.GetObject(ref obj);
                txtTenKho.Text = obj.TenKho;
                txtDiaChi.Text = obj.DiaChi;
                txtDienThoai.Text = obj.DienThoai;
                txtNguoiDaiDien.Text = obj.NguoiDaiDien;
                if (obj.Loai == CommonDB.PublicFunction.HangHoa.SanPham.ToString())
                {
                    rdoSP.Checked = true;
                    rdoNL.Checked = false;
                }
                else
                { 
                    rdoSP.Checked = false;
                    rdoNL.Checked = true;
                }

                ckoChonLamKhoBan.Checked = obj.KhoBan;
            }
            else
            {
                txtTenKho.Focus();
            }
        }
    }
}
