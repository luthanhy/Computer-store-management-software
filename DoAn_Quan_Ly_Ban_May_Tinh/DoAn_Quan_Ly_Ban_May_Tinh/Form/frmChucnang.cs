using DoAn_Quan_Ly_Ban_May_Tinh.Script;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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

        #region Variable
        private Script.FormatData formatdata = new FormatData();
        private List<HangHoa> HangHoaList = new List<HangHoa>();
        private List<KhachHang> khachhanglist = new List<KhachHang>();
        private List<ChiTietHoaDon> chitiethoadonlist = new List<ChiTietHoaDon>();
        private List<HoaDon> hoadon = new List<HoaDon>();
        private List<PhieuXuatHang> phieuXuatHangs = new List<PhieuXuatHang> ();
        private List<Image> images = new List<Image>();
        private bool IsFix;
        #endregion
        #region Form
        public frmChucnang()
        {
            InitializeComponent();
            AddImage();
            Load_Image();
        }
        
       
        private void frmChucnang_Load_2(object sender, EventArgs e)
        {
            groupBox1.Text = "Gian Hàng";
            ReportProcess();
            this.WindowState = FormWindowState.Maximized;
            LoadButtonStart();
            groupBox1.Visible = true;
            if (menu.Visible == true)
            {
                bntthemsp.Visible = false;
                formatdata.AddComboBoxLMH(txtlmh);
                ReloadDataGird();


            }
            menu.Visible = false;
            
            }
        private void btnhelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtrogiup frmtg = new frmtrogiup();
            frmtg.WindowState = FormWindowState.Maximized;
            frmtg.ShowDialog();
            this.Show();
        }
        public void ReloadDataGird()
        {

            formatdata.LoadDataGirdView(uiDataGridView2, HangHoaList);
            formatdata.LoadDataGirdView(dgv_ttkh, khachhanglist);
            formatdata.LoadDataGirdView(dgvpxhd, phieuXuatHangs);
            formatdata.LoadDataGirdView(dgv_tracuuhoadon, hoadon);
            formatdata.LoadDataGirdView(dgv_hoadon, chitiethoadonlist);
        }
        private void btnsetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcaidat frmtg = new frmcaidat();
            frmtg.WindowState = FormWindowState.Maximized;
            frmtg.ShowDialog();
            this.Show();
        }
#endregion
        #region Product
        #region GetData
        public void ReportProcess()
        {
            //DataSet dataSet = new DataSet();
            ReportDataSource reportDataSource = new ReportDataSource("PhieuHoaDon", formatdata.GetDataFormDB<PhieuXuatHang>());
            ReportDataSource reportDataSource2 = new ReportDataSource("KhachHang", formatdata.GetDataFormDB<KhachHang>());

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\thanh\OneDrive\Máy tính\DoAn2\DoAn_Quan_Ly_Ban_May_Tinh\DoAn_Quan_Ly_Ban_May_Tinh\DoAn_Quan_Ly_Ban_May_Tinh\frmreport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.RefreshReport();

        }
        public void Reset()
        {
            bntthemsp.Visible = false;
            formatdata.AddComboBoxLMH(txtlmh);
            formatdata.LoadDataGirdView(uiDataGridView2, HangHoaList);
            formatdata.LoadDataGirdView(dgv_ttkh, khachhanglist);
            formatdata.LoadDataGirdView(dgvpxhd, chitiethoadonlist);
        }
        public void LoadButtonStart()
        {
            bnt_luupkh.Enabled = false;
            bnt_thempkh.Enabled = true;
            bnt_suapkh.Enabled = true;
            bnt_xoaphd.Enabled = true;
            bnt_luukh.Enabled = false;
            bntthemsp.Enabled = true;
            bnt_suakh.Enabled = true;
            bnt_xoakh.Enabled = true;
            uiButton5.Enabled = false;
            uiButton2.Enabled = true;
            uiButton3.Enabled = true;
            uiButton4.Enabled = true;
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
                txtsl.Value = decimal.Parse(selectrow.Cells[2].Value.ToString());
                txtgb.Text = selectrow.Cells[3].Value.ToString();
                txtlmh.Text = selectrow.Cells[4].Value.ToString();
                txtncn.Text = selectrow.Cells[5].Value.ToString();
            }
        }
        private void bntthemsp_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Button";
            button.Size = new System.Drawing.Size(300, 236);
            button.Image = DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources._1;
            flowLayoutPanel1.Controls.Add(button);
        }
        #endregion
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
                MessageBox.Show("Không Tìm Thấy Khách Hàng");
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
        #region EventButton
        private void uiImageButton5_Click(object sender, EventArgs e)
        {

            menu.Visible = true;
            menu.SelectTab(3);

        }
        private void uiImageButton3_Click(object sender, EventArgs e)
        {

            menu.Visible = true;
            menu.SelectTab(4);
            
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
        #endregion
        #region Search
        private void bnt_search_Click(object sender, EventArgs e)
        {
            Search_SanPham();
        }

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
        #endregion
        #region QLKH
        public void xoatextbox()
        {
            txtmkh.Text = string.Empty;
            txt_tkh.Text = string.Empty;
            txt_dckh.Text = string.Empty;
            txt_sdtkh.Text = string.Empty;
            txt_dtkh.Text = string.Empty;
        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgv_ttkh.CurrentRow.Index;
            if (index >= 0)
            {
                txtmkh.Text = dgv_ttkh.Rows[index].Cells[0].Value.ToString();
                txt_tkh.Text = dgv_ttkh.Rows[index].Cells[1].Value.ToString();
                txt_dckh.Text = dgv_ttkh.Rows[index].Cells[2].Value.ToString();
                txt_sdtkh .Text = dgv_ttkh.Rows[index].Cells[3].Value.ToString();
                txt_dtkh .Text = dgv_ttkh.Rows[index].Cells[4].Value.ToString();
            }
        }
        private void ADDFixSaveKH(bool IsFix)
        {
            try
            {
                DBContext dBContext = new DBContext();
                if (IsFix==true)
                {
                    KhachHang edit = dBContext.KhachHangs.Find(txtmkh.Text);
                        if (edit == null)
                        {
                            MessageBox.Show("Mã hàng hóa không thể sửa");

                        }
                        else
                        {
                            edit.TenKH = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(txt_tkh.Text));
                            edit.MaKH = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(txtmkh.Text));
                            edit.DiaChi = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(txt_dckh.Text));
                            edit.SoDienThoai = int.Parse(txt_sdtkh.Text);
                            edit.Diem = int.Parse(txt_dtkh.Text);
                            dBContext.Entry<KhachHang>(edit).State = System.Data.Entity.EntityState.Modified;
                            dBContext.SaveChanges();
                            MessageBox.Show("Luu Thành Công ");
                            formatdata.LoadDataGirdView(dgv_ttkh, khachhanglist);
                            xoatextbox();
                            LoadButtonStart();
                        }
                }
                else
                {

                    KhachHang AddHD = dBContext.KhachHangs.Find(txtmkh.Text);

                    if (AddHD != null)
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại. Không thể thêm!");

                    }
                    else
                    {
                        KhachHang item = new KhachHang();
                        item.TenKH = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(txt_tkh.Text));
                        item.MaKH = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(txtmkh.Text));
                        item.DiaChi = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(txt_dckh.Text));
                        item.SoDienThoai = int.Parse(txt_sdtkh.Text);
                        item.Diem = int.Parse(txt_dtkh.Text);
                        dBContext.KhachHangs.Add(item);
                        dBContext.SaveChanges();
                        MessageBox.Show("Thêm thành công!");
                        formatdata.LoadDataGirdView(dgv_ttkh, khachhanglist);
                        LoadButtonStart();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bnt_themkh_Click(object sender, EventArgs e)
        {
            IsFix = false;
            bnt_luukh.Enabled = true;
            bnt_suakh.Enabled = false;
            bnt_xoakh.Enabled = false;
        }

        private void bnt_suakh_Click(object sender, EventArgs e)
        {
            IsFix = true;
            bnt_luukh.Enabled = true;
            bnt_themkh.Enabled = true;
            bnt_xoakh.Enabled = false;
        }

        private void bnt_luukh_Click(object sender, EventArgs e)
        {
            ADDFixSaveKH(IsFix);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DBContext dBContext = new DBContext();
                KhachHang deleted = dBContext.KhachHangs.Find(txtmkh.Text);
                if (deleted != null)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dBContext.KhachHangs.Remove(deleted);
                        dBContext.SaveChanges();
                        MessageBox.Show("Xóa thành công");
                        formatdata.LoadDataGirdView(dgv_ttkh, khachhanglist);
                        xoatextbox();
                    }
                }
                else
                {
                    MessageBox.Show("Khách Hàng Cần Xóa Không Tồn Tại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bnt_searchkh_Click(object sender, EventArgs e)
        {
            Search_KH();
        }        
        public void Search_KH()
        {
            try
            {
                string masp_search = txt_searchkh.Text;
                var listsearch = formatdata.GetDataFormDB<KhachHang>()
                    .Where(s => s.MaKH.IndexOf(masp_search, StringComparison.OrdinalIgnoreCase) >= 0)
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
        #region QLTTHD
            private void dgvpxhd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvpxhd.CurrentCell.RowIndex;
            if (index >= 0)
            {
                var selectrow = dgvpxhd.Rows[index];
                txt_mapx.Text = selectrow.Cells[0].Value.ToString();
                txt_tenphieuxuat.Text = selectrow.Cells[1].Value.ToString();
                txt_makhachhang.Text = selectrow.Cells[2].Value.ToString();
                txt_mahoadon.Text = selectrow.Cells[3].Value.ToString();
                txt_ngaytaodon.Text  = selectrow.Cells[4].Value.ToString();
                txt_soluong.Text = selectrow.Cells[5].Value.ToString();
            }
        }
        private void ADDFixSavePhieuHD(bool IsFix)
        {
            try
            {
                DBContext dBContext = new DBContext();
                if (IsFix == true)
                {
                    PhieuXuatHang editphieuxuat = dBContext.PhieuXuatHangs.Find(txt_mapx.Text);
                    if (editphieuxuat == null)
                    {
                        MessageBox.Show("Phiếu Xuất Không Tồn Tại");
                        LoadButtonStart();
                    }
                    else
                    {
                        editphieuxuat.MaPX = txt_mapx.Text;
                        editphieuxuat.SoPhieu = txt_tenphieuxuat.Text;
                        editphieuxuat.MAKH = txt_makhachhang.Text;
                        editphieuxuat.MAHD = txt_mahoadon.Text;
                        editphieuxuat.NgayTao = DateTime.Parse(txt_ngaytaodon.Text);
                        editphieuxuat.SoLuong = int.Parse(txt_soluong.Text);
                        dBContext.Entry<PhieuXuatHang>(editphieuxuat).State = System.Data.Entity.EntityState.Modified;
                        dBContext.SaveChanges();
                        MessageBox.Show("Sửa Thành Công ");
                        formatdata.LoadDataGirdView(dgvpxhd, phieuXuatHangs);
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
                        PhieuXuatHang phieuxuathd= new PhieuXuatHang();
                        phieuxuathd.MaPX = txt_mapx.Text;
                        phieuxuathd.SoPhieu = txt_tenphieuxuat.Text;
                        phieuxuathd.MAKH = txt_makhachhang.Text;
                        phieuxuathd.MAHD = txt_mahoadon.Text;
                        phieuxuathd.NgayTao = DateTime.Parse(txt_ngaytaodon.Text);
                        phieuxuathd.SoLuong = int.Parse(txt_soluong.Text);

                        dBContext.PhieuXuatHangs.Add(phieuxuathd);

                        dBContext.SaveChanges();
                        MessageBox.Show("Lưu Thành Công");
                        formatdata.LoadDataGirdView(dgvpxhd, phieuXuatHangs);
                        LoadButtonStart();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bnt_thempkh_Click(object sender, EventArgs e)
        {
            bnt_luupkh.Enabled = true;
            bnt_suapkh.Enabled = false;
            bnt_xoaphd.Enabled = false;
            IsFix = false;
        }
        private void bnt_suapkh_Click(object sender, EventArgs e)
        {

            bnt_luupkh.Enabled = true;
            bnt_thempkh.Enabled = false;
            bnt_xoaphd.Enabled = false;
            IsFix = true;
        }
        private void Delete_Phieuxuathang()
        {
            DBContext dBContext = new DBContext();
            var phieuxuathang = dBContext.PhieuXuatHangs.Find(txt_mapx.Text);
            if (phieuxuathang != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dBContext.PhieuXuatHangs.Remove(phieuxuathang);
                    dBContext.SaveChanges();
                    formatdata.LoadDataGirdView(dgvpxhd, phieuXuatHangs);
                    LoadButtonStart();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Phiếu Xuất Hàng");
            }
        }
        private void bnt_xoaphd_Click(object sender, EventArgs e)
        {
            Delete_Phieuxuathang();
        }

        private void bnt_luupkh_Click(object sender, EventArgs e)
        {
            ADDFixSavePhieuHD(IsFix);
        }

        private void bnt_search_ttkh_Click(object sender, EventArgs e)
        {
            Search_THD();
        }
        public void Search_THD()
        {
            try
            {
                string masp_search = txt_searchtthd.Text;
                var listsearch = formatdata.GetDataFormDB<PhieuXuatHang>()
                    .Where(s => s.MaPX.IndexOf(masp_search, StringComparison.OrdinalIgnoreCase) >= 0)
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
        #region HaoDon

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgv_hoadon.CurrentRow.Index;
            if (index >= 0)
            {
                txt_mhd.Text = dgv_hoadon.Rows[index].Cells[0].Value.ToString();
                txt_tenhd.Text = dgv_hoadon.Rows[index].Cells[1].Value.ToString();
                txt_mkh.Text = dgv_hoadon.Rows[index].Cells[2].Value.ToString();
                txt_ngaylaphd.Text = dgv_hoadon.Rows[index].Cells[3].Value.ToString();  
                txt_vat.Text = dgv_hoadon.Rows[index].Cells[4].Value.ToString();
                //txt_thanhtien.Text = dgv_hoadon.Rows[index].Cells[5].Value.ToString();
            }
        }
        private void AddFixSavw_HD(bool IsFix)
        {

            try
            {
                DBContext dBContext = new DBContext();
                if (IsFix == true)
                {
                    HoaDon edit = dBContext.HoaDons.Find(txt_mhd.Text);
                    if (edit == null)
                    {
                        MessageBox.Show("Mã hóa đơn không thể sửa");

                    }
                    else
                    {
                        edit.MaHoaDo = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(txt_mhd.Text));
                        edit.SoHoaDon = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(txt_tenhd.Text));
                        edit.MaKH = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(txt_mkh.Text));
                        edit.NgayLap = DateTime.Parse(txt_ngaylaphd.Text);
                        edit.VAT = int.Parse(txt_vat.Text);
                       // edit.ThanhTien = double.Parse(txt_thanhtien.Text);
                        dBContext.Entry<HoaDon>(edit).State = System.Data.Entity.EntityState.Modified;
                        dBContext.SaveChanges();
                        MessageBox.Show("Luu Thành Công ");
                        formatdata.LoadDataGirdView(dgv_hoadon, hoadon);
                        xoatextbox();
                        LoadButtonStart();
                    }
                }
                else
                {

                    HoaDon AddHD = dBContext.HoaDons.Find(txt_mhd.Text);

                    if (AddHD != null)
                    {
                        MessageBox.Show("Mã Hóa Đơn đã tồn tại. Không thể thêm!");

                    }
                    else
                    {
                        HoaDon item = new HoaDon();
                        item.MaHoaDo = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(txt_mhd.Text));
                        item.SoHoaDon = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(txt_tenhd.Text));
                        item.MaKH = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(txt_mkh.Text));
                        item.NgayLap = DateTime.Parse(txt_ngaylaphd.Text);
                        item.VAT = int.Parse(txt_vat.Text);
                        //item.ThanhTien = double.Parse(txt_thanhtien.Text);
                        dBContext.HoaDons.Add(item);
                        dBContext.SaveChanges();
                        MessageBox.Show("Thêm thành công!");
                        formatdata.LoadDataGirdView(dgv_hoadon, hoadon);
                        LoadButtonStart();
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);   
            }
            }
        private void btn_themhoadon_Click(object sender, EventArgs e)
        {
            btn_luuhoadon.Enabled = true;
            bnt_xoaphd.Enabled = false;
            btn_suahoadon.Enabled = false;
            btn_themhoadon.Enabled = false;
            IsFix = false;
        }
        private void btn_suahoadon_Click(object sender, EventArgs e)
        {
            btn_luuhoadon.Enabled = true;
            bnt_xoaphd.Enabled = false;
            btn_suahoadon.Enabled = false;
            btn_themhoadon.Enabled = false;
            IsFix = true;
        }

        private void btn_luuhoadon_Click(object sender, EventArgs e)
        {
            AddFixSavw_HD(IsFix);
        }

        private void btn_xoahoadon_Click(object sender, EventArgs e)
        {
            DBContext dBContext = new DBContext();
            var phieuhd = dBContext.HoaDons.Find(txt_mhd.Text);
            if (phieuhd != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dBContext.HoaDons.Remove(phieuhd);
                    dBContext.SaveChanges();
                    formatdata.LoadDataGirdView(dgvpxhd, hoadon);
                    LoadButtonStart();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Hóa Đơn");
            }
        }
        public void Search_TTHD()
        {
            try
            {
                string masp_search = txt_searchhd.Text;
                var listsearch = formatdata.GetDataFormDB<HoaDon>()
                    .Where(s => s.MaHoaDo.IndexOf(masp_search, StringComparison.OrdinalIgnoreCase) >= 0)
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
        private void bnt_searchhd_Click(object sender, EventArgs e)
        {
            Search_TTHD();
        }
        #endregion

        private void uiGroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void uiGroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiLabel8_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel14_Click(object sender, EventArgs e)
        {

        }

        private void uiImageButton12_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayBan_ValueChanged(object sender, DateTime value)
        {

        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvpxhd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnt_tracuu_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grp_quanlyhoadon_Click(object sender, EventArgs e)
        {

        }
        #region TraCuuHd
        private void Setup_TimeTraCuu()
        {

            DateTime timeend = DateTime.Parse(txt_ngayend.Text);
            DateTime timestart = DateTime.Parse(txt_ngaystart.Text);
            var filterData = formatdata.GetDataFormDB<HoaDon>().Where(s => s.NgayLap > timestart && s.NgayLap < timeend).ToList();
            dgv_tracuuhoadon.DataSource = null;
            dgv_tracuuhoadon.DataSource = filterData;
            if (filterData == null)
            {
                MessageBox.Show("Không Tìm Thấy Hóa Đơn Cần Tìm");
                formatdata.LoadDataGirdView(dgv_tracuuhoadon, hoadon);
            }
        }
        private void bnt_tracuu_Click_1(object sender, EventArgs e)
        {
            Setup_TimeTraCuu();
        }

        #endregion

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_ttkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            ReloadDataGird();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void uiImageButton1_Click_1(object sender, EventArgs e)
        {
            menu.Visible = true;
            menu.SelectTab(2);
        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel27_Click(object sender, EventArgs e)
        {

        }
    }
}
