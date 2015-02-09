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
    public partial class FrmCauHinhKetNoi : Form
    {
        public FrmCauHinhKetNoi()
        {
            InitializeComponent();
        }
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
        private void bttThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttLuu_Click(object sender, EventArgs e)
        {
            SetConnectionStringByName("ConnectStringAllOne", txtKetNoi.Text);
        }

        private void FrmCauHinhKetNoi_Shown(object sender, EventArgs e)
        {
            txtKetNoi.Text = GetConnectionStringByName("ConnectStringAllOne");
        }
    }
}
