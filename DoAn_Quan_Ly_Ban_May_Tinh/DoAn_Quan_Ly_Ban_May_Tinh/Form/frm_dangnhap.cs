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
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
         
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private frmChucnang frm = new frmChucnang();
        private void frm_dangnhap_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            txtmatkhau.PasswordChar = '*';
            frm.Reset();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            frm_dangki frm_Dangki = new frm_dangki();
            this.Hide();
            frm_Dangki.ShowDialog();
            this.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void xoatextbox()
        {
            txttaikhoan.Text = string.Empty;
            txtmatkhau.Text = string.Empty;
        }
        private bool checktextbox()
        {
            if (string.IsNullOrEmpty(txttaikhoan.Text))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản! ");
                txttaikhoan.Focus();
                return false;
            }
                if (string.IsNullOrEmpty(txtmatkhau.Text))
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu! ");
                    txtmatkhau.Focus();
                    return false;
                }
                return true;
        }
        private void IsActiveLogin()
        {
            try
            {
                string username = txttaikhoan.Text;
                string password = txtmatkhau.Text;
                if (username == "admin" && password == "123")
                {
                    
                        MessageBox.Show("Đăng nhập thành công!!");
                        frmChucnang frmchucnang = new frmChucnang();
                        this.Hide();
                        frmchucnang.ShowDialog();
                        this.Show();
                    
                }
                else
                {
                    MessageBox.Show("Sai tên người dùng hoặc mật khẩu. Vui lòng thử lại.");
                    xoatextbox();
                    txttaikhoan.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (checktextbox()) {
                IsActiveLogin();
            }
            
        }

        
           private int CountClick = 0;
        private void uiCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CountClick++;
            if(CountClick%2==0) {
                uiCheckBox1.Checked = true;
            }
            else
            {
                uiCheckBox1.Checked = false;
            }
            if(uiCheckBox1.Checked)
            {
                txtmatkhau.PasswordChar = '*';
            }
            else
            {
                txtmatkhau.PasswordChar = '\0';
            }
        }
    }
}
