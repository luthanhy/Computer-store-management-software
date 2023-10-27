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
    public partial class frm_dangki : Form
    {
        public frm_dangki()
        {
            InitializeComponent();
        }

        private void frm_dangki_Load(object sender, EventArgs e)
        {
            CenterToScreen();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void xoatextbox()
        {
            txttaikhoan.Text = string.Empty;
            txtmatkhau.Text = string.Empty;
            txttennguoidung.Text = string.Empty;
            txtxacnhanmatkhau.Text = string.Empty;
        }
        private bool checktextbox()
        {
            if (string.IsNullOrEmpty(txttennguoidung.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên người dùng ");
                txttennguoidung.Focus();
                return false;
            }
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
            if (string.IsNullOrEmpty(txtxacnhanmatkhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập nhập lại mật khẩu ");
                txtxacnhanmatkhau.Focus();
                return false;
            }
            return true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        private void Signup()
        {
            try
            {
                DbContextSignup db = new DbContextSignup();
                var checkaccount = db.AcountSignUps.Find(txttaikhoan.Text);
                if (checkaccount != null)
                {
                    MessageBox.Show("Tài Khoảng Đã Được Tạo");
                }
                else
                {
                    AcountSignUp acount = new AcountSignUp();
                    acount.username_signup = txttennguoidung.Text;
                    acount.Iduser = txttaikhoan.Text;
                    acount.password_signup = txtmatkhau.Text;
                    db.AcountSignUps.Add(acount);
                    db.SaveChanges();
                    MessageBox.Show("Đăng Kí Thành Công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btndangki_Click(object sender, EventArgs e)
        {
            bool issignin = checktextbox();
            if(issignin==true)
            {
                Signup();
                this.Hide();
                
            }
        }

        private void uiLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
