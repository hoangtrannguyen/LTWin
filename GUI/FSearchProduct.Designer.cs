namespace GUI {
    partial class FSearchProduct {
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
            this.panelSearchProduct = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSearchBy = new Guna.UI2.WinForms.Guna2Panel();
            this.cbxPrice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxAddress = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxBrand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowPanelSearchProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.panelPagination = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.panelSearchProduct.SuspendLayout();
            this.panelSearchBy.SuspendLayout();
            this.panelPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearchProduct
            // 
            this.panelSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panelSearchProduct.Controls.Add(this.panelSearchBy);
            this.panelSearchProduct.Controls.Add(this.txtSearchProduct);
            this.panelSearchProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchProduct.Location = new System.Drawing.Point(0, 0);
            this.panelSearchProduct.Name = "panelSearchProduct";
            this.panelSearchProduct.Size = new System.Drawing.Size(1036, 37);
            this.panelSearchProduct.TabIndex = 14;
            // 
            // panelSearchBy
            // 
            this.panelSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelSearchBy.Controls.Add(this.cbxPrice);
            this.panelSearchBy.Controls.Add(this.cbxAddress);
            this.panelSearchBy.Controls.Add(this.cbxBrand);
            this.panelSearchBy.Controls.Add(this.cbxCategory);
            this.panelSearchBy.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchBy.Location = new System.Drawing.Point(345, 0);
            this.panelSearchBy.Name = "panelSearchBy";
            this.panelSearchBy.Size = new System.Drawing.Size(691, 37);
            this.panelSearchBy.TabIndex = 2;
            // 
            // cbxPrice
            // 
            this.cbxPrice.BackColor = System.Drawing.Color.Transparent;
            this.cbxPrice.BorderRadius = 5;
            this.cbxPrice.BorderThickness = 0;
            this.cbxPrice.CausesValidation = false;
            this.cbxPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxPrice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.cbxPrice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrice.ForeColor = System.Drawing.Color.White;
            this.cbxPrice.ItemHeight = 30;
            this.cbxPrice.Items.AddRange(new object[] {
            "Giá"});
            this.cbxPrice.Location = new System.Drawing.Point(549, 2);
            this.cbxPrice.Name = "cbxPrice";
            this.cbxPrice.Size = new System.Drawing.Size(140, 36);
            this.cbxPrice.StartIndex = 0;
            this.cbxPrice.TabIndex = 0;
            this.cbxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxAddress
            // 
            this.cbxAddress.BackColor = System.Drawing.Color.Transparent;
            this.cbxAddress.BorderRadius = 5;
            this.cbxAddress.BorderThickness = 0;
            this.cbxAddress.CausesValidation = false;
            this.cbxAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxAddress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.cbxAddress.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAddress.ForeColor = System.Drawing.Color.White;
            this.cbxAddress.ItemHeight = 30;
            this.cbxAddress.Items.AddRange(new object[] {
            "Địa chỉ"});
            this.cbxAddress.Location = new System.Drawing.Point(364, 2);
            this.cbxAddress.Name = "cbxAddress";
            this.cbxAddress.Size = new System.Drawing.Size(179, 36);
            this.cbxAddress.StartIndex = 0;
            this.cbxAddress.TabIndex = 0;
            this.cbxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxBrand
            // 
            this.cbxBrand.BackColor = System.Drawing.Color.Transparent;
            this.cbxBrand.BorderRadius = 5;
            this.cbxBrand.BorderThickness = 0;
            this.cbxBrand.CausesValidation = false;
            this.cbxBrand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBrand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.cbxBrand.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBrand.ForeColor = System.Drawing.Color.White;
            this.cbxBrand.ItemHeight = 30;
            this.cbxBrand.Items.AddRange(new object[] {
            "Thương hiệu"});
            this.cbxBrand.Location = new System.Drawing.Point(177, 2);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(181, 36);
            this.cbxBrand.StartIndex = 0;
            this.cbxBrand.TabIndex = 0;
            this.cbxBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbxBrand.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // cbxCategory
            // 
            this.cbxCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbxCategory.BorderRadius = 5;
            this.cbxCategory.BorderThickness = 0;
            this.cbxCategory.CausesValidation = false;
            this.cbxCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.cbxCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategory.ForeColor = System.Drawing.Color.White;
            this.cbxCategory.ItemHeight = 30;
            this.cbxCategory.Items.AddRange(new object[] {
            "Danh mục"});
            this.cbxCategory.Location = new System.Drawing.Point(-2, 2);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(173, 36);
            this.cbxCategory.StartIndex = 0;
            this.cbxCategory.TabIndex = 0;
            this.cbxCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtSearchProduct.BorderThickness = 0;
            this.txtSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchProduct.DefaultText = "";
            this.txtSearchProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSearchProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtSearchProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchProduct.IconLeft = global::GUI.Properties.Resources.search_30px;
            this.txtSearchProduct.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtSearchProduct.Location = new System.Drawing.Point(0, 0);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.PlaceholderText = "Tìm kiếm...";
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.Size = new System.Drawing.Size(345, 37);
            this.txtSearchProduct.TabIndex = 1;
            // 
            // flowPanelSearchProduct
            // 
            this.flowPanelSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.flowPanelSearchProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelSearchProduct.Location = new System.Drawing.Point(0, 37);
            this.flowPanelSearchProduct.Name = "flowPanelSearchProduct";
            this.flowPanelSearchProduct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.flowPanelSearchProduct.Size = new System.Drawing.Size(1036, 597);
            this.flowPanelSearchProduct.TabIndex = 15;
            this.flowPanelSearchProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanelSearchProduct_Paint);
            // 
            // panelPagination
            // 
            this.panelPagination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelPagination.Controls.Add(this.btnPrevious);
            this.panelPagination.Controls.Add(this.btnNext);
            this.panelPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPagination.Location = new System.Drawing.Point(0, 594);
            this.panelPagination.Name = "panelPagination";
            this.panelPagination.Size = new System.Drawing.Size(1036, 40);
            this.panelPagination.TabIndex = 16;
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
            this.btnPrevious.Location = new System.Drawing.Point(483, 5);
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
            this.btnNext.Location = new System.Drawing.Point(519, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 3;
            // 
            // FSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 634);
            this.Controls.Add(this.panelPagination);
            this.Controls.Add(this.flowPanelSearchProduct);
            this.Controls.Add(this.panelSearchProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSearchProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearchProduct";
            this.Load += new System.EventHandler(this.FSearchProduct_Load);
            this.panelSearchProduct.ResumeLayout(false);
            this.panelSearchBy.ResumeLayout(false);
            this.panelPagination.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelSearchProduct;
        private System.Windows.Forms.FlowLayoutPanel flowPanelSearchProduct;
        private Guna.UI2.WinForms.Guna2Panel panelPagination;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchProduct;
        private Guna.UI2.WinForms.Guna2Panel panelSearchBy;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cbxAddress;
        private Guna.UI2.WinForms.Guna2ComboBox cbxBrand;
        private Guna.UI2.WinForms.Guna2ComboBox cbxCategory;
    }
}