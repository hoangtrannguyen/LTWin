namespace GUI {
    partial class UC_ProductCustomer {
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
            this.ptrbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblProductName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPriceValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnViewDetail = new Guna.UI2.WinForms.Guna2Button();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrbProduct
            // 
            this.ptrbProduct.Image = global::GUI.Properties.Resources.xe_dieu_khien;
            this.ptrbProduct.ImageRotate = 0F;
            this.ptrbProduct.Location = new System.Drawing.Point(60, 10);
            this.ptrbProduct.Name = "ptrbProduct";
            this.ptrbProduct.Size = new System.Drawing.Size(121, 119);
            this.ptrbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrbProduct.TabIndex = 0;
            this.ptrbProduct.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductName.Location = new System.Drawing.Point(52, 133);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(137, 22);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Xe điều khiển từ xa";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPriceValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPriceValue.Location = new System.Drawing.Point(104, 171);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(61, 22);
            this.lblPriceValue.TabIndex = 1;
            this.lblPriceValue.Text = "200.000";
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddress.Location = new System.Drawing.Point(64, 210);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(116, 22);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "TP. Hồ Chí Minh";
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Animated = true;
            this.btnViewDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnViewDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnViewDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnViewDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetail.ForeColor = System.Drawing.Color.White;
            this.btnViewDetail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnViewDetail.Location = new System.Drawing.Point(0, 231);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(241, 40);
            this.btnViewDetail.TabIndex = 3;
            this.btnViewDetail.Text = "Xem chi tiết";
            this.btnViewDetail.UseTransparentBackground = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrice.Location = new System.Drawing.Point(66, 171);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 22);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Giá: ";
            // 
            // UC_ProductCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.btnViewDetail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.ptrbProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.Name = "UC_ProductCustomer";
            this.Size = new System.Drawing.Size(241, 271);
            this.Load += new System.EventHandler(this.UC_ProductCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox ptrbProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPriceValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2Button btnViewDetail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
    }
}