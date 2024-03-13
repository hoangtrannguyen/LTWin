namespace GUI {
    partial class FSetOrder {
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
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.btnSetOrder = new Guna.UI2.WinForms.Guna2Button();
            this.lblPayMethod = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxPaymentType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblConfirmPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPayInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblReceiveAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxReceiveAddress = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.vScrollbarOrderProduct = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flowPanelCustomerOrderProductInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUnitPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPhoneNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTotalMoneyValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalOrderValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelContent.SuspendLayout();
            this.panelTitle.SuspendLayout();
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
            this.btnClose.Location = new System.Drawing.Point(779, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerClose
            // 
            this.timerClose.Interval = 10;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // btnSetOrder
            // 
            this.btnSetOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetOrder.FillColor = System.Drawing.Color.Transparent;
            this.btnSetOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSetOrder.ForeColor = System.Drawing.Color.White;
            this.btnSetOrder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnSetOrder.Location = new System.Drawing.Point(555, 259);
            this.btnSetOrder.Name = "btnSetOrder";
            this.btnSetOrder.Size = new System.Drawing.Size(179, 45);
            this.btnSetOrder.TabIndex = 6;
            this.btnSetOrder.Text = "Đặt hàng";
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblPayMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayMethod.ForeColor = System.Drawing.Color.White;
            this.lblPayMethod.Location = new System.Drawing.Point(555, 53);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(174, 22);
            this.lblPayMethod.TabIndex = 7;
            this.lblPayMethod.Text = "Phương thức thanh toán";
            // 
            // cbxPaymentType
            // 
            this.cbxPaymentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.cbxPaymentType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.cbxPaymentType.BorderRadius = 5;
            this.cbxPaymentType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxPaymentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbxPaymentType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPaymentType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPaymentType.ForeColor = System.Drawing.Color.White;
            this.cbxPaymentType.ItemHeight = 30;
            this.cbxPaymentType.Location = new System.Drawing.Point(530, 107);
            this.cbxPaymentType.Name = "cbxPaymentType";
            this.cbxPaymentType.Size = new System.Drawing.Size(224, 36);
            this.cbxPaymentType.TabIndex = 78;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(14, 231);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(205, 22);
            this.lblConfirmPassword.TabIndex = 79;
            this.lblConfirmPassword.Text = "Nhập mật khẩu để xác nhận:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtConfirmPassword.BorderRadius = 5;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(262, 224);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(199, 36);
            this.txtConfirmPassword.TabIndex = 80;
            // 
            // lblPayInfo
            // 
            this.lblPayInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayInfo.ForeColor = System.Drawing.Color.White;
            this.lblPayInfo.Location = new System.Drawing.Point(498, 172);
            this.lblPayInfo.Name = "lblPayInfo";
            this.lblPayInfo.Size = new System.Drawing.Size(301, 22);
            this.lblPayInfo.TabIndex = 7;
            this.lblPayInfo.Text = "Vui lòng chuẩn bị tiền vào ngày nhận hàng";
            // 
            // lblReceiveAddress
            // 
            this.lblReceiveAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiveAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveAddress.ForeColor = System.Drawing.Color.White;
            this.lblReceiveAddress.Location = new System.Drawing.Point(14, 172);
            this.lblReceiveAddress.Name = "lblReceiveAddress";
            this.lblReceiveAddress.Size = new System.Drawing.Size(135, 22);
            this.lblReceiveAddress.TabIndex = 79;
            this.lblReceiveAddress.Text = "Địa chỉ nhận hàng:";
            // 
            // cbxReceiveAddress
            // 
            this.cbxReceiveAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.cbxReceiveAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.cbxReceiveAddress.BorderRadius = 5;
            this.cbxReceiveAddress.BorderThickness = 0;
            this.cbxReceiveAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxReceiveAddress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxReceiveAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxReceiveAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.cbxReceiveAddress.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxReceiveAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxReceiveAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxReceiveAddress.ForeColor = System.Drawing.Color.White;
            this.cbxReceiveAddress.ItemHeight = 30;
            this.cbxReceiveAddress.Location = new System.Drawing.Point(262, 165);
            this.cbxReceiveAddress.Name = "cbxReceiveAddress";
            this.cbxReceiveAddress.Size = new System.Drawing.Size(199, 36);
            this.cbxReceiveAddress.TabIndex = 78;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.vScrollbarOrderProduct);
            this.panelContent.Controls.Add(this.flowPanelCustomerOrderProductInfo);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContent.Location = new System.Drawing.Point(0, 346);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelContent.Size = new System.Drawing.Size(825, 403);
            this.panelContent.TabIndex = 81;
            // 
            // vScrollbarOrderProduct
            // 
            this.vScrollbarOrderProduct.AutoRoundedCorners = true;
            this.vScrollbarOrderProduct.BindingContainer = this.flowPanelCustomerOrderProductInfo;
            this.vScrollbarOrderProduct.BorderRadius = 8;
            this.vScrollbarOrderProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.vScrollbarOrderProduct.InUpdate = false;
            this.vScrollbarOrderProduct.LargeChange = 10;
            this.vScrollbarOrderProduct.Location = new System.Drawing.Point(807, 0);
            this.vScrollbarOrderProduct.Name = "vScrollbarOrderProduct";
            this.vScrollbarOrderProduct.ScrollbarSize = 18;
            this.vScrollbarOrderProduct.Size = new System.Drawing.Size(18, 383);
            this.vScrollbarOrderProduct.TabIndex = 0;
            // 
            // flowPanelCustomerOrderProductInfo
            // 
            this.flowPanelCustomerOrderProductInfo.AutoScroll = true;
            this.flowPanelCustomerOrderProductInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.flowPanelCustomerOrderProductInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelCustomerOrderProductInfo.Location = new System.Drawing.Point(0, 0);
            this.flowPanelCustomerOrderProductInfo.Name = "flowPanelCustomerOrderProductInfo";
            this.flowPanelCustomerOrderProductInfo.Size = new System.Drawing.Size(825, 383);
            this.flowPanelCustomerOrderProductInfo.TabIndex = 6;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.panelTitle.Controls.Add(this.lblProduct);
            this.panelTitle.Controls.Add(this.lblQuantity);
            this.panelTitle.Controls.Add(this.lblTotalMoney);
            this.panelTitle.Controls.Add(this.lblUnitPrice);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTitle.Location = new System.Drawing.Point(0, 309);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(825, 37);
            this.panelTitle.TabIndex = 83;
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(36, 8);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(76, 22);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Sản phẩm";
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(344, 8);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(66, 22);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Số lượng";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.ForeColor = System.Drawing.Color.White;
            this.lblTotalMoney.Location = new System.Drawing.Point(696, 8);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(39, 22);
            this.lblTotalMoney.TabIndex = 0;
            this.lblTotalMoney.Text = "Tổng";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.White;
            this.lblUnitPrice.Location = new System.Drawing.Point(519, 8);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(58, 22);
            this.lblUnitPrice.TabIndex = 0;
            this.lblUnitPrice.Text = "Đơn giá";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(14, 114);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.lblPhoneNumber.TabIndex = 79;
            this.lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtPhoneNumber.BorderRadius = 5;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(262, 107);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '●';
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(199, 36);
            this.txtPhoneNumber.TabIndex = 80;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(14, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 22);
            this.lblName.TabIndex = 79;
            this.lblName.Text = "Họ và tên:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.txtName.BorderRadius = 10;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(262, 46);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '●';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(199, 36);
            this.txtName.TabIndex = 80;
            // 
            // lblTotalMoneyValue
            // 
            this.lblTotalMoneyValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoneyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoneyValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalMoneyValue.Location = new System.Drawing.Point(648, 231);
            this.lblTotalMoneyValue.Name = "lblTotalMoneyValue";
            this.lblTotalMoneyValue.Size = new System.Drawing.Size(61, 22);
            this.lblTotalMoneyValue.TabIndex = 84;
            this.lblTotalMoneyValue.Text = "200.000";
            // 
            // lblTotalOrderValue
            // 
            this.lblTotalOrderValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalOrderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrderValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalOrderValue.Location = new System.Drawing.Point(570, 231);
            this.lblTotalOrderValue.Name = "lblTotalOrderValue";
            this.lblTotalOrderValue.Size = new System.Drawing.Size(73, 22);
            this.lblTotalOrderValue.TabIndex = 85;
            this.lblTotalOrderValue.Text = "Tổng tiền:";
            // 
            // FSetOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(825, 749);
            this.Controls.Add(this.lblTotalMoneyValue);
            this.Controls.Add(this.lblTotalOrderValue);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblReceiveAddress);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.cbxReceiveAddress);
            this.Controls.Add(this.cbxPaymentType);
            this.Controls.Add(this.lblPayInfo);
            this.Controls.Add(this.lblPayMethod);
            this.Controls.Add(this.btnSetOrder);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSetOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPayment";
            this.Load += new System.EventHandler(this.FSetOrder_Load);
            this.panelContent.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Timer timerClose;
        private Guna.UI2.WinForms.Guna2Button btnSetOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPayMethod;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPaymentType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPayInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReceiveAddress;
        private Guna.UI2.WinForms.Guna2ComboBox cbxReceiveAddress;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2VScrollBar vScrollbarOrderProduct;
        private System.Windows.Forms.FlowLayoutPanel flowPanelCustomerOrderProductInfo;
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblProduct;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMoney;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUnitPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMoneyValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalOrderValue;
    }
}