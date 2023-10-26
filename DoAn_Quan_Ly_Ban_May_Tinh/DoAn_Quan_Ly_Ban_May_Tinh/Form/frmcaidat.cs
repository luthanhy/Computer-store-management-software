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
    public partial class frmcaidat : Form
    {
        frm_dangnhap frm_Dangnhap;
        private frm_dangnhap form1;
        public frmcaidat()
        {
            InitializeComponent();
            frm_Dangnhap = new frm_dangnhap();
        }

        public frmcaidat(frm_dangnhap form1)
        {
            InitializeComponent();
            this.frm_Dangnhap = form1;
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            frm_Dangnhap.ShowDialog();
            this.Show();
            
            form1.xoatextbox();
            
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
