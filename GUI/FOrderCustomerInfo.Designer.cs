namespace GUI {
    partial class FOrderCustomerInfo {
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
            this.lblProductList = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblOrderInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblFullName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPhoneNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPayMethod = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUnitPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowPanelCustomerOrderProductInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.vScrollbarflowPanelCustomerProductOrderInfo = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalMoneyValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalOrderValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelTitle.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductList
            // 
            this.lblProductList.BackColor = System.Drawing.Color.Transparent;
            this.lblProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductList.ForeColor = System.Drawing.Color.White;
            this.lblProductList.Location = new System.Drawing.Point(327, 205);
            this.lblProductList.Name = "lblProductList";
            this.lblProductList.Size = new System.Drawing.Size(181, 26);
            this.lblProductList.TabIndex = 0;
            this.lblProductList.Text = "Danh sách sản phẩm";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.CausesValidation = false;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomClick = true;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(785, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 33);
            this.btnClose.TabIndex = 5;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOrderInfo
            // 
            this.lblOrderInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderInfo.ForeColor = System.Drawing.Color.White;
            this.lblOrderInfo.Location = new System.Drawing.Point(332, 12);
            this.lblOrderInfo.Name = "lblOrderInfo";
            this.lblOrderInfo.Size = new System.Drawing.Size(170, 26);
            this.lblOrderInfo.TabIndex = 0;
            this.lblOrderInfo.Text = "Thông tin đơn hàng";
            // 
            // lblFullName
            // 
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(36, 52);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(75, 22);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Họ và tên: ";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(36, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 22);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(36, 156);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(424, 52);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 22);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblPayMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayMethod.ForeColor = System.Drawing.Color.White;
            this.lblPayMethod.Location = new System.Drawing.Point(424, 104);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(178, 22);
            this.lblPayMethod.TabIndex = 0;
            this.lblPayMethod.Text = "Phương thức thanh toán:";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panelTitle.Controls.Add(this.lblProduct);
            this.panelTitle.Controls.Add(this.lblQuantity);
            this.panelTitle.Controls.Add(this.lblTotalMoney);
            this.panelTitle.Controls.Add(this.lblUnitPrice);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTitle.Location = new System.Drawing.Point(0, 246);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(835, 37);
            this.panelTitle.TabIndex = 8;
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(36, 8);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(76, 22);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Sản phẩm";
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(344, 8);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(66, 22);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Số lượng";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.ForeColor = System.Drawing.Color.White;
            this.lblTotalMoney.Location = new System.Drawing.Point(696, 8);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(39, 22);
            this.lblTotalMoney.TabIndex = 0;
            this.lblTotalMoney.Text = "Tổng";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.White;
            this.lblUnitPrice.Location = new System.Drawing.Point(519, 8);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(58, 22);
            this.lblUnitPrice.TabIndex = 0;
            this.lblUnitPrice.Text = "Đơn giá";
            // 
            // flowPanelCustomerOrderProductInfo
            // 
            this.flowPanelCustomerOrderProductInfo.AutoScroll = true;
            this.flowPanelCustomerOrderProductInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.flowPanelCustomerOrderProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelCustomerOrderProductInfo.Location = new System.Drawing.Point(0, 0);
            this.flowPanelCustomerOrderProductInfo.Name = "flowPanelCustomerOrderProductInfo";
            this.flowPanelCustomerOrderProductInfo.Size = new System.Drawing.Size(835, 383);
            this.flowPanelCustomerOrderProductInfo.TabIndex = 6;
            // 
            // vScrollbarflowPanelCustomerProductOrderInfo
            // 
            this.vScrollbarflowPanelCustomerProductOrderInfo.AutoRoundedCorners = true;
            this.vScrollbarflowPanelCustomerProductOrderInfo.BindingContainer = this.flowPanelCustomerOrderProductInfo;
            this.vScrollbarflowPanelCustomerProductOrderInfo.BorderRadius = 8;
            this.vScrollbarflowPanelCustomerProductOrderInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.vScrollbarflowPanelCustomerProductOrderInfo.InUpdate = false;
            this.vScrollbarflowPanelCustomerProductOrderInfo.LargeChange = 10;
            this.vScrollbarflowPanelCustomerProductOrderInfo.Location = new System.Drawing.Point(817, 0);
            this.vScrollbarflowPanelCustomerProductOrderInfo.Name = "vScrollbarflowPanelCustomerProductOrderInfo";
            this.vScrollbarflowPanelCustomerProductOrderInfo.ScrollbarSize = 18;
            this.vScrollbarflowPanelCustomerProductOrderInfo.Size = new System.Drawing.Size(18, 383);
            this.vScrollbarflowPanelCustomerProductOrderInfo.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.vScrollbarflowPanelCustomerProductOrderInfo);
            this.panelContent.Controls.Add(this.flowPanelCustomerOrderProductInfo);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContent.Location = new System.Drawing.Point(0, 283);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelContent.Size = new System.Drawing.Size(835, 403);
            this.panelContent.TabIndex = 7;
            // 
            // lblTotalMoneyValue
            // 
            this.lblTotalMoneyValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoneyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoneyValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalMoneyValue.Location = new System.Drawing.Point(593, 156);
            this.lblTotalMoneyValue.Name = "lblTotalMoneyValue";
            this.lblTotalMoneyValue.Size = new System.Drawing.Size(61, 22);
            this.lblTotalMoneyValue.TabIndex = 9;
            this.lblTotalMoneyValue.Text = "200.000";
            // 
            // lblTotalOrderValue
            // 
            this.lblTotalOrderValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalOrderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrderValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalOrderValue.Location = new System.Drawing.Point(424, 156);
            this.lblTotalOrderValue.Name = "lblTotalOrderValue";
            this.lblTotalOrderValue.Size = new System.Drawing.Size(156, 22);
            this.lblTotalOrderValue.TabIndex = 10;
            this.lblTotalOrderValue.Text = "Tổng giá trị đơn hàng:";
            // 
            // FOrderCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(835, 686);
            this.Controls.Add(this.lblTotalMoneyValue);
            this.Controls.Add(this.lblTotalOrderValue);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPayMethod);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblOrderInfo);
            this.Controls.Add(this.lblProductList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FOrderCustomerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOrderCustomerInfo";
            this.Load += new System.EventHandler(this.FOrderCustomerInfo_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductList;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOrderInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFullName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhoneNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPayMethod;
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMoney;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUnitPrice;
        private System.Windows.Forms.FlowLayoutPanel flowPanelCustomerOrderProductInfo;
        private Guna.UI2.WinForms.Guna2VScrollBar vScrollbarflowPanelCustomerProductOrderInfo;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMoneyValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalOrderValue;
    }
}