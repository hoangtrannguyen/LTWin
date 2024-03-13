namespace GUI {
    partial class UC_InOrderCustomer {
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
            this.lblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblOrderStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrderDetail = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrbProduct
            // 
            this.ptrbProduct.Image = global::GUI.Properties.Resources.xe_dieu_khien;
            this.ptrbProduct.ImageRotate = 0F;
            this.ptrbProduct.Location = new System.Drawing.Point(19, 12);
            this.ptrbProduct.Name = "ptrbProduct";
            this.ptrbProduct.Size = new System.Drawing.Size(104, 101);
            this.ptrbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrbProduct.TabIndex = 2;
            this.ptrbProduct.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductName.Location = new System.Drawing.Point(138, 25);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(137, 22);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Xe điều khiển từ xa";
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuantity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblQuantity.Location = new System.Drawing.Point(138, 55);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(19, 22);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "x1";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrice.Location = new System.Drawing.Point(329, 51);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 22);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "200.000";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOrderStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrderStatus.Location = new System.Drawing.Point(625, 51);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(76, 22);
            this.lblOrderStatus.TabIndex = 5;
            this.lblOrderStatus.Text = "Đang giao";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalMoney.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalMoney.Location = new System.Drawing.Point(474, 51);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(61, 22);
            this.lblTotalMoney.TabIndex = 6;
            this.lblTotalMoney.Text = "200.000";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.Enabled = false;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnConfirm.Location = new System.Drawing.Point(741, 41);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(177, 45);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Đã nhận được hàng";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnCancel.Location = new System.Drawing.Point(915, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            // 
            // btnOrderDetail
            // 
            this.btnOrderDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderDetail.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnOrderDetail.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnOrderDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnOrderDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrderDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnOrderDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDetail.ForeColor = System.Drawing.Color.White;
            this.btnOrderDetail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnOrderDetail.Location = new System.Drawing.Point(123, 73);
            this.btnOrderDetail.Name = "btnOrderDetail";
            this.btnOrderDetail.Size = new System.Drawing.Size(152, 45);
            this.btnOrderDetail.TabIndex = 7;
            this.btnOrderDetail.Text = "Chi tiết đơn hàng";
            this.btnOrderDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOrderDetail.Click += new System.EventHandler(this.btnOrderDetail_Click);
            // 
            // UC_InOrderCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOrderDetail);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.ptrbProduct);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Name = "UC_InOrderCustomer";
            this.Size = new System.Drawing.Size(1003, 124);
            this.Load += new System.EventHandler(this.UC_InOrderCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox ptrbProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOrderStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMoney;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnOrderDetail;
    }
}
