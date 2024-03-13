namespace GUI {
    partial class UC_InOrderSeller {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProductName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblOrderStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ptrbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetail
            // 
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDetail.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnDetail.Location = new System.Drawing.Point(884, 41);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(110, 45);
            this.btnDetail.TabIndex = 21;
            this.btnDetail.Text = "Chi tiết";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = false;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddress.Location = new System.Drawing.Point(355, 27);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(237, 70);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "01 Võ Văn Ngân, Linh Chiểu, Thủ Đức, TP. Hồ Chí Minh";
            this.lblAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductName.Location = new System.Drawing.Point(159, 51);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(137, 22);
            this.lblProductName.TabIndex = 17;
            this.lblProductName.Text = "Xe điều khiển từ xa";
            this.lblProductName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOrderStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrderStatus.Location = new System.Drawing.Point(725, 51);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(135, 22);
            this.lblOrderStatus.TabIndex = 18;
            this.lblOrderStatus.Text = "Đã nhận đơn hàng";
            this.lblOrderStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrice.Location = new System.Drawing.Point(612, 51);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 22);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "200.000";
            this.lblPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptrbProduct
            // 
            this.ptrbProduct.Image = global::GUI.Properties.Resources.xe_dieu_khien;
            this.ptrbProduct.ImageRotate = 0F;
            this.ptrbProduct.Location = new System.Drawing.Point(35, 12);
            this.ptrbProduct.Name = "ptrbProduct";
            this.ptrbProduct.Size = new System.Drawing.Size(104, 101);
            this.ptrbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrbProduct.TabIndex = 15;
            this.ptrbProduct.TabStop = false;
            // 
            // UC_InOrderSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.ptrbProduct);
            this.Name = "UC_InOrderSeller";
            this.Size = new System.Drawing.Size(1003, 124);
            this.Load += new System.EventHandler(this.UC_InOrderSeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnDetail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductName;
        private Guna.UI2.WinForms.Guna2PictureBox ptrbProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOrderStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
    }
}
