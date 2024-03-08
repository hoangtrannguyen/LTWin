namespace GUI {
    partial class frmProduct {
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
            this.panelAddBrand = new Guna.UI2.WinForms.Guna2Panel();
            this.txtProductCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddProduct = new Guna.UI2.WinForms.Guna2Button();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelAddBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddBrand
            // 
            this.panelAddBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panelAddBrand.Controls.Add(this.txtProductCode);
            this.panelAddBrand.Controls.Add(this.btnAddProduct);
            this.panelAddBrand.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddBrand.Location = new System.Drawing.Point(0, 0);
            this.panelAddBrand.Name = "panelAddBrand";
            this.panelAddBrand.Size = new System.Drawing.Size(948, 43);
            this.panelAddBrand.TabIndex = 12;
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
            this.txtProductCode.Size = new System.Drawing.Size(768, 43);
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
            this.btnAddProduct.Location = new System.Drawing.Point(768, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(180, 43);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm sản phẩm";
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.flowPanel.Location = new System.Drawing.Point(0, 43);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.flowPanel.Size = new System.Drawing.Size(948, 510);
            this.flowPanel.TabIndex = 13;
            this.flowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowPanel_Paint);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GUI.Properties.Resources.edit_20px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::GUI.Properties.Resources.close_window_30px;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 553);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.panelAddBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.panelAddBrand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2Panel panelAddBrand;
        private Guna.UI2.WinForms.Guna2TextBox txtProductCode;
        private Guna.UI2.WinForms.Guna2Button btnAddProduct;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}