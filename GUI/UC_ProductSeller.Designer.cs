namespace GUI {
    partial class UC_ProductSeller {
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
            this.lblTotalMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProductName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.ptrbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalMoney.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalMoney.Location = new System.Drawing.Point(554, 51);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(21, 22);
            this.lblTotalMoney.TabIndex = 19;
            this.lblTotalMoney.Text = "15";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrice.Location = new System.Drawing.Point(405, 51);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 22);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "200.000";
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProductName.Location = new System.Drawing.Point(154, 51);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(137, 22);
            this.lblProductName.TabIndex = 17;
            this.lblProductName.Text = "Xe điều khiển từ xa";
            // 
            // btnDetail
            // 
            this.btnDetail.Animated = true;
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnDetail.Location = new System.Drawing.Point(667, 40);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(134, 45);
            this.btnDetail.TabIndex = 20;
            this.btnDetail.Text = "Chi tiết";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnEdit.Image = global::GUI.Properties.Resources.edit_icon;
            this.btnEdit.Location = new System.Drawing.Point(887, 40);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(20, 33);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnDelete.Image = global::GUI.Properties.Resources.remove_icon;
            this.btnDelete.Location = new System.Drawing.Point(936, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 33);
            this.btnDelete.TabIndex = 20;
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
            // UC_ProductSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.ptrbProduct);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.Name = "UC_ProductSeller";
            this.Size = new System.Drawing.Size(1003, 124);
            this.Load += new System.EventHandler(this.UC_ProductSeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMoney;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductName;
        private Guna.UI2.WinForms.Guna2PictureBox ptrbProduct;
        private Guna.UI2.WinForms.Guna2Button btnDetail;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
    }
}
