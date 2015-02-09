using CommonDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne
{
    public partial class FrmHuongDan : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmHuongDan()
        {
            InitializeComponent();
        }

        private void linkHDSD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(Application.StartupPath + "\\HDSD chương trình AllOne.docx");
            }
            catch (Exception )
            {

            }
        }

        private void bttDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy frm = new FrmDangKy();
            frm.ShowDialog();

            License objLS = new License();
            objLS.ID_K = "01";
            _db.GetObject(ref objLS);
            if (objLS.Active && PublicFunction.DecryptPassword(objLS.Key) == CurrentSetting.Password)
            {
                bttDangKy.Visible = false;
                lblStatusLicense.Text = "Đã đăng ký";
            }
            else
            {
                bttDangKy.Visible = true;
                lblStatusLicense.Text = "Dùng thử";
            }
        }

        private void FrmHuongDan_Shown(object sender, EventArgs e)
        {
            int trialday = 90;
            License objLS = new License();
            objLS.ID_K = "01";
            if (_db.ExistObject(objLS))
            {
                _db.GetObject(ref objLS);
                if (objLS.Active && PublicFunction.DecryptPassword(objLS.Key) == CurrentSetting.Password)
                {
                    bttDangKy.Visible = false;
                    lblStatusLicense.Text = "Đã đăng ký";
                }
                else
                {
                    bttDangKy.Visible = true;
                    lblStatusLicense.Text = string.Format("Dùng thử {0} ngày", (trialday - (DateTime.Now - objLS.Entrydate).Days));
                    if ((trialday - (DateTime.Now - objLS.Entrydate).Days) < 0)
                    {
                        PublicFunction.ShowWarning("Đã hết hạn sử dụng. Vui lòng đăng ký để sử dụng tiếp.");
                        FrmDangKy frm = new FrmDangKy();
                        frm.ShowDialog();
                    }
                }
            }
            else
            {
                objLS.ID_K = "01";
                objLS.Key = "";
                objLS.Entrydate = DateTime.Now;
                objLS.Active = true;
                _db.Insert(objLS);

                bttDangKy.Visible = true;
                lblStatusLicense.Text = string.Format("Dùng thử {0} ngày", (trialday - (DateTime.Now - objLS.Entrydate).Days));
            }
        }
    }
}
