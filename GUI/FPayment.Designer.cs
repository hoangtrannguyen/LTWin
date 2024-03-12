namespace GUI {
    partial class FPayment {
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
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotalMoney = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalMoneyValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPayMethod = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbxUsertype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblConfirmPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPayInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Animated = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomClick = true;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(754, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerClose
            // 
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // btnPay
            // 
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.Transparent;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnPay.Location = new System.Drawing.Point(317, 218);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(180, 45);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Thanh toán";
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoney.ForeColor = System.Drawing.Color.White;
            this.lblTotalMoney.Location = new System.Drawing.Point(84, 56);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(73, 22);
            this.lblTotalMoney.TabIndex = 7;
            this.lblTotalMoney.Text = "Tổng tiền:";
            this.lblTotalMoney.Click += new System.EventHandler(this.lblTotalMoney_Click);
            // 
            // lblTotalMoneyValue
            // 
            this.lblTotalMoneyValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalMoneyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMoneyValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalMoneyValue.Location = new System.Drawing.Point(215, 56);
            this.lblTotalMoneyValue.Name = "lblTotalMoneyValue";
            this.lblTotalMoneyValue.Size = new System.Drawing.Size(61, 22);
            this.lblTotalMoneyValue.TabIndex = 7;
            this.lblTotalMoneyValue.Text = "200.000";
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblPayMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayMethod.ForeColor = System.Drawing.Color.White;
            this.lblPayMethod.Location = new System.Drawing.Point(345, 56);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(174, 22);
            this.lblPayMethod.TabIndex = 7;
            this.lblPayMethod.Text = "Phương thức thanh toán";
            this.lblPayMethod.Click += new System.EventHandler(this.lblTotalMoney_Click);
            // 
            // cbxUsertype
            // 
            this.cbxUsertype.BackColor = System.Drawing.Color.Transparent;
            this.cbxUsertype.BorderRadius = 5;
            this.cbxUsertype.BorderThickness = 0;
            this.cbxUsertype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxUsertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxUsertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUsertype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxUsertype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxUsertype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxUsertype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxUsertype.ItemHeight = 30;
            this.cbxUsertype.Location = new System.Drawing.Point(542, 49);
            this.cbxUsertype.Name = "cbxUsertype";
            this.cbxUsertype.Size = new System.Drawing.Size(225, 36);
            this.cbxUsertype.TabIndex = 78;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(90, 183);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(205, 22);
            this.lblConfirmPassword.TabIndex = 79;
            this.lblConfirmPassword.Text = "Nhập mật khẩu để xác nhận:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderRadius = 5;
            this.txtConfirmPassword.BorderThickness = 0;
            this.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPassword.DefaultText = "";
            this.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(317, 176);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PlaceholderText = "";
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 36);
            this.txtConfirmPassword.TabIndex = 80;
            // 
            // lblPayInfo
            // 
            this.lblPayInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblPayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayInfo.ForeColor = System.Drawing.Color.White;
            this.lblPayInfo.Location = new System.Drawing.Point(466, 116);
            this.lblPayInfo.Name = "lblPayInfo";
            this.lblPayInfo.Size = new System.Drawing.Size(301, 22);
            this.lblPayInfo.TabIndex = 7;
            this.lblPayInfo.Text = "Vui lòng chuẩn bị tiền vào ngày nhận hàng";
            this.lblPayInfo.Click += new System.EventHandler(this.lblTotalMoney_Click);
            // 
            // FPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(800, 287);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.cbxUsertype);
            this.Controls.Add(this.lblTotalMoneyValue);
            this.Controls.Add(this.lblPayInfo);
            this.Controls.Add(this.lblPayMethod);
            this.Controls.Add(this.lblTotalMoney);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPayment";
            this.Load += new System.EventHandler(this.FPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private System.Windows.Forms.Timer timerClose;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMoney;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalMoneyValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPayMethod;
        private Guna.UI2.WinForms.Guna2ComboBox cbxUsertype;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPayInfo;
    }
}