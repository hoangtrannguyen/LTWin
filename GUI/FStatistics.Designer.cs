namespace GUI {
    partial class FStatistics {
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
            this.flowPanelHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTopSelling = new Guna.UI2.WinForms.Guna2Button();
            this.btnSoldItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnRevenue = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelledOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductQuantity = new Guna.UI2.WinForms.Guna2Button();
            this.flowPanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanelHeader
            // 
            this.flowPanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.flowPanelHeader.Controls.Add(this.btnTopSelling);
            this.flowPanelHeader.Controls.Add(this.btnSoldItems);
            this.flowPanelHeader.Controls.Add(this.btnRevenue);
            this.flowPanelHeader.Controls.Add(this.btnCancelledOrder);
            this.flowPanelHeader.Controls.Add(this.btnProductQuantity);
            this.flowPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.flowPanelHeader.Name = "flowPanelHeader";
            this.flowPanelHeader.Size = new System.Drawing.Size(1036, 50);
            this.flowPanelHeader.TabIndex = 0;
            // 
            // btnTopSelling
            // 
            this.btnTopSelling.Animated = true;
            this.btnTopSelling.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTopSelling.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnTopSelling.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnTopSelling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTopSelling.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnTopSelling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTopSelling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTopSelling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTopSelling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTopSelling.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnTopSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTopSelling.ForeColor = System.Drawing.Color.White;
            this.btnTopSelling.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnTopSelling.Location = new System.Drawing.Point(3, 3);
            this.btnTopSelling.Name = "btnTopSelling";
            this.btnTopSelling.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnTopSelling.Size = new System.Drawing.Size(124, 45);
            this.btnTopSelling.TabIndex = 0;
            this.btnTopSelling.Text = "Top bán chạy";
            // 
            // btnSoldItems
            // 
            this.btnSoldItems.Animated = true;
            this.btnSoldItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSoldItems.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnSoldItems.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnSoldItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoldItems.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnSoldItems.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSoldItems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSoldItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSoldItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSoldItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnSoldItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoldItems.ForeColor = System.Drawing.Color.White;
            this.btnSoldItems.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnSoldItems.Location = new System.Drawing.Point(133, 3);
            this.btnSoldItems.Name = "btnSoldItems";
            this.btnSoldItems.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnSoldItems.Size = new System.Drawing.Size(124, 45);
            this.btnSoldItems.TabIndex = 1;
            this.btnSoldItems.Text = "Đã bán";
            // 
            // btnRevenue
            // 
            this.btnRevenue.Animated = true;
            this.btnRevenue.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRevenue.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnRevenue.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenue.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnRevenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnRevenue.Location = new System.Drawing.Point(263, 3);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnRevenue.Size = new System.Drawing.Size(124, 45);
            this.btnRevenue.TabIndex = 2;
            this.btnRevenue.Text = "Doanh thu";
            // 
            // btnCancelledOrder
            // 
            this.btnCancelledOrder.Animated = true;
            this.btnCancelledOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCancelledOrder.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnCancelledOrder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnCancelledOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelledOrder.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnCancelledOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelledOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelledOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelledOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelledOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnCancelledOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelledOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelledOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnCancelledOrder.Location = new System.Drawing.Point(393, 3);
            this.btnCancelledOrder.Name = "btnCancelledOrder";
            this.btnCancelledOrder.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnCancelledOrder.Size = new System.Drawing.Size(145, 45);
            this.btnCancelledOrder.TabIndex = 3;
            this.btnCancelledOrder.Text = "Đơn hàng bị hủy";
            // 
            // btnProductQuantity
            // 
            this.btnProductQuantity.Animated = true;
            this.btnProductQuantity.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProductQuantity.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnProductQuantity.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnProductQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductQuantity.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnProductQuantity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductQuantity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductQuantity.ForeColor = System.Drawing.Color.White;
            this.btnProductQuantity.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnProductQuantity.Location = new System.Drawing.Point(544, 3);
            this.btnProductQuantity.Name = "btnProductQuantity";
            this.btnProductQuantity.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnProductQuantity.Size = new System.Drawing.Size(216, 45);
            this.btnProductQuantity.TabIndex = 4;
            this.btnProductQuantity.Text = "Số lượng mặt hàng còn lại";
            // 
            // FStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1036, 633);
            this.Controls.Add(this.flowPanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHomeAdministrator";
            this.Load += new System.EventHandler(this.FStatistics_Load);
            this.flowPanelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanelHeader;
        private Guna.UI2.WinForms.Guna2Button btnTopSelling;
        private Guna.UI2.WinForms.Guna2Button btnSoldItems;
        private Guna.UI2.WinForms.Guna2Button btnRevenue;
        private Guna.UI2.WinForms.Guna2Button btnCancelledOrder;
        private Guna.UI2.WinForms.Guna2Button btnProductQuantity;
    }
}