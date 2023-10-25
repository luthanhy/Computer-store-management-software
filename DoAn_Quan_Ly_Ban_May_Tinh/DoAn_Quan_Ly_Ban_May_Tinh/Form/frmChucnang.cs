using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Quan_Ly_Ban_May_Tinh
{
    public partial class frmChucnang : Form
    {
        public frmChucnang()
        {
            InitializeComponent();
            Scroll_Bar();
        }

        private void tabProduct_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiLabel6_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel5_Click(object sender, EventArgs e)
        {

        }

        private void uiImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }

        private void uiImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void uiImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void uiImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void uiImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiTabControlMenu1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel14_Click(object sender, EventArgs e)
        {

        }

        private void uiDatetimePicker1_ValueChanged(object sender, DateTime value)
        {

        }

        private void uiLabel13_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel12_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel11_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel10_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel9_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel8_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {

        }

        private void uiButton4_Click(object sender, EventArgs e)
        {

        }

        private void uiDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        #region code
        private void frmChucnang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void Scroll_Bar()
            {
            //uiHorScrollBarEx1.Value = uiFlowLayoutPanel1.VerticalScroll.Value;
            // uiHorScrollBarEx1.MinimumSize = uiFlowLayoutPanel1.VerticalScroll.Minimum;
           // uiFlowLayoutPanel1.ControlAdded += uiFlowLayoutPanel1_ControlAdded;
            }

        private void uiFlowLayoutPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

            //uiHorScrollBarEx1.Maximum = uiFlowLayoutPanel1.VerticalScroll.Maximum;
        }

        private void uiHorScrollBarEx1_Click(object sender, EventArgs e)
        {

        }
        private void bntthemsp_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Button";
            button.Size = new System.Drawing.Size(321, 236);

            TextBox textBox1 = new TextBox();
            textBox1.Text = "Name";
            textBox1.Size = new System.Drawing.Size(225, 23);

            TextBox textBox2 = new TextBox();
            textBox2.Text = "Price";
            textBox2.Size = new System.Drawing.Size(155, 23);

            ////uiFlowLayoutPanel1.Controls.Add(button);
            ////uiFlowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            ////uiFlowLayoutPanel1.Controls.Add(textBox1);
            ////uiFlowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.Controls.Add(button);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(textBox2);

        }
  
        #endregion
        private void uiPanel2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiLabel4_Click_1(object sender, EventArgs e)
        {

        }

        private void src_home_Click(object sender, EventArgs e)
        {

        }

    }
}
