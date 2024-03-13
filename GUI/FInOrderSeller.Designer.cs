namespace GUI {
    partial class FInOrderSeller {
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
            this.flowPanelInOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lblOrderStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProductImg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelPagination = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotalMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelTitle.SuspendLayout();
            this.panelPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanelInOrder
            // 
            this.flowPanelInOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.flowPanelInOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowPanelInOrder.Location = new System.Drawing.Point(0, 41);
            this.flowPanelInOrder.Name = "flowPanelInOrder";
            this.flowPanelInOrder.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.flowPanelInOrder.Size = new System.Drawing.Size(1036, 550);
            this.flowPanelInOrder.TabIndex = 8;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelTitle.Controls.Add(this.lblTotalMoney);
            this.panelTitle.Controls.Add(this.lblOrderStatus);
            this.panelTitle.Controls.Add(this.lblAddress);
            this.panelTitle.Controls.Add(this.lblProductImg);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1036, 43);
            this.panelTitle.TabIndex = 6;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOrderStatus.ForeColor = System.Drawing.Color.White;
            this.lblOrderStatus.Location = new System.Drawing.Point(766, 13);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(74, 22);
            this.lblOrderStatus.TabIndex = 0;
            this.lblOrderStatus.Text = "Trạng thái";
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(452, 12);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 22);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblProductImg
            // 
            this.lblProductImg.BackColor = System.Drawing.Color.Transparent;
            this.lblProductImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblProductImg.ForeColor = System.Drawing.Color.White;
            this.lblProductImg.Location = new System.Drawing.Point(40, 12);
            this.lblProductImg.Name = "lblProductImg";
            this.lblProductImg.Size = new System.Drawing.Size(76, 22);
            this.lblProductImg.TabIndex = 0;
            this.lblProductImg.Text = "Sản phẩm";
            // 
            // panelPagination
            // 
            this.panelPagination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelPagination.Controls.Add(this.btnPrevious);
            this.panelPagination.Controls.Add(this.btnNext);
            this.panelPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPagination.Location = new System.Drawing.Point(0, 585);
            this.panelPagination.Name = "panelPagination";
            this.panelPagination.Size = new System.Drawing.Size(1036, 48);
            this.panelPagination.TabIndex = 7;
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
            // lblTotalMoney
            // 
            this.lblTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalMoney.ForeColor = System.Drawing.Color.White;
            this.lblTotalMoney.Location = new System.Drawing.Point(619, 12);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(69, 22);
            this.lblTotalMoney.TabIndex = 0;
            this.lblTotalMoney.Text = "Tổng tiền";
            // 
            // FInOrderSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1036, 633);
            this.Controls.Add(this.flowPanelInOrder);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelPagination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FInOrderSeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FInOrderSeller";
            this.Load += new System.EventHandler(this.FInOrderSeller_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelPagination.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelInOrder;
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblOrderStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProductImg;
        private Guna.UI2.WinForms.Guna2Panel panelPagination;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMoney;
    }
}