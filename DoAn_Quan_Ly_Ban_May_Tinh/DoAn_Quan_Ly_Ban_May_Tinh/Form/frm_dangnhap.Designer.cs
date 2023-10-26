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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtmatkhau = new Sunny.UI.UITextBox();
            this.txttaikhoan = new Sunny.UI.UITextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnlogin = new Sunny.UI.UIButton();
            this.btnsignup = new Sunny.UI.UIButton();
            this.btnexit = new Sunny.UI.UIButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 146);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn_Quan_Ly_Ban_May_Tinh.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(230, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.uiCheckBox1);
            this.panel2.Controls.Add(this.uiLabel2);
            this.panel2.Controls.Add(this.uiLabel1);
            this.panel2.Controls.Add(this.txtmatkhau);
            this.panel2.Controls.Add(this.txttaikhoan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 443);
            this.panel2.TabIndex = 10;
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiCheckBox1.Location = new System.Drawing.Point(371, 203);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Size = new System.Drawing.Size(144, 29);
            this.uiCheckBox1.TabIndex = 19;
            this.uiCheckBox1.Text = "Hiện mật khẩu";
            this.uiCheckBox1.Click += new System.EventHandler(this.uiCheckBox1_CheckedChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.uiLabel2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiLabel2.Location = new System.Drawing.Point(12, 173);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(142, 22);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 18;
            this.uiLabel2.Text = "Mật Khẩu";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.uiLabel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiLabel1.Location = new System.Drawing.Point(12, 72);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(142, 22);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 17;
            this.uiLabel1.Text = "Tài Khoản";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmatkhau.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txtmatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtmatkhau.Location = new System.Drawing.Point(192, 154);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmatkhau.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Padding = new System.Windows.Forms.Padding(5);
            this.txtmatkhau.ShowText = false;
            this.txtmatkhau.Size = new System.Drawing.Size(323, 41);
            this.txtmatkhau.TabIndex = 16;
            this.txtmatkhau.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtmatkhau.Watermark = "";
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttaikhoan.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txttaikhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txttaikhoan.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.txttaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txttaikhoan.Location = new System.Drawing.Point(192, 53);
            this.txttaikhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttaikhoan.MinimumSize = new System.Drawing.Size(1, 16);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Padding = new System.Windows.Forms.Padding(5);
            this.txttaikhoan.ShowText = false;
            this.txttaikhoan.Size = new System.Drawing.Size(323, 41);
            this.txttaikhoan.TabIndex = 15;
            this.txttaikhoan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txttaikhoan.Watermark = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnlogin);
            this.panel3.Controls.Add(this.btnsignup);
            this.panel3.Controls.Add(this.btnexit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 421);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 168);
            this.panel3.TabIndex = 16;
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlogin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(192, 3);
            this.btnlogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.RectColor = System.Drawing.Color.Black;
            this.btnlogin.Size = new System.Drawing.Size(133, 35);
            this.btnlogin.Style = Sunny.UI.UIStyle.Custom;
            this.btnlogin.TabIndex = 8;
            this.btnlogin.Text = "Đăng Nhập";
            this.btnlogin.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnsignup
            // 
            this.btnsignup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsignup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsignup.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnsignup.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnsignup.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnsignup.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnsignup.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.Color.Black;
            this.btnsignup.Location = new System.Drawing.Point(382, 3);
            this.btnsignup.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.RectColor = System.Drawing.Color.Black;
            this.btnsignup.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnsignup.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnsignup.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnsignup.Size = new System.Drawing.Size(133, 35);
            this.btnsignup.Style = Sunny.UI.UIStyle.Custom;
            this.btnsignup.TabIndex = 10;
            this.btnsignup.Text = "Đăng Ký";
            this.btnsignup.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnexit.FillColor2 = System.Drawing.Color.Silver;
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(491, 143);
            this.btnexit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnexit.Name = "btnexit";
            this.btnexit.RectColor = System.Drawing.Color.DarkGray;
            this.btnexit.Size = new System.Drawing.Size(54, 22);
            this.btnexit.Style = Sunny.UI.UIStyle.Custom;
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Thoát";
            this.btnexit.TipsColor = System.Drawing.Color.Pink;
            this.btnexit.TipsFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frm_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 589);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_dangnhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frm_dangnhap_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UITextBox txtmatkhau;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txttaikhoan;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UIButton btnsignup;
        private Sunny.UI.UIButton btnlogin;
        private Sunny.UI.UIButton btnexit;
        private Sunny.UI.UICheckBox uiCheckBox1;
    }
}