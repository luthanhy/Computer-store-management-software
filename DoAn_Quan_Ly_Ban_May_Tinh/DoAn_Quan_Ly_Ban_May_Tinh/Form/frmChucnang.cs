using DoAn_Quan_Ly_Ban_May_Tinh.Script;
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


        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }


        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void uiImageButton4_Click(object sender, EventArgs e)
        {

        }


        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

       
        private void uiLabel1_Click(object sender, EventArgs e)
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

        private Script.FormatData formatdata = new FormatData();
        private List<HangHoa> HangHoaList = new List<HangHoa>();
        private List<KhachHang> khachhanglist = new List<KhachHang>();
        private List<ChiTietHoaDon> chitiethoadonlist = new List<ChiTietHoaDon>();
        #region code
        private void frmChucnang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            groupBox1.Visible = true;
            if(menu.Visible == true)
            {
                formatdata.AddComboBoxLMH(txtlmh);
                formatdata.LoadDataGirdView(uiDataGridView2, HangHoaList);
                formatdata.LoadDataGirdView(uiDataGridView1, khachhanglist);
                formatdata.LoadDataGirdView(dgvHoaDon, chitiethoadonlist);
            }
            menu.Visible = false;
        }

        private void uiDataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var index = uiDataGridView2.CurrentCell.RowIndex;
            if (index >= 0)
            {
                var selectrow = uiDataGridView2.Rows[index];
                txt_masp.Text = selectrow.Cells[0].Value.ToString();
                txttensp.Text = selectrow.Cells[1].Value.ToString();
                txtsl.Value = decimal.Parse(selectrow.Cells[3].Value.ToString());
                txtgb.Text = selectrow.Cells[4].Value.ToString();
                txtlmh.Text = selectrow.Cells[5].Value.ToString();
                txtncn.Text = selectrow.Cells[6].Value.ToString();
            }
        }
       
        public void AddSaveFix(bool IsFix, bool IsAdd)
        {
            try
            {
                DBContext dBContext = new DBContext();
                if (IsFix == true)
                {

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uiImageButton5_Click(object sender, EventArgs e)
        {

            menu.Visible = true;
            menu.SelectTab(4);

        }
        private void uiImageButton3_Click(object sender, EventArgs e)
        {

            menu.Visible = true;
            menu.SelectTab(3);

        }
        private void uiImageButton6_Click(object sender, EventArgs e)
        {
            menu.Visible = false;
            groupBox1.Visible = true;
        }
        private void uiImageButton2_Click(object sender, EventArgs e)
        {
            menu.Visible = true;
            menu.SelectTab(1);
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {

            menu.Visible = true;
            menu.SelectTab(0);
            groupBox1.Visible = false;
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
            button.Size = new System.Drawing.Size(300, 236);
            // Đặt hình ảnh cho Button từ tệp ảnh
            button.Image = Image.FromFile(@"D:\QLDA\DoAn_Quan_Ly_Ban_May_Tinh\DoAn_Quan_Ly_Ban_May_Tinh\Resources\mac.png");
            flowLayoutPanel1.Controls.Add(button);
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

        private void btnhelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtrogiup frmtg= new frmtrogiup();
            frmtg.WindowState  = FormWindowState.Maximized;
            frmtg.ShowDialog();
            this.Show();
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcaidat frmtg = new frmcaidat();
            frmtg.WindowState = FormWindowState.Maximized;
            frmtg.ShowDialog();
            this.Show();
        }

        private void uiDataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHoaDon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
