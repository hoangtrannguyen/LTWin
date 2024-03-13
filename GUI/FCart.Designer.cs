namespace GUI {
    partial class FCart {
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
            this.flowPanelCart = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProductImg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelPagination = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSetOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.panelTitle.SuspendLayout();
            this.panelPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanelCart
            // 
            this.flowPanelCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.flowPanelCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowPanelCart.Location = new System.Drawing.Point(0, 38);
            this.flowPanelCart.Name = "flowPanelCart";
            this.flowPanelCart.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowPanelCart.Size = new System.Drawing.Size(1036, 550);
            this.flowPanelCart.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelTitle.Controls.Add(this.lblTotalMoney);
            this.panelTitle.Controls.Add(this.lblQuantity);
            this.panelTitle.Controls.Add(this.lblPrice);
            this.panelTitle.Controls.Add(this.lblProductImg);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1036, 43);
            this.panelTitle.TabIndex = 2;
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalMoney.ForeColor = System.Drawing.Color.White;
            this.lblTotalMoney.Location = new System.Drawing.Point(776, 12);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(69, 22);
            this.lblTotalMoney.TabIndex = 0;
            this.lblTotalMoney.Text = "Tổng tiền";
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(619, 12);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(66, 22);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Số lượng";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(477, 12);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(28, 22);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Giá";
            // 
            // lblProductImg
            // 
            this.lblProductImg.BackColor = System.Drawing.Color.Transparent;
            this.lblProductImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductImg.ForeColor = System.Drawing.Color.White;
            this.lblProductImg.Location = new System.Drawing.Point(84, 12);
            this.lblProductImg.Name = "lblProductImg";
            this.lblProductImg.Size = new System.Drawing.Size(76, 22);
            this.lblProductImg.TabIndex = 0;
            this.lblProductImg.Text = "Sản phẩm";
            // 
            // panelPagination
            // 
            this.panelPagination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelPagination.Controls.Add(this.btnSetOrder);
            this.panelPagination.Controls.Add(this.btnPrevious);
            this.panelPagination.Controls.Add(this.btnNext);
            this.panelPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPagination.Location = new System.Drawing.Point(0, 585);
            this.panelPagination.Name = "panelPagination";
            this.panelPagination.Size = new System.Drawing.Size(1036, 48);
            this.panelPagination.TabIndex = 1;
            // 
            // btnSetOrder
            // 
            this.btnSetOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetOrder.FillColor = System.Drawing.Color.Transparent;
            this.btnSetOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetOrder.ForeColor = System.Drawing.Color.White;
            this.btnSetOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnSetOrder.Location = new System.Drawing.Point(817, 0);
            this.btnSetOrder.Name = "btnSetOrder";
            this.btnSetOrder.Size = new System.Drawing.Size(180, 45);
            this.btnSetOrder.TabIndex = 5;
            this.btnSetOrder.Text = "Đặt hàng";
            this.btnSetOrder.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Animated = true;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.FillColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = global::GUI.Properties.Resources.previous_icon;
            this.btnPrevious.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPrevious.Location = new System.Drawing.Point(485, 9);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 30);
            this.btnPrevious.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::GUI.Properties.Resources.next_icon;
            this.btnNext.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNext.Location = new System.Drawing.Point(521, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 3;
            // 
            // FCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1036, 633);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelPagination);
            this.Controls.Add(this.flowPanelCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCart";
            this.Load += new System.EventHandler(this.FCart_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelPagination.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelCart;
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductImg;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMoney;
        private Guna.UI2.WinForms.Guna2Panel panelPagination;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnSetOrder;
    }
}