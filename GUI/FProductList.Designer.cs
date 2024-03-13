namespace GUI {
    partial class FProductList {
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
            this.panelAddProduct = new Guna.UI2.WinForms.Guna2Panel();
            this.txtProductCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.flowPanelProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.panelPagination = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.vScrollbarFlowPanelProduct = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.panelAddProduct.SuspendLayout();
            this.panelPagination.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddProduct
            // 
            this.panelAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panelAddProduct.Controls.Add(this.txtProductCode);
            this.panelAddProduct.Controls.Add(this.btnAddProduct);
            this.panelAddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddProduct.Location = new System.Drawing.Point(0, 0);
            this.panelAddProduct.Name = "panelAddProduct";
            this.panelAddProduct.Size = new System.Drawing.Size(1036, 43);
            this.panelAddProduct.TabIndex = 12;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Animated = true;
            this.txtProductCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.txtProductCode.BorderThickness = 0;
            this.txtProductCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductCode.DefaultText = "";
            this.txtProductCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProductCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtProductCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtProductCode.ForeColor = System.Drawing.Color.White;
            this.txtProductCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.txtProductCode.IconLeft = global::GUI.Properties.Resources.search_30px;
            this.txtProductCode.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtProductCode.Location = new System.Drawing.Point(0, 0);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PasswordChar = '●';
            this.txtProductCode.PlaceholderText = "Tìm kiếm...";
            this.txtProductCode.SelectedText = "";
            this.txtProductCode.Size = new System.Drawing.Size(856, 43);
            this.txtProductCode.TabIndex = 10;
            this.txtProductCode.UseSystemPasswordChar = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnAddProduct.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Image = global::GUI.Properties.Resources.add_30px;
            this.btnAddProduct.Location = new System.Drawing.Point(856, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(180, 43);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm sản phẩm";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // flowPanelProduct
            // 
            this.flowPanelProduct.AutoScroll = true;
            this.flowPanelProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.flowPanelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.flowPanelProduct.Location = new System.Drawing.Point(0, 76);
            this.flowPanelProduct.Margin = new System.Windows.Forms.Padding(0);
            this.flowPanelProduct.Name = "flowPanelProduct";
            this.flowPanelProduct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.flowPanelProduct.Size = new System.Drawing.Size(1036, 519);
            this.flowPanelProduct.TabIndex = 13;
            this.flowPanelProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanelProduct_Paint);
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
            this.btnPrevious.Location = new System.Drawing.Point(480, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(30, 30);
            this.btnPrevious.TabIndex = 0;
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
            this.btnNext.Location = new System.Drawing.Point(519, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 0;
            // 
            // panelPagination
            // 
            this.panelPagination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelPagination.Controls.Add(this.btnNext);
            this.panelPagination.Controls.Add(this.btnPrevious);
            this.panelPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPagination.Location = new System.Drawing.Point(0, 595);
            this.panelPagination.Name = "panelPagination";
            this.panelPagination.Size = new System.Drawing.Size(1036, 38);
            this.panelPagination.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelTitle.Controls.Add(this.lblQuantity);
            this.panelTitle.Controls.Add(this.lblPrice);
            this.panelTitle.Controls.Add(this.lblProduct);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 43);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1036, 34);
            this.panelTitle.TabIndex = 14;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Location = new System.Drawing.Point(544, 5);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(66, 22);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Số lượng";
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(426, 5);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(28, 22);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Giá";
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Transparent;
            this.lblProduct.Location = new System.Drawing.Point(69, 5);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(76, 22);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Sản phẩm";
            // 
            // vScrollbarFlowPanelProduct
            // 
            this.vScrollbarFlowPanelProduct.AutoRoundedCorners = true;
            this.vScrollbarFlowPanelProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.vScrollbarFlowPanelProduct.BindingContainer = this.flowPanelProduct;
            this.vScrollbarFlowPanelProduct.BorderRadius = 8;
            this.vScrollbarFlowPanelProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.vScrollbarFlowPanelProduct.InUpdate = false;
            this.vScrollbarFlowPanelProduct.LargeChange = 10;
            this.vScrollbarFlowPanelProduct.Location = new System.Drawing.Point(1018, 76);
            this.vScrollbarFlowPanelProduct.Name = "vScrollbarFlowPanelProduct";
            this.vScrollbarFlowPanelProduct.ScrollbarSize = 18;
            this.vScrollbarFlowPanelProduct.Size = new System.Drawing.Size(18, 519);
            this.vScrollbarFlowPanelProduct.TabIndex = 0;
            // 
            // FProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 633);
            this.Controls.Add(this.vScrollbarFlowPanelProduct);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelPagination);
            this.Controls.Add(this.flowPanelProduct);
            this.Controls.Add(this.panelAddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.FProductList_Load);
            this.panelAddProduct.ResumeLayout(false);
            this.panelPagination.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelAddProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtProductCode;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private System.Windows.Forms.FlowLayoutPanel flowPanelProduct;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Panel panelPagination;
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantity;
        private Guna.UI2.WinForms.Guna2VScrollBar vScrollbarFlowPanelProduct;
    }
}