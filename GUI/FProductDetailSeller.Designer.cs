namespace GUI {
    partial class FProductDetailSeller {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.ptrbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPriceValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQuantityValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCategoryName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCategory = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBrandName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBrand = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProductName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FProductDetailSellerDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblContactInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrbProduct
            // 
            this.ptrbProduct.Image = global::GUI.Properties.Resources.xe_dieu_khien_2x;
            this.ptrbProduct.ImageRotate = 0F;
            this.ptrbProduct.Location = new System.Drawing.Point(24, 41);
            this.ptrbProduct.Name = "ptrbProduct";
            this.ptrbProduct.Size = new System.Drawing.Size(259, 256);
            this.ptrbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrbProduct.TabIndex = 100;
            this.ptrbProduct.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(322, 78);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(629, 124);
            this.lblDescription.TabIndex = 106;
            this.lblDescription.Text = "Tình trạng: Xe còn mới 85%, có trầy nhẹ\r\nChất liệu: Nhựa ABS\r\nMàu sắc: Nâu đen\r\nK" +
    "ích thước: 25cm x 15cm x 10cm\r\nPin: Dùng pin sạc";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomClick = true;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(900, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 107;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrice.Location = new System.Drawing.Point(322, 205);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 22);
            this.lblPrice.TabIndex = 108;
            this.lblPrice.Text = "Giá:";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPriceValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPriceValue.Location = new System.Drawing.Point(353, 205);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(61, 22);
            this.lblPriceValue.TabIndex = 109;
            this.lblPriceValue.Text = "200.000";
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuantity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQuantity.Location = new System.Drawing.Point(322, 243);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 22);
            this.lblQuantity.TabIndex = 103;
            this.lblQuantity.Text = "Số lượng:";
            // 
            // lblQuantityValue
            // 
            this.lblQuantityValue.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuantityValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQuantityValue.Location = new System.Drawing.Point(397, 244);
            this.lblQuantityValue.Name = "lblQuantityValue";
            this.lblQuantityValue.Size = new System.Drawing.Size(12, 22);
            this.lblQuantityValue.TabIndex = 103;
            this.lblQuantityValue.Text = "1";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategoryName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategoryName.Location = new System.Drawing.Point(660, 205);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(106, 22);
            this.lblCategoryName.TabIndex = 109;
            this.lblCategoryName.Text = "Đồ chơi trẻ em";
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategory.Location = new System.Drawing.Point(575, 205);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 22);
            this.lblCategory.TabIndex = 108;
            this.lblCategory.Text = "Danh mục:";
            // 
            // lblBrandName
            // 
            this.lblBrandName.BackColor = System.Drawing.Color.Transparent;
            this.lblBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBrandName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBrandName.Location = new System.Drawing.Point(675, 242);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(57, 22);
            this.lblBrandName.TabIndex = 109;
            this.lblBrandName.Text = "Heliway";
            // 
            // lblBrand
            // 
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBrand.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBrand.Location = new System.Drawing.Point(575, 242);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(95, 22);
            this.lblBrand.TabIndex = 108;
            this.lblBrand.Text = "Thương hiệu:";
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.Transparent;
            this.lblProductName.Location = new System.Drawing.Point(322, 41);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(99, 22);
            this.lblProductName.TabIndex = 110;
            this.lblProductName.Text = "Xe điều khiển";
            // 
            // FProductDetailSellerDragControl
            // 
            this.FProductDetailSellerDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.FProductDetailSellerDragControl.TargetControl = this;
            this.FProductDetailSellerDragControl.UseTransparentDrag = true;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 10;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddress.Location = new System.Drawing.Point(322, 287);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(172, 22);
            this.lblAddress.TabIndex = 111;
            this.lblAddress.Text = "Địa chỉ: TP. Hồ Chí Minh";
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblContactInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblContactInfo.Location = new System.Drawing.Point(575, 287);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(217, 22);
            this.lblContactInfo.TabIndex = 112;
            this.lblContactInfo.Text = "Thông tin liên hệ: 1234567890";
            // 
            // FProductDetailSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(947, 348);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblBrandName);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblQuantityValue);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.ptrbProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FProductDetailSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FProductDetailSeller";
            this.Load += new System.EventHandler(this.FProductDetailSeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox ptrbProduct;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPriceValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantityValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategoryName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCategory;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBrandName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBrand;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductName;
        private Guna.UI2.WinForms.Guna2DragControl FProductDetailSellerDragControl;
        private System.Windows.Forms.Timer timerClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContactInfo;
    }
}