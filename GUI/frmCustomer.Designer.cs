namespace GUI {
    partial class frmCustomer {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.panelSlide = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUpdateInfo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSettlePayment = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCart = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSearchProduct = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnHome = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.ptrbAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.frmCustomerDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.frmCustomerElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.frmCustomerAnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panelTitle.SuspendLayout();
            this.panelSlide.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(531, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 23);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title";
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1033, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 33);
            this.btnClose.TabIndex = 4;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panelTitle.Location = new System.Drawing.Point(213, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1083, 33);
            this.panelTitle.TabIndex = 11;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Animated = true;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(983, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 33);
            this.btnMinimize.TabIndex = 5;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRole.Location = new System.Drawing.Point(62, 67);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(78, 21);
            this.lblRole.TabIndex = 13;
            this.lblRole.Text = "Customer";
            // 
            // panelSlide
            // 
            this.panelSlide.AutoScroll = true;
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panelSlide.Controls.Add(this.guna2GradientButton1);
            this.panelSlide.Controls.Add(this.btnUpdateInfo);
            this.panelSlide.Controls.Add(this.btnSettlePayment);
            this.panelSlide.Controls.Add(this.btnCart);
            this.panelSlide.Controls.Add(this.btnSearchProduct);
            this.panelSlide.Controls.Add(this.btnHome);
            this.panelSlide.Controls.Add(this.panelInfo);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(213, 666);
            this.panelSlide.TabIndex = 10;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.guna2GradientButton1.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.guna2GradientButton1.Image = global::GUI.Properties.Resources.logout_icon;
            this.guna2GradientButton1.Location = new System.Drawing.Point(0, 621);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(213, 45);
            this.guna2GradientButton1.TabIndex = 8;
            this.guna2GradientButton1.Text = "Đăng xuất";
            this.guna2GradientButton1.UseTransparentBackground = true;
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Animated = true;
            this.btnUpdateInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateInfo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnUpdateInfo.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnUpdateInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateInfo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnUpdateInfo.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnUpdateInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdateInfo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnUpdateInfo.Image = global::GUI.Properties.Resources.password_reset_30px;
            this.btnUpdateInfo.Location = new System.Drawing.Point(0, 280);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(213, 45);
            this.btnUpdateInfo.TabIndex = 7;
            this.btnUpdateInfo.Text = "Cập nhật thông tin";
            this.btnUpdateInfo.UseTransparentBackground = true;
            // 
            // btnSettlePayment
            // 
            this.btnSettlePayment.Animated = true;
            this.btnSettlePayment.BackColor = System.Drawing.Color.Transparent;
            this.btnSettlePayment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnSettlePayment.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnSettlePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettlePayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettlePayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettlePayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettlePayment.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettlePayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettlePayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettlePayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnSettlePayment.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnSettlePayment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSettlePayment.ForeColor = System.Drawing.Color.White;
            this.btnSettlePayment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnSettlePayment.Image = global::GUI.Properties.Resources.calculator_30px;
            this.btnSettlePayment.Location = new System.Drawing.Point(0, 235);
            this.btnSettlePayment.Name = "btnSettlePayment";
            this.btnSettlePayment.Size = new System.Drawing.Size(213, 45);
            this.btnSettlePayment.TabIndex = 6;
            this.btnSettlePayment.Text = "Thanh toán";
            this.btnSettlePayment.UseTransparentBackground = true;
            // 
            // btnCart
            // 
            this.btnCart.Animated = true;
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnCart.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCart.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnCart.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(0, 190);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(213, 45);
            this.btnCart.TabIndex = 5;
            this.btnCart.Text = "Giỏ hàng";
            this.btnCart.UseTransparentBackground = true;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Animated = true;
            this.btnSearchProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchProduct.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnSearchProduct.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchProduct.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnSearchProduct.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnSearchProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnSearchProduct.Image = global::GUI.Properties.Resources.search_30px;
            this.btnSearchProduct.Location = new System.Drawing.Point(0, 145);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(213, 45);
            this.btnSearchProduct.TabIndex = 4;
            this.btnSearchProduct.Text = "Tìm kiếm sản phẩm";
            this.btnSearchProduct.UseTransparentBackground = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnHome.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnHome.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnHome.Image = global::GUI.Properties.Resources.home_page_white_icon;
            this.btnHome.Location = new System.Drawing.Point(0, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(213, 45);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseTransparentBackground = true;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.ptrbAvatar);
            this.panelInfo.Controls.Add(this.lblRole);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(213, 100);
            this.panelInfo.TabIndex = 0;
            // 
            // ptrbAvatar
            // 
            this.ptrbAvatar.Image = global::GUI.Properties.Resources.user_icon;
            this.ptrbAvatar.ImageRotate = 0F;
            this.ptrbAvatar.Location = new System.Drawing.Point(163, 12);
            this.ptrbAvatar.Name = "ptrbAvatar";
            this.ptrbAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptrbAvatar.Size = new System.Drawing.Size(50, 49);
            this.ptrbAvatar.TabIndex = 15;
            this.ptrbAvatar.TabStop = false;
            // 
            // frmCustomerDragControl
            // 
            this.frmCustomerDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.frmCustomerDragControl.TargetControl = this.panelTitle;
            this.frmCustomerDragControl.UseTransparentDrag = true;
            // 
            // frmCustomerElipse
            // 
            this.frmCustomerElipse.TargetControl = this;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(213, 33);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1083, 633);
            this.panelContent.TabIndex = 12;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::GUI.Properties.Resources.edit_20px;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::GUI.Properties.Resources.delete_20px;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 666);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomer";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelSlide.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2Panel panelSlide;
        private Guna.UI2.WinForms.Guna2Panel panelInfo;
        private Guna.UI2.WinForms.Guna2DragControl frmCustomerDragControl;
        private Guna.UI2.WinForms.Guna2Elipse frmCustomerElipse;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdateInfo;
        private Guna.UI2.WinForms.Guna2GradientButton btnSettlePayment;
        private Guna.UI2.WinForms.Guna2GradientButton btnCart;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearchProduct;
        private Guna.UI2.WinForms.Guna2GradientButton btnHome;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptrbAvatar;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2AnimateWindow frmCustomerAnimateWindow;
    }
}