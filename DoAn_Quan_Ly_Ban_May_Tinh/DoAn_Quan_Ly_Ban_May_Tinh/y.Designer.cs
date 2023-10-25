namespace DoAn_Quan_Ly_Ban_May_Tinh
{
    partial class y
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
            this.grbbanhang = new Sunny.UI.UIGroupBox();
            this.SuspendLayout();
            // 
            // grbbanhang
            // 
            this.grbbanhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbbanhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grbbanhang.Location = new System.Drawing.Point(0, 0);
            this.grbbanhang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbbanhang.MinimumSize = new System.Drawing.Size(1, 1);
            this.grbbanhang.Name = "grbbanhang";
            this.grbbanhang.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.grbbanhang.Size = new System.Drawing.Size(800, 450);
            this.grbbanhang.TabIndex = 3;
            this.grbbanhang.Text = "Bán Hàng";
            this.grbbanhang.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // y
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbbanhang);
            this.Name = "y";
            this.Text = "y";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox grbbanhang;
    }
}