using CommonDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllOne
{
    public partial class FrmDangNhap : Form
    {
       
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        private void KetNoiServer()
        {
            string sqlconnect = GetConnectionStringByName("ConnectStringAllOne");
            PublicUtility.PublicConst.SQL_DB_ERP_NDV = sqlconnect;
        }

        private void ckoHienThiPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckoHienThiPass.Checked)
                txtMatKhau.UseSystemPasswordChar = false;
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }

        private void bttDangNhap_Click(object sender, EventArgs e)
        {
            DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
            string sql = string.Format("select * from TaiKhoan where MatKhau='{0}' and TenDangNhap='{1}' ",
                                     txtMatKhau.Text, txtTenDangNhap.Text);
            DataTable dt = _db.FillDataTable(sql);
            if (dt.Rows.Count== 1)
            {
                PublicUtility.CurrentUser.UserName = dt.Rows[0]["TenDangNhap"].ToString();
                PublicUtility.CurrentUser.FullName = dt.Rows[0]["TenNV"].ToString();
                PublicUtility.CurrentUser.UserID = dt.Rows[0]["MaNV"].ToString();
                TaiKhoan obj = new TaiKhoan();
                obj.MaNV_K = PublicUtility.CurrentUser.UserID;
                _db.GetObject(ref obj);
                CurrentSetting.User = obj;
                FrmMain frm = new FrmMain();
                frm.Show();
                Visible = false;

            }
            else
            {
                PublicFunction.ShowWarning("Bạn nhập sai mật khẩu hoặc tên đăng nhập.");
                txtTenDangNhap.Focus();
            }

        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void FrmDangNhap_Shown(object sender, EventArgs e)
        {
            //txtMatKhau.Text = "admin";
            //txtTenDangNhap.Text = "admin";

            KetNoiServer();
            txtTenDangNhap.Focus();
            //bttDangNhap.PerformClick();

        }
        // Retrieves a connection string by name. 
        // Returns null if the name is not found. 
        static string GetConnectionStringByName(string name)
        {
            // Assume failure. 
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string. 
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
        static void SetConnectionStringByName(string name, string value)
        {
            // Assume failure. 

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string. 
            if (settings != null)
                settings.ConnectionString = value;

        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                bttDangNhap.PerformClick();
            }
        }

        private void linkCauHinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCauHinhKetNoi frm = new FrmCauHinhKetNoi();
            frm.ShowDialog();
            KetNoiServer();
        }
    }
}
