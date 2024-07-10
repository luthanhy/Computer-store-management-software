namespace DoAn_Quan_Ly_Ban_May_Tinh
{
    partial class frmcaidat
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
            this.btndangxuat = new Sunny.UI.UIButton();
            this.btnthoat = new Sunny.UI.UIButton();
            this.btnsignup = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // btndangxuat
            // 
            this.btndangxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndangxuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btndangxuat.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btndangxuat.ForeColor = System.Drawing.Color.Black;
            this.btndangxuat.Location = new System.Drawing.Point(203, 139);
            this.btndangxuat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.RectColor = System.Drawing.Color.Black;
            this.btndangxuat.Size = new System.Drawing.Size(100, 71);
            this.btndangxuat.Style = Sunny.UI.UIStyle.Custom;
            this.btndangxuat.TabIndex = 0;
            this.btndangxuat.Text = "Đăng xuất";
            this.btndangxuat.TipsFont = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangxuat.Click += new System.EventHandler(this.btndangxuat_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnthoat.ForeColor = System.Drawing.Color.Black;
            this.btnthoat.Location = new System.Drawing.Point(378, 139);
            this.btnthoat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.RectColor = System.Drawing.Color.Black;
            this.btnthoat.Size = new System.Drawing.Size(100, 71);
            this.btnthoat.Style = Sunny.UI.UIStyle.Custom;
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
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
            this.btnsignup.Location = new System.Drawing.Point(576, 166);
            this.btnsignup.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.RectColor = System.Drawing.Color.Black;
            this.btnsignup.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnsignup.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnsignup.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnsignup.Size = new System.Drawing.Size(133, 35);
            this.btnsignup.Style = Sunny.UI.UIStyle.Custom;
            this.btnsignup.TabIndex = 11;
            this.btnsignup.Text = "Đăng Ký";
            this.btnsignup.TipsFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // frmcaidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangxuat);
            this.Name = "frmcaidat";
            this.Text = "Cài Đặt";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btndangxuat;
        private Sunny.UI.UIButton btnthoat;
        private Sunny.UI.UIButton btnsignup;
    }
}