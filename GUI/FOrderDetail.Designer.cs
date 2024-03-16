namespace GUI {
    partial class FOrderDetail {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOrderDetail));
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.FOrderDetailDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblTotalMoneyValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPayMethodName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPayMethod = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAddressValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblReceive = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblReceiveDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ptrbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblOrderDetail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProductName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).BeginInit();
            this.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(901, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoEllipsis = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.ForeColor = System.Drawing.Color.White;
            this.lblProductDescription.Location = new System.Drawing.Point(340, 68);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(567, 162);
            this.lblProductDescription.TabIndex = 42;
            this.lblProductDescription.Text = resources.GetString("lblProductDescription.Text");
            this.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 10;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // FOrderDetailDragControl
            // 
            this.FOrderDetailDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.FOrderDetailDragControl.TargetControl = this;
            this.FOrderDetailDragControl.UseTransparentDrag = true;
            // 
            // lblTotalMoneyValue
            // 
            this.lblTotalMoneyValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoneyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalMoneyValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalMoneyValue.Location = new System.Drawing.Point(389, 294);
            this.lblTotalMoneyValue.Name = "lblTotalMoneyValue";
            this.lblTotalMoneyValue.Size = new System.Drawing.Size(61, 22);
            this.lblTotalMoneyValue.TabIndex = 40;
            this.lblTotalMoneyValue.Text = "200.000";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalMoney.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalMoney.Location = new System.Drawing.Point(340, 294);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(43, 22);
            this.lblTotalMoney.TabIndex = 39;
            this.lblTotalMoney.Text = "Tổng:";
            // 
            // lblPayMethodName
            // 
            this.lblPayMethodName.BackColor = System.Drawing.Color.Transparent;
            this.lblPayMethodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPayMethodName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPayMethodName.Location = new System.Drawing.Point(518, 233);
            this.lblPayMethodName.Name = "lblPayMethodName";
            this.lblPayMethodName.Size = new System.Drawing.Size(188, 22);
            this.lblPayMethodName.TabIndex = 40;
            this.lblPayMethodName.Text = "Thanh toán khi nhận hàng";
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblPayMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPayMethod.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPayMethod.Location = new System.Drawing.Point(340, 233);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(178, 22);
            this.lblPayMethod.TabIndex = 39;
            this.lblPayMethod.Text = "Phương thức thanh toán:";
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddress.Location = new System.Drawing.Point(340, 263);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 22);
            this.lblAddress.TabIndex = 39;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddressValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAddressValue.Location = new System.Drawing.Point(395, 263);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(445, 22);
            this.lblAddressValue.TabIndex = 39;
            this.lblAddressValue.Text = "01 Võ Văn Ngân, Linh Chiểu, Thủ Đức, Thành phố Hồ Chí Minh";
            // 
            // lblReceive
            // 
            this.lblReceive.BackColor = System.Drawing.Color.Transparent;
            this.lblReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReceive.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblReceive.Location = new System.Drawing.Point(503, 293);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(114, 22);
            this.lblReceive.TabIndex = 39;
            this.lblReceive.Text = "Nhận hàng vào:";
            // 
            // lblReceiveDate
            // 
            this.lblReceiveDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReceiveDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblReceiveDate.Location = new System.Drawing.Point(619, 293);
            this.lblReceiveDate.Name = "lblReceiveDate";
            this.lblReceiveDate.Size = new System.Drawing.Size(78, 22);
            this.lblReceiveDate.TabIndex = 39;
            this.lblReceiveDate.Text = "13/3 - 15/3";
            // 
            // ptrbProduct
            // 
            this.ptrbProduct.BackColor = System.Drawing.Color.Transparent;
            this.ptrbProduct.Image = global::GUI.Properties.Resources.xe_dieu_khien;
            this.ptrbProduct.ImageRotate = 0F;
            this.ptrbProduct.Location = new System.Drawing.Point(43, 42);
            this.ptrbProduct.Name = "ptrbProduct";
            this.ptrbProduct.Size = new System.Drawing.Size(269, 266);
            this.ptrbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrbProduct.TabIndex = 34;
            this.ptrbProduct.TabStop = false;
            // 
            // lblOrderDetail
            // 
            this.lblOrderDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOrderDetail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrderDetail.Location = new System.Drawing.Point(43, 10);
            this.lblOrderDetail.Name = "lblOrderDetail";
            this.lblOrderDetail.Size = new System.Drawing.Size(123, 22);
            this.lblOrderDetail.TabIndex = 39;
            this.lblOrderDetail.Text = "Chi tiết đơn hàng";
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductName.Location = new System.Drawing.Point(342, 38);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(99, 22);
            this.lblProductName.TabIndex = 40;
            this.lblProductName.Text = "Xe điều khiển";
            // 
            // FOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(947, 338);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.lblAddressValue);
            this.Controls.Add(this.lblReceiveDate);
            this.Controls.Add(this.lblReceive);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPayMethod);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.lblOrderDetail);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblPayMethodName);
            this.Controls.Add(this.lblTotalMoneyValue);
            this.Controls.Add(this.ptrbProduct);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FOrderDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOrderDetail";
            this.Load += new System.EventHandler(this.FOrderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Label lblProductDescription;
        private Guna.UI2.WinForms.Guna2PictureBox ptrbProduct;
        private System.Windows.Forms.Timer timerClose;
        private Guna.UI2.WinForms.Guna2DragControl FOrderDetailDragControl;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMoneyValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMoney;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPayMethodName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPayMethod;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddressValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReceive;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReceiveDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOrderDetail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductName;
    }
}