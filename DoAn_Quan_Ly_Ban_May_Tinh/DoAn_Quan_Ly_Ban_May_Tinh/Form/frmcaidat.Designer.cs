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
            this.SuspendLayout();
            // 
            // btndangxuat
            // 
            this.btndangxuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btndangxuat.Location = new System.Drawing.Point(239, 139);
            this.btndangxuat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btndangxuat.Name = "btndangxuat";
            this.btndangxuat.Size = new System.Drawing.Size(100, 71);
            this.btndangxuat.TabIndex = 0;
            this.btndangxuat.Text = "Đăng xuất";
            this.btndangxuat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // btnthoat
            // 
            this.btnthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnthoat.Location = new System.Drawing.Point(378, 139);
            this.btnthoat.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(100, 71);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // frmcaidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangxuat);
            this.Name = "frmcaidat";
            this.Text = "Cài Đặt";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btndangxuat;
        private Sunny.UI.UIButton btnthoat;
    }
}