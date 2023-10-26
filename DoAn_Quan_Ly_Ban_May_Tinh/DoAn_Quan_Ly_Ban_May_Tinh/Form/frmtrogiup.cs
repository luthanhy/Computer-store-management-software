using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DoAn_Quan_Ly_Ban_May_Tinh
{
    public partial class frmtrogiup : Form
    {
        public frmtrogiup()
        {
            InitializeComponent();
        }

        private void frmtrogiup_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = false;
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           groupBox2.Visible = false;
            groupBox1.Visible = true;
        }

        private void liênHệHỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
