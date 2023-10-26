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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiLabel6_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel5_Click(object sender, EventArgs e)
        {

        }




        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }


        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }
        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }
        private Script.FormatData formatdata = new FormatData();
        private List<HangHoa> HangHoaList = new List<HangHoa>();
        private List<KhachHang> khachhanglist = new List<KhachHang>();
        private List<ChiTietHoaDon> chitiethoadonlist = new List<ChiTietHoaDon>();
        private List<Image> images = new List<Image>();
        private bool IsFix;
        public frmChucnang()
        {
            InitializeComponent();
            AddImage();
            Load_Image();
        }
        private void AddImage()
        {
            images.Add(DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources._1);
            images.Add(DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources._2);
            images.Add(DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources._3);
            images.Add(DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources._4);
            images.Add(DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources._5);
            images.Add(DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources._6);
            images.Add(DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources._7);
            images.Add(DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources._8);
            images.Add(DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources._9);
            images.Add(DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources._10);
        }
        #region code
        private void frmChucnang_Load_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadButtonStart();
            groupBox1.Visible = true;
            if (menu.Visible == true)
            {
                bntthemsp.Visible = false;
                formatdata.AddComboBoxLMH(txtlmh);
                formatdata.LoadDataGirdView(uiDataGridView2, HangHoaList);
                formatdata.LoadDataGirdView(uiDataGridView1, khachhanglist);
                formatdata.LoadDataGirdView(dgvHoaDon, chitiethoadonlist);
            }
            menu.Visible = false;

        }

        public void LoadButtonStart()
        {
            uiButton5.Enabled = false;
            uiButton2.Enabled = true;
            uiButton3.Enabled = true;
            uiButton4.Enabled = true;
        }
        private void Load_Image()
        {
            foreach (var image in images)
            {
                LoadImage(image);
            }
        }
        private void LoadImage(Image image)
        {
            Button button = new Button();
            button.Text = "";
            button.Size = new System.Drawing.Size(340, 340);
            button.Image = image;
            flowLayoutPanel1.Controls.Add(button);
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
        #region Add/Fix/Del
        public void AddSaveFix(bool IsFix)
        {
            try
            {
                DBContext dBContext = new DBContext();
                if (IsFix == true)
                {
                    HangHoa edithanghoa = dBContext.HangHoas.Find(txt_masp.Text);
                    if (edithanghoa == null)
                    {
                        MessageBox.Show("Mã Hàng Hóa Không Thể Sửa");
                        LoadButtonStart();
                    }
                    else
                    {
                        edithanghoa.MaHang = txt_masp.Text;
                        edithanghoa.TenHang = txttensp.Text;
                        edithanghoa.LoaiHang = txtlmh.Text;
                        edithanghoa.SoLuong = int.Parse(txtsl.Text);
                        edithanghoa.GiaBan = double.Parse(txtgb.Text);
                        edithanghoa.ngaycapnhap = DateTime.Parse(txtncn.Text);
                        dBContext.Entry<HangHoa>(edithanghoa).State = System.Data.Entity.EntityState.Modified;
                        dBContext.SaveChanges();
                        MessageBox.Show("Sửa Thành Công ");
                        formatdata.LoadDataGirdView(uiDataGridView2, HangHoaList);
                        LoadButtonStart();
                    }
                }
                else
                {

                    HangHoa AddFixHangHoa = dBContext.HangHoas.Find(txt_masp.Text);
                    if (AddFixHangHoa != null)
                    {
                        MessageBox.Show("Hàng Hóa Đã Tồn Tại");
                        LoadButtonStart();
                    }

                    else
                    {
                        HangHoa hanghoa = new HangHoa();
                        hanghoa.MaHang = txt_masp.Text;
                        hanghoa.TenHang = txttensp.Text;
                        hanghoa.LoaiHang = txtlmh.Text;
                        hanghoa.SoLuong = int.Parse(txtsl.Value.ToString());
                        hanghoa.GiaBan = double.Parse(txtgb.Text);
                        hanghoa.LoaiMatHang = txtlmh.Text;
                        hanghoa.ngaycapnhap = DateTime.Parse(txtncn.Text);

                        dBContext.HangHoas.Add(hanghoa);

                        dBContext.SaveChanges();
                        MessageBox.Show("Thêm Thành Công");
                        formatdata.LoadDataGirdView(uiDataGridView2, HangHoaList);
                        LoadButtonStart();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void uiButton4_Click(object sender, EventArgs e)
        {

            uiButton5.Enabled = true;
            uiButton3.Enabled = false;
            uiButton2.Enabled = false;
            uiButton4.Enabled = false;
            IsFix = false;
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            uiButton5.Enabled = true;
            uiButton4.Enabled = false;
            uiButton2.Enabled = false;
            IsFix = true;
        }
        private void Delete_HangHoa()
        {
            DBContext dBContext = new DBContext();
            var hanghoaDelete = dBContext.HangHoas.Find(txt_masp.Text);
            if (hanghoaDelete != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dBContext.HangHoas.Remove(hanghoaDelete);
                    dBContext.SaveChanges();
                    formatdata.LoadDataGirdView(uiDataGridView2, HangHoaList);
                    LoadButtonStart();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Sinh Viên");
            }
        }
        private void uiButton2_Click(object sender, EventArgs e)
        {
            uiButton5.Enabled = true;
            uiButton4.Enabled = false;
            uiButton3.Enabled = false;
            Delete_HangHoa();
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            AddSaveFix(IsFix);
        }
        #endregion
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
        private void bntthemsp_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Button";
            button.Size = new System.Drawing.Size(300, 236);
            // Đặt hình ảnh cho Button từ tệp 
            button.Image = DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources._1;
            flowLayoutPanel1.Controls.Add(button);
        }
        private void bnt_search_Click(object sender, EventArgs e)
        {
            Search_SanPham();
        }
        //public void Search_SanPham()
        //{
        //    try
        //    {
        //        string masp_search = txt_search.Text;
        //        var listsearch = formatdata.GetDataFormDB<HangHoa>().Where(s=>s.MaHang.Contains(masp_search,StringComparison.OrdinalIgnoreCase).ToList());
        //    }catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        public void Search_SanPham()
        {
            try
            {
                string masp_search = txt_search.Text;
                var listsearch = formatdata.GetDataFormDB<HangHoa>()
                    .Where(s => s.MaHang.IndexOf(masp_search, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList(); // Materialize the results

                // You can now use 'listsearch' to work with the filtered list of HangHoa items
                uiDataGridView2.DataSource = null;
                uiDataGridView2.DataSource = listsearch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
        private void btnhelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtrogiup frmtg = new frmtrogiup();
            frmtg.WindowState = FormWindowState.Maximized;
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

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uiButton6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {




















        }
    }
}
