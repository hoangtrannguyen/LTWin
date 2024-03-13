namespace GUI {
    partial class FFeedback {
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
            this.ptrbProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblProductDescription = new System.Windows.Forms.Label();
            this.lblRating = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ratingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblRatingValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtFeedback = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblFeedback = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.FFeedbackDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnSendFeedback = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // ptrbProduct
            // 
            this.ptrbProduct.BackColor = System.Drawing.Color.Transparent;
            this.ptrbProduct.Image = global::GUI.Properties.Resources.xe_dieu_khien;
            this.ptrbProduct.ImageRotate = 0F;
            this.ptrbProduct.Location = new System.Drawing.Point(43, 51);
            this.ptrbProduct.Name = "ptrbProduct";
            this.ptrbProduct.Size = new System.Drawing.Size(114, 116);
            this.ptrbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrbProduct.TabIndex = 24;
            this.ptrbProduct.TabStop = false;
            // 
            // lblProductDescription
            // 
            this.lblProductDescription.AutoEllipsis = true;
            this.lblProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDescription.ForeColor = System.Drawing.Color.White;
            this.lblProductDescription.Location = new System.Drawing.Point(178, 51);
            this.lblProductDescription.Name = "lblProductDescription";
            this.lblProductDescription.Size = new System.Drawing.Size(570, 84);
            this.lblProductDescription.TabIndex = 33;
            this.lblProductDescription.Text = "Đồ chơi điều khiển ô tô chạy dành cho trẻ em, đồ chơi ô tô điều khiển từ xa có th" +
    "ể sạc lại, đồ chơi bé trai, xe đồ chơi.";
            this.lblProductDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRating
            // 
            this.lblRating.BackColor = System.Drawing.Color.Transparent;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRating.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRating.Location = new System.Drawing.Point(182, 138);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(154, 22);
            this.lblRating.TabIndex = 40;
            this.lblRating.Text = "Chất lượng sản phẩm";
            // 
            // ratingStar
            // 
            this.ratingStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ratingStar.Location = new System.Drawing.Point(356, 140);
            this.ratingStar.Name = "ratingStar";
            this.ratingStar.Size = new System.Drawing.Size(96, 20);
            this.ratingStar.TabIndex = 41;
            // 
            // lblRatingValue
            // 
            this.lblRatingValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRatingValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRatingValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRatingValue.Location = new System.Drawing.Point(474, 140);
            this.lblRatingValue.Name = "lblRatingValue";
            this.lblRatingValue.Size = new System.Drawing.Size(65, 22);
            this.lblRatingValue.TabIndex = 42;
            this.lblRatingValue.Text = "Tuyệt vời";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Animated = true;
            this.txtFeedback.AutoScroll = true;
            this.txtFeedback.BorderThickness = 0;
            this.txtFeedback.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFeedback.DefaultText = "";
            this.txtFeedback.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFeedback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFeedback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFeedback.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFeedback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.txtFeedback.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.ForeColor = System.Drawing.Color.White;
            this.txtFeedback.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFeedback.Location = new System.Drawing.Point(42, 190);
            this.txtFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.PasswordChar = '\0';
            this.txtFeedback.PlaceholderText = "Hãy chia sẻ những điều bạn thích về sản phẩm này với những người mua khác nhé.";
            this.txtFeedback.SelectedText = "";
            this.txtFeedback.Size = new System.Drawing.Size(686, 187);
            this.txtFeedback.TabIndex = 43;
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
            this.btnClose.Location = new System.Drawing.Point(725, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 29);
            this.btnClose.TabIndex = 44;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.BackColor = System.Drawing.Color.Transparent;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFeedback.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFeedback.Location = new System.Drawing.Point(43, 7);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(141, 22);
            this.lblFeedback.TabIndex = 40;
            this.lblFeedback.Text = "Đánh giá sản phẩm";
            // 
            // timerClose
            // 
            this.timerClose.Interval = 10;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // FFeedbackDragControl
            // 
            this.FFeedbackDragControl.DockIndicatorTransparencyValue = 0.6D;
            this.FFeedbackDragControl.TargetControl = this;
            this.FFeedbackDragControl.UseTransparentDrag = true;
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendFeedback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendFeedback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendFeedback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendFeedback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendFeedback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnSendFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFeedback.ForeColor = System.Drawing.Color.White;
            this.btnSendFeedback.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.btnSendFeedback.Location = new System.Drawing.Point(295, 398);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(180, 45);
            this.btnSendFeedback.TabIndex = 45;
            this.btnSendFeedback.Text = "Gửi đánh giá";
            // 
            // FFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(771, 460);
            this.Controls.Add(this.btnSendFeedback);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.lblRatingValue);
            this.Controls.Add(this.ratingStar);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblProductDescription);
            this.Controls.Add(this.ptrbProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFeedback";
            this.Load += new System.EventHandler(this.FFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrbProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox ptrbProduct;
        private System.Windows.Forms.Label lblProductDescription;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRating;
        private Guna.UI2.WinForms.Guna2RatingStar ratingStar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRatingValue;
        private Guna.UI2.WinForms.Guna2TextBox txtFeedback;
        private Guna.UI2.WinForms.Guna2ControlBox btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFeedback;
        private System.Windows.Forms.Timer timerClose;
        private Guna.UI2.WinForms.Guna2DragControl FFeedbackDragControl;
        private Guna.UI2.WinForms.Guna2Button btnSendFeedback;
    }
}