using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllOne
{
    public partial class FrmPrint : Form
    {
        public DataTable  _dtTable ;
        public FrmPrint()
        {
            InitializeComponent();
        }
        private void InPhieuNhap()
        {
        ////    report.LocalReport.ReportPath = "";
        ////    report.LocalReport.DataSources = "";
        ////        Dim dtpo As DataTable = db.FillDataTable(sql)
        ////dtpo.TableName = "SOM"
        ////dtpo.WriteXmlSchema("SOM.xsd")
        // FrmPrint frm=new FrmPrint();
        //frm.rptViewer.LocalReport.ReportPath = "Reports\rptSOM.rdlc";

        //frm.rptViewer.LocalReport.DataSources.Add(New ReportDataSource("SOM", dtpo))
        //frm.rptViewer.LocalReport.SetParameters(New ReportParameter("UserName", CurrentUser.FullName))
        //frm.rptViewer.RefreshReport();
        //frm.Show();
        }
        private void FrmPrint_Load(object sender, EventArgs e)
        {

            this.rptViewer.RefreshReport();
        }

        private void FrmPrint_Shown(object sender, EventArgs e)
        {

        }
    }
}
