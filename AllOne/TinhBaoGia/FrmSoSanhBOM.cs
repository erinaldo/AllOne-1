using CommonDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace AllOne
{
    public partial class FrmSoSanhBOM : DockContent
    {
        DBSql _db = new DBSql(PublicUtility.PublicConst.EnumServers.NDV_SQL_ERP_NDV);
        public FrmSoSanhBOM()
        {
            InitializeComponent();
        }

        private void LoadSoSanhBom()
        {
            SqlParameter[] para = new SqlParameter[1];
            para[0] = new SqlParameter("@Thang", dtpThang.Value.ToString("yyyyMM"));
            DataTable _dtBaoGia = _db.ExecuteStoreProcedureTB("sp_LoadSoSanhBOM", para);
            BindingSource bdsource = new BindingSource();
            bdsource.DataSource = _dtBaoGia;
            bdn.BindingSource = bdsource;
            grid.DataSource = bdsource;
            TongCong();

        }
        private void TongCong()
        {
            decimal SLThucTe = 0;
            decimal SLDinhMuc = 0;
            decimal SaiLech = 0;
            foreach (DataGridViewRow r in grid.Rows)
            {
                if (!r.IsNewRow && r.Cells["SLThucTe"].Value != null)
                {
                    if (r.Cells["SLThucTe"].Value.ToString() != "")
                        SLThucTe += Convert.ToDecimal(r.Cells["SLThucTe"].Value);
                }
                if (!r.IsNewRow && r.Cells["SLDinhMuc"].Value != null)
                {
                    if (r.Cells["SLDinhMuc"].Value.ToString() != "")
                        SLDinhMuc += Convert.ToDecimal(r.Cells["SLDinhMuc"].Value);
                }
                if (!r.IsNewRow && r.Cells["SaiLech"].Value != null)
                {
                    if (r.Cells["SaiLech"].Value.ToString() != "")
                        SaiLech += Convert.ToDecimal(r.Cells["SaiLech"].Value);
                }
            }
            txtSaiLech.Text = SaiLech.ToString("N2");
            txtSLDinhMuc.Text = SLDinhMuc.ToString("N2");
            txtSLThucTe.Text = SLThucTe.ToString("N2");
        }

        private void txtMaNL_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource != null)
            {
                if (txtMaNL.Text == "")
                {
                    bdn.BindingSource.Filter = "";
                }
                else
                {
                    bdn.BindingSource.Filter = string.Format("MaNL like '%{0}%' ", txtMaNL.Text);
                }
            }
        }

        private void txtTenNL_TextChanged(object sender, EventArgs e)
        {
            if (bdn.BindingSource != null)
            {
                if (txtTenNL.Text == "")
                {
                    bdn.BindingSource.Filter = "";
                }
                else
                {
                    bdn.BindingSource.Filter = string.Format("TenNL like '%{0}%' ", txtTenNL.Text);
                }
            }
        }

        private void bttTimKiem_Click(object sender, EventArgs e)
        {
            LoadSoSanhBom();
        }

        private void FrmSoSanhBOM_Shown(object sender, EventArgs e)
        {
            LoadSoSanhBom();
        }
    }
}
