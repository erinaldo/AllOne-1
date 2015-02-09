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
using PublicUtility;

namespace AllOne
{
    public partial class FrmDangKy : Form
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmDangKy()
        {
            InitializeComponent();
        }
        private void bttDangKy_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text==CurrentSetting.Password)
            {
                License obj = new License();
                obj.ID_K = "01";
                obj.Key =PublicFunction.EncryptPassword(txtPassword.Text);
                obj.Entrydate = DateTime.Now;
                obj.Active = true;
                if (_db.ExistObject(obj))
                {
                    _db.Update(obj);
                }else
                {
                    _db.Insert(obj);
                }

                PublicFunction.ShowSuccess();
                Close();
            }else
            {
                PublicFunction.ShowWarning("Mật khẩu không đúng. Vui lòng nhập lại.");
            }
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
