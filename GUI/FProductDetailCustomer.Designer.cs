namespace GUI {
    partial class FProductDetailCustomer {
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPriceValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.FProductDetailDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ptrbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblProductDetail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProductName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblContactInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(345, 87);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(629, 107);
            this.lblDescription.TabIndex = 32;
            this.lblDescription.Text = "Tình trạng: Xe còn mới 85%, có trầy nhẹ\r\nChất liệu: Nhựa ABS\r\nMàu sắc: Nâu đen\r\nK" +
    "ích thước: 25cm x 15cm x 10cm\r\nPin: Dùng pin sạc";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddress.Location = new System.Drawing.Point(345, 272);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(172, 22);
            this.lblAddress.TabIndex = 26;
            this.lblAddress.Text = "Địa chỉ: TP. Hồ Chí Minh";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrice.Location = new System.Drawing.Point(345, 236);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 22);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.Text = "Giá:";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPriceValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPriceValue.Location = new System.Drawing.Point(380, 236);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(61, 22);
            this.lblPriceValue.TabIndex = 30;
            this.lblPriceValue.Text = "200.000";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnAddToCart.Location = new System.Drawing.Point(324, 300);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(180, 45);
            this.btnAddToCart.TabIndex = 25;
            this.btnAddToCart.Text = "Thêm vào giỏ hàng";
            // 
            // timerClose
            // 
            this.timerClose.Interval = 15;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // FProductDetailDragControl
            // 
            this.FProductDetailDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.FProductDetailDragControl.TargetControl = this;
            this.FProductDetailDragControl.UseTransparentDrag = true;
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
            this.btnClose.Location = new System.Drawing.Point(901, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 34;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ptrbProduct
            // 
            this.ptrbProduct.BackColor = System.Drawing.Color.Transparent;
            this.ptrbProduct.Image = global::GUI.Properties.Resources.xe_dieu_khien;
            this.ptrbProduct.ImageRotate = 0F;
            this.ptrbProduct.Location = new System.Drawing.Point(42, 55);
            this.ptrbProduct.Name = "ptrbProduct";
            this.ptrbProduct.Size = new System.Drawing.Size(269, 266);
            this.ptrbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrbProduct.TabIndex = 23;
            this.ptrbProduct.TabStop = false;
            // 
            // lblProductDetail
            // 
            this.lblProductDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblProductDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductDetail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductDetail.Location = new System.Drawing.Point(42, 12);
            this.lblProductDetail.Name = "lblProductDetail";
            this.lblProductDetail.Size = new System.Drawing.Size(126, 22);
            this.lblProductDetail.TabIndex = 29;
            this.lblProductDetail.Text = "Chi tiết sản phẩm";
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductName.Location = new System.Drawing.Point(345, 55);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(99, 22);
            this.lblProductName.TabIndex = 29;
            this.lblProductName.Text = "Xe điều khiển";
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuantity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQuantity.Location = new System.Drawing.Point(345, 204);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(83, 22);
            this.lblQuantity.TabIndex = 29;
            this.lblQuantity.Text = "Số lượng: 1";
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblContactInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblContactInfo.Location = new System.Drawing.Point(548, 272);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(217, 22);
            this.lblContactInfo.TabIndex = 29;
            this.lblContactInfo.Text = "Thông tin liên hệ: 1234567890";
            // 
            // FProductDetailCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(947, 374);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductDetail);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.ptrbProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FProductDetailCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FProductDetail";
            this.Load += new System.EventHandler(this.FProductDetailCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPriceValue;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private Guna.UI2.WinForms.Guna2PictureBox ptrbProduct;
        private System.Windows.Forms.Timer timerClose;
        private Guna.UI2.WinForms.Guna2DragControl FProductDetailDragControl;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductDetail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContactInfo;
    }
}