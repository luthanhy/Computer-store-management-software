namespace DoAn_Quan_Ly_Ban_May_Tinh
{
    partial class frm_dangnhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmatkhau = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txttaikhoan = new Sunny.UI.UITextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsignup = new Sunny.UI.UIButton();
            this.btnexit = new Sunny.UI.UIButton();
            this.btnlogin = new Sunny.UI.UIButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel3
            // 
            this.uiLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(336, 77);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(95, 25);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "Welcome";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 107);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources.Screenshot_2023_09_27_212121;
            this.pictureBox1.Location = new System.Drawing.Point(341, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.txtmatkhau);
            this.panel2.Controls.Add(this.uiLabel2);
            this.panel2.Controls.Add(this.uiLabel1);
            this.panel2.Controls.Add(this.txttaikhoan);
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 472);
            this.panel2.TabIndex = 10;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtmatkhau.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtmatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtmatkhau.Location = new System.Drawing.Point(323, 196);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmatkhau.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Padding = new System.Windows.Forms.Padding(5);
            this.txtmatkhau.ShowText = false;
            this.txtmatkhau.Size = new System.Drawing.Size(375, 44);
            this.txtmatkhau.TabIndex = 16;
            this.txtmatkhau.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtmatkhau.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(135, 209);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(142, 25);
            this.uiLabel2.TabIndex = 18;
            this.uiLabel2.Text = "Mật Khẩu";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(135, 114);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(142, 25);
            this.uiLabel1.TabIndex = 17;
            this.uiLabel1.Text = "Tài Khoản";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txttaikhoan.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txttaikhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txttaikhoan.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txttaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttaikhoan.Location = new System.Drawing.Point(323, 95);
            this.txttaikhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttaikhoan.MinimumSize = new System.Drawing.Size(1, 16);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Padding = new System.Windows.Forms.Padding(5);
            this.txttaikhoan.ShowText = false;
            this.txttaikhoan.Size = new System.Drawing.Size(375, 44);
            this.txttaikhoan.TabIndex = 15;
            this.txttaikhoan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txttaikhoan.Watermark = "";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.btnsignup);
            this.panel3.Controls.Add(this.btnexit);
            this.panel3.Controls.Add(this.btnlogin);
            this.panel3.Location = new System.Drawing.Point(0, 432);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(816, 147);
            this.panel3.TabIndex = 15;
            // 
            // btnsignup
            // 
            this.btnsignup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnsignup.Location = new System.Drawing.Point(506, 57);
            this.btnsignup.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(192, 35);
            this.btnsignup.TabIndex = 10;
            this.btnsignup.Text = "Sign up";
            this.btnsignup.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnexit.Location = new System.Drawing.Point(506, 112);
            this.btnexit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(192, 35);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Exit";
            this.btnexit.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlogin.Location = new System.Drawing.Point(506, 6);
            this.btnlogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(192, 35);
            this.btnlogin.TabIndex = 8;
            this.btnlogin.Text = "Log in";
            this.btnlogin.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // frm_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 579);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_dangnhap";
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UITextBox txtmatkhau;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txttaikhoan;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UIButton btnexit;
        private Sunny.UI.UIButton btnlogin;
        private Sunny.UI.UIButton btnsignup;
    }
}