namespace GUI {
    partial class FAdmin {
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
            this.productTransition = new System.Windows.Forms.Timer(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.panelSlide = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUserSettings = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.ptrbAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.FAdminDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.flowPanelUser = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblLevel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelPagination = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.panelSlide.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvatar)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.panelPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // productTransition
            // 
            this.productTransition.Interval = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(81, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 21);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRole.Location = new System.Drawing.Point(81, 124);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(56, 21);
            this.lblRole.TabIndex = 13;
            this.lblRole.Text = "Admin";
            // 
            // timerClose
            // 
            this.timerClose.Interval = 10;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // panelSlide
            // 
            this.panelSlide.AutoScroll = true;
            this.panelSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panelSlide.Controls.Add(this.btnLogout);
            this.panelSlide.Controls.Add(this.btnUserSettings);
            this.panelSlide.Controls.Add(this.panelInfo);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(213, 666);
            this.panelSlide.TabIndex = 9;
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnLogout.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnLogout.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnLogout.Image = global::GUI.Properties.Resources.logout_icon;
            this.btnLogout.Location = new System.Drawing.Point(0, 198);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(213, 45);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseTransparentBackground = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.Animated = true;
            this.btnUserSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnUserSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnUserSettings.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnUserSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserSettings.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnUserSettings.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnUserSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSettings.ForeColor = System.Drawing.Color.White;
            this.btnUserSettings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(62)))), ((int)(((byte)(103)))));
            this.btnUserSettings.Image = global::GUI.Properties.Resources.user_settings_icon;
            this.btnUserSettings.Location = new System.Drawing.Point(0, 153);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(213, 45);
            this.btnUserSettings.TabIndex = 2;
            this.btnUserSettings.Text = "Quản lý người dùng";
            this.btnUserSettings.UseTransparentBackground = true;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.lblName);
            this.panelInfo.Controls.Add(this.ptrbAvatar);
            this.panelInfo.Controls.Add(this.lblRole);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(213, 153);
            this.panelInfo.TabIndex = 0;
            // 
            // ptrbAvatar
            // 
            this.ptrbAvatar.Image = global::GUI.Properties.Resources.user_icon;
            this.ptrbAvatar.ImageRotate = 0F;
            this.ptrbAvatar.Location = new System.Drawing.Point(64, 6);
            this.ptrbAvatar.Name = "ptrbAvatar";
            this.ptrbAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ptrbAvatar.Size = new System.Drawing.Size(86, 91);
            this.ptrbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrbAvatar.TabIndex = 16;
            this.ptrbAvatar.TabStop = false;
            // 
            // FAdminDragControl
            // 
            this.FAdminDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.FAdminDragControl.TargetControl = this.lblTitle;
            this.FAdminDragControl.UseTransparentDrag = true;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(382, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 26);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Quản lý người dùng";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(213, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1036, 37);
            this.panelTitle.TabIndex = 12;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Animated = true;
            this.btnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(936, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 37);
            this.btnMinimize.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.CausesValidation = false;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomClick = true;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(986, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 37);
            this.btnClose.TabIndex = 6;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // flowPanelUser
            // 
            this.flowPanelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.flowPanelUser.Location = new System.Drawing.Point(213, 80);
            this.flowPanelUser.Name = "flowPanelUser";
            this.flowPanelUser.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flowPanelUser.Size = new System.Drawing.Size(1036, 547);
            this.flowPanelUser.TabIndex = 13;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.guna2Panel3.Controls.Add(this.lblStatus);
            this.guna2Panel3.Controls.Add(this.lblLevel);
            this.guna2Panel3.Controls.Add(this.lblEmail);
            this.guna2Panel3.Controls.Add(this.lblUser);
            this.guna2Panel3.Controls.Add(this.lblNo);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(213, 37);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1036, 46);
            this.guna2Panel3.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(743, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 22);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Trạng thái";
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(586, 13);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(49, 22);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Quyền";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(387, 13);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 22);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(105, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(84, 22);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Người dùng";
            // 
            // lblNo
            // 
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.White;
            this.lblNo.Location = new System.Drawing.Point(21, 13);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(32, 22);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "STT";
            // 
            // panelPagination
            // 
            this.panelPagination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.panelPagination.Controls.Add(this.btnPrevious);
            this.panelPagination.Controls.Add(this.btnNext);
            this.panelPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPagination.Location = new System.Drawing.Point(213, 626);
            this.panelPagination.Name = "panelPagination";
            this.panelPagination.Size = new System.Drawing.Size(1036, 40);
            this.panelPagination.TabIndex = 17;
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
            this.btnPrevious.Location = new System.Drawing.Point(483, 3);
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
            this.btnNext.Location = new System.Drawing.Point(519, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 3;
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1249, 666);
            this.Controls.Add(this.panelPagination);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.flowPanelUser);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdmin";
            this.Load += new System.EventHandler(this.FAdmin_Load);
            this.panelSlide.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbAvatar)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.panelPagination.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer productTransition;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ptrbAvatar;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogout;
        private System.Windows.Forms.Timer timerClose;
        private Guna.UI2.WinForms.Guna2Panel panelSlide;
        private Guna.UI2.WinForms.Guna2GradientButton btnUserSettings;
        private Guna.UI2.WinForms.Guna2Panel panelInfo;
        private Guna.UI2.WinForms.Guna2DragControl FAdminDragControl;
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private Guna.UI2.WinForms.Guna2ControlBox btnMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flowPanelUser;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLevel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNo;
        private Guna.UI2.WinForms.Guna2Panel panelPagination;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
    }
}