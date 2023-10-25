using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Quan_Ly_Ban_May_Tinh
{
    public partial class frnreport : Form
    {
        public frnreport()
        {
            InitializeComponent();
        }

        private void frnreport_Load(object sender, EventArgs e)
        {
            try
            {
                this.reportViewer1.RefreshReport();
                reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_Quan_Ly_Ban_May_Tinh.Report1.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = "Report1.rdlc";
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();

            }
            catch(Exception ex) { 
            }
        }
    }
}
