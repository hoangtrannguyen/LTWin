namespace GUI {
    partial class FHomePageAdmin {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHomePageAdmin));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title15 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title16 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelLowStockProduct = new System.Windows.Forms.Panel();
            this.dgvUnderstock = new System.Windows.Forms.DataGridView();
            this.lblLowStockProduct = new System.Windows.Forms.Label();
            this.panelNumberOfOrders = new System.Windows.Forms.Panel();
            this.lblOrderPercent = new System.Windows.Forms.Label();
            this.lblNumOfOrdersValue = new System.Windows.Forms.Label();
            this.lblNumberOfOrders = new System.Windows.Forms.Label();
            this.btnOkCustomDate = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblRevenvuePercent = new System.Windows.Forms.Label();
            this.lblTotalRevenueValue = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.panelTotalRenvenue = new System.Windows.Forms.Panel();
            this.panelTotalCounters = new System.Windows.Forms.Panel();
            this.lblNumProducts = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblTotalCounter = new System.Windows.Forms.Label();
            this.lblNumCustomers = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblDash = new System.Windows.Forms.Label();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblProfitPercent = new System.Windows.Forms.Label();
            this.chartGrossRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTotalProfit = new System.Windows.Forms.Panel();
            this.lblTotalProfitValue = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnCustomDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnToday = new Guna.UI2.WinForms.Guna2Button();
            this.btnLast7Days = new Guna.UI2.WinForms.Guna2Button();
            this.btnLast30Days = new Guna.UI2.WinForms.Guna2Button();
            this.btnThisMonth = new Guna.UI2.WinForms.Guna2Button();
            this.panelLowStockProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).BeginInit();
            this.panelNumberOfOrders.SuspendLayout();
            this.panelTotalRenvenue.SuspendLayout();
            this.panelTotalCounters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).BeginInit();
            this.panelTotalProfit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLowStockProduct
            // 
            this.panelLowStockProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panelLowStockProduct.Controls.Add(this.dgvUnderstock);
            this.panelLowStockProduct.Controls.Add(this.lblLowStockProduct);
            this.panelLowStockProduct.Location = new System.Drawing.Point(253, 407);
            this.panelLowStockProduct.Margin = new System.Windows.Forms.Padding(5);
            this.panelLowStockProduct.Name = "panelLowStockProduct";
            this.panelLowStockProduct.Size = new System.Drawing.Size(440, 212);
            this.panelLowStockProduct.TabIndex = 47;
            // 
            // dgvUnderstock
            // 
            this.dgvUnderstock.AllowUserToResizeRows = false;
            this.dgvUnderstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderstock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dgvUnderstock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnderstock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnderstock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnderstock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvUnderstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(122)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnderstock.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvUnderstock.EnableHeadersVisualStyles = false;
            this.dgvUnderstock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dgvUnderstock.Location = new System.Drawing.Point(15, 45);
            this.dgvUnderstock.Name = "dgvUnderstock";
            this.dgvUnderstock.RowHeadersVisible = false;
            this.dgvUnderstock.RowTemplate.Height = 35;
            this.dgvUnderstock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnderstock.Size = new System.Drawing.Size(310, 155);
            this.dgvUnderstock.TabIndex = 3;
            // 
            // lblLowStockProduct
            // 
            this.lblLowStockProduct.AutoSize = true;
            this.lblLowStockProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLowStockProduct.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLowStockProduct.Location = new System.Drawing.Point(10, 10);
            this.lblLowStockProduct.Name = "lblLowStockProduct";
            this.lblLowStockProduct.Size = new System.Drawing.Size(188, 20);
            this.lblLowStockProduct.TabIndex = 2;
            this.lblLowStockProduct.Text = "Sản phẩm số lượng còn ít";
            // 
            // panelNumberOfOrders
            // 
            this.panelNumberOfOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panelNumberOfOrders.Controls.Add(this.lblOrderPercent);
            this.panelNumberOfOrders.Controls.Add(this.lblNumOfOrdersValue);
            this.panelNumberOfOrders.Controls.Add(this.lblNumberOfOrders);
            this.panelNumberOfOrders.Location = new System.Drawing.Point(13, 59);
            this.panelNumberOfOrders.Margin = new System.Windows.Forms.Padding(5);
            this.panelNumberOfOrders.Name = "panelNumberOfOrders";
            this.panelNumberOfOrders.Size = new System.Drawing.Size(326, 73);
            this.panelNumberOfOrders.TabIndex = 44;
            // 
            // lblOrderPercent
            // 
            this.lblOrderPercent.AutoSize = true;
            this.lblOrderPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblOrderPercent.Location = new System.Drawing.Point(167, 27);
            this.lblOrderPercent.Name = "lblOrderPercent";
            this.lblOrderPercent.Size = new System.Drawing.Size(50, 20);
            this.lblOrderPercent.TabIndex = 2;
            this.lblOrderPercent.Text = "+15%";
            // 
            // lblNumOfOrdersValue
            // 
            this.lblNumOfOrdersValue.AutoSize = true;
            this.lblNumOfOrdersValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfOrdersValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumOfOrdersValue.Location = new System.Drawing.Point(37, 34);
            this.lblNumOfOrdersValue.Name = "lblNumOfOrdersValue";
            this.lblNumOfOrdersValue.Size = new System.Drawing.Size(78, 25);
            this.lblNumOfOrdersValue.TabIndex = 1;
            this.lblNumOfOrdersValue.Text = "100000";
            // 
            // lblNumberOfOrders
            // 
            this.lblNumberOfOrders.AutoSize = true;
            this.lblNumberOfOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblNumberOfOrders.Location = new System.Drawing.Point(17, 14);
            this.lblNumberOfOrders.Name = "lblNumberOfOrders";
            this.lblNumberOfOrders.Size = new System.Drawing.Size(143, 20);
            this.lblNumberOfOrders.TabIndex = 0;
            this.lblNumberOfOrders.Text = "Số lượng đơn hàng";
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            this.btnOkCustomDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOkCustomDate.FlatAppearance.BorderSize = 0;
            this.btnOkCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkCustomDate.Image = ((System.Drawing.Image)(resources.GetObject("btnOkCustomDate.Image")));
            this.btnOkCustomDate.Location = new System.Drawing.Point(440, 14);
            this.btnOkCustomDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(35, 35);
            this.btnOkCustomDate.TabIndex = 43;
            this.btnOkCustomDate.UseVisualStyleBackColor = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(333, 23);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(122, 20);
            this.dtpEndDate.TabIndex = 37;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(165, 23);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(122, 20);
            this.dtpStartDate.TabIndex = 36;
            // 
            // lblRevenvuePercent
            // 
            this.lblRevenvuePercent.AutoSize = true;
            this.lblRevenvuePercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenvuePercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblRevenvuePercent.Location = new System.Drawing.Point(206, 27);
            this.lblRevenvuePercent.Name = "lblRevenvuePercent";
            this.lblRevenvuePercent.Size = new System.Drawing.Size(50, 20);
            this.lblRevenvuePercent.TabIndex = 3;
            this.lblRevenvuePercent.Text = "+21%";
            // 
            // lblTotalRevenueValue
            // 
            this.lblTotalRevenueValue.AutoSize = true;
            this.lblTotalRevenueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenueValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalRevenueValue.Location = new System.Drawing.Point(74, 34);
            this.lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            this.lblTotalRevenueValue.Size = new System.Drawing.Size(78, 25);
            this.lblTotalRevenueValue.TabIndex = 1;
            this.lblTotalRevenueValue.Text = "100000";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(75, 14);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(121, 20);
            this.lblTotalRevenue.TabIndex = 0;
            this.lblTotalRevenue.Text = "Tổng doanh thu";
            // 
            // panelTotalRenvenue
            // 
            this.panelTotalRenvenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panelTotalRenvenue.Controls.Add(this.lblRevenvuePercent);
            this.panelTotalRenvenue.Controls.Add(this.lblTotalRevenueValue);
            this.panelTotalRenvenue.Controls.Add(this.lblTotalRevenue);
            this.panelTotalRenvenue.Location = new System.Drawing.Point(349, 59);
            this.panelTotalRenvenue.Margin = new System.Windows.Forms.Padding(5);
            this.panelTotalRenvenue.Name = "panelTotalRenvenue";
            this.panelTotalRenvenue.Size = new System.Drawing.Size(279, 73);
            this.panelTotalRenvenue.TabIndex = 45;
            // 
            // panelTotalCounters
            // 
            this.panelTotalCounters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panelTotalCounters.Controls.Add(this.lblNumProducts);
            this.panelTotalCounters.Controls.Add(this.lblProducts);
            this.panelTotalCounters.Controls.Add(this.lblTotalCounter);
            this.panelTotalCounters.Controls.Add(this.lblNumCustomers);
            this.panelTotalCounters.Controls.Add(this.lblCustomers);
            this.panelTotalCounters.Location = new System.Drawing.Point(13, 407);
            this.panelTotalCounters.Margin = new System.Windows.Forms.Padding(5);
            this.panelTotalCounters.Name = "panelTotalCounters";
            this.panelTotalCounters.Size = new System.Drawing.Size(230, 212);
            this.panelTotalCounters.TabIndex = 46;
            // 
            // lblNumProducts
            // 
            this.lblNumProducts.AutoSize = true;
            this.lblNumProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProducts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumProducts.Location = new System.Drawing.Point(76, 147);
            this.lblNumProducts.Name = "lblNumProducts";
            this.lblNumProducts.Size = new System.Drawing.Size(78, 25);
            this.lblNumProducts.TabIndex = 6;
            this.lblNumProducts.Text = "100000";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblProducts.Location = new System.Drawing.Point(74, 117);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(82, 20);
            this.lblProducts.TabIndex = 5;
            this.lblProducts.Text = "Sản phẩm";
            // 
            // lblTotalCounter
            // 
            this.lblTotalCounter.AutoSize = true;
            this.lblTotalCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCounter.ForeColor = System.Drawing.Color.White;
            this.lblTotalCounter.Location = new System.Drawing.Point(47, 10);
            this.lblTotalCounter.Name = "lblTotalCounter";
            this.lblTotalCounter.Size = new System.Drawing.Size(137, 25);
            this.lblTotalCounter.TabIndex = 2;
            this.lblTotalCounter.Text = "Tổng số lượng";
            // 
            // lblNumCustomers
            // 
            this.lblNumCustomers.AutoSize = true;
            this.lblNumCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCustomers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumCustomers.Location = new System.Drawing.Point(76, 77);
            this.lblNumCustomers.Name = "lblNumCustomers";
            this.lblNumCustomers.Size = new System.Drawing.Size(78, 25);
            this.lblNumCustomers.TabIndex = 1;
            this.lblNumCustomers.Text = "100000";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblCustomers.Location = new System.Drawing.Point(68, 45);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(94, 20);
            this.lblCustomers.TabIndex = 0;
            this.lblCustomers.Text = "Khách hàng";
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblDash.Location = new System.Drawing.Point(300, 23);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(14, 20);
            this.lblDash.TabIndex = 33;
            this.lblDash.Text = "-";
            // 
            // chartTopProducts
            // 
            this.chartTopProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea15.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea15);
            legend15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend15.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend15.ForeColor = System.Drawing.Color.Silver;
            legend15.IsTextAutoFit = false;
            legend15.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend15);
            this.chartTopProducts.Location = new System.Drawing.Point(703, 142);
            this.chartTopProducts.Margin = new System.Windows.Forms.Padding(5);
            this.chartTopProducts.Name = "chartTopProducts";
            this.chartTopProducts.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartTopProducts.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(160)))), ((int)(((byte)(139))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(180)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(153)))), ((int)(((byte)(254)))))};
            series15.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series15.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            series15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            series15.BorderWidth = 8;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series15.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            series15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series15.IsValueShownAsLabel = true;
            series15.LabelForeColor = System.Drawing.Color.White;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chartTopProducts.Series.Add(series15);
            this.chartTopProducts.Size = new System.Drawing.Size(320, 477);
            this.chartTopProducts.TabIndex = 50;
            this.chartTopProducts.Text = "chartTopProducts";
            title15.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title15.ForeColor = System.Drawing.Color.WhiteSmoke;
            title15.Name = "Title1";
            title15.Text = "Top 5 sản phẩm bán chạy";
            this.chartTopProducts.Titles.Add(title15);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblStartDate.Location = new System.Drawing.Point(160, 23);
            this.lblStartDate.MinimumSize = new System.Drawing.Size(130, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(130, 20);
            this.lblStartDate.TabIndex = 35;
            this.lblStartDate.Text = "Mar 03, 2024";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProfitPercent
            // 
            this.lblProfitPercent.AutoSize = true;
            this.lblProfitPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblProfitPercent.Location = new System.Drawing.Point(219, 27);
            this.lblProfitPercent.Name = "lblProfitPercent";
            this.lblProfitPercent.Size = new System.Drawing.Size(50, 20);
            this.lblProfitPercent.TabIndex = 3;
            this.lblProfitPercent.Text = "+19%";
            // 
            // chartGrossRevenue
            // 
            this.chartGrossRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea16.AxisX.IsMarginVisible = false;
            chartArea16.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea16.AxisX.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX.LineWidth = 0;
            chartArea16.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea16.AxisX.MajorGrid.LineWidth = 0;
            chartArea16.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea16.AxisX.MajorTickMark.Size = 3F;
            chartArea16.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea16.AxisY.LabelStyle.Format = "${0:0,}K";
            chartArea16.AxisY.LineColor = System.Drawing.Color.White;
            chartArea16.AxisY.LineWidth = 0;
            chartArea16.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea16.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            chartArea16.AxisY.MajorTickMark.LineWidth = 0;
            chartArea16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea16.Name = "ChartArea1";
            this.chartGrossRevenue.ChartAreas.Add(chartArea16);
            legend16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend16.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            legend16.IsTextAutoFit = false;
            legend16.Name = "Legend1";
            this.chartGrossRevenue.Legends.Add(legend16);
            this.chartGrossRevenue.Location = new System.Drawing.Point(13, 142);
            this.chartGrossRevenue.Margin = new System.Windows.Forms.Padding(5);
            this.chartGrossRevenue.Name = "chartGrossRevenue";
            series16.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series16.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            series16.BorderWidth = 3;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series16.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(127)))));
            series16.Legend = "Legend1";
            series16.MarkerSize = 10;
            series16.Name = "Series1";
            this.chartGrossRevenue.Series.Add(series16);
            this.chartGrossRevenue.Size = new System.Drawing.Size(680, 255);
            this.chartGrossRevenue.TabIndex = 49;
            this.chartGrossRevenue.Text = "chartGrossRevenue";
            title16.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title16.ForeColor = System.Drawing.Color.WhiteSmoke;
            title16.Name = "Title1";
            title16.Text = "Tổng thu nhập";
            this.chartGrossRevenue.Titles.Add(title16);
            // 
            // panelTotalProfit
            // 
            this.panelTotalProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panelTotalProfit.Controls.Add(this.lblProfitPercent);
            this.panelTotalProfit.Controls.Add(this.lblTotalProfitValue);
            this.panelTotalProfit.Controls.Add(this.lblTotalProfit);
            this.panelTotalProfit.Location = new System.Drawing.Point(638, 58);
            this.panelTotalProfit.Margin = new System.Windows.Forms.Padding(5);
            this.panelTotalProfit.Name = "panelTotalProfit";
            this.panelTotalProfit.Size = new System.Drawing.Size(385, 73);
            this.panelTotalProfit.TabIndex = 48;
            // 
            // lblTotalProfitValue
            // 
            this.lblTotalProfitValue.AutoSize = true;
            this.lblTotalProfitValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.lblTotalProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfitValue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalProfitValue.Location = new System.Drawing.Point(74, 34);
            this.lblTotalProfitValue.Name = "lblTotalProfitValue";
            this.lblTotalProfitValue.Size = new System.Drawing.Size(78, 25);
            this.lblTotalProfitValue.TabIndex = 1;
            this.lblTotalProfitValue.Text = "100000";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblTotalProfit.Location = new System.Drawing.Point(75, 14);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(113, 20);
            this.lblTotalProfit.TabIndex = 0;
            this.lblTotalProfit.Text = "Tổng lợi nhuận";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.lblEndDate.Location = new System.Drawing.Point(328, 23);
            this.lblEndDate.MinimumSize = new System.Drawing.Size(130, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(130, 20);
            this.lblEndDate.TabIndex = 34;
            this.lblEndDate.Text = "Mar 03, 2024";
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnCustomDate.BorderThickness = 1;
            this.btnCustomDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnCustomDate.Location = new System.Drawing.Point(12, 14);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(128, 35);
            this.btnCustomDate.TabIndex = 51;
            this.btnCustomDate.Text = "Chọn ngày";
            // 
            // btnToday
            // 
            this.btnToday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnToday.BorderThickness = 1;
            this.btnToday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToday.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnToday.Location = new System.Drawing.Point(483, 14);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(122, 35);
            this.btnToday.TabIndex = 51;
            this.btnToday.Text = "Hôm nay";
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnLast7Days.BorderThickness = 1;
            this.btnLast7Days.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLast7Days.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLast7Days.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLast7Days.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLast7Days.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnLast7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast7Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnLast7Days.Location = new System.Drawing.Point(617, 14);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(122, 35);
            this.btnLast7Days.TabIndex = 51;
            this.btnLast7Days.Text = "7 ngày trước";
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnLast30Days.BorderThickness = 1;
            this.btnLast30Days.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLast30Days.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLast30Days.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLast30Days.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLast30Days.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnLast30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast30Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnLast30Days.Location = new System.Drawing.Point(751, 14);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(131, 35);
            this.btnLast30Days.TabIndex = 51;
            this.btnLast30Days.Text = "30 ngày trước";
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(83)))), ((int)(((byte)(255)))));
            this.btnThisMonth.BorderThickness = 1;
            this.btnThisMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThisMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThisMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThisMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThisMonth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.btnThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.btnThisMonth.Location = new System.Drawing.Point(894, 14);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(122, 35);
            this.btnThisMonth.TabIndex = 51;
            this.btnThisMonth.Text = "Tháng này";
            // 
            // FHomePageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1036, 633);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnCustomDate);
            this.Controls.Add(this.panelLowStockProduct);
            this.Controls.Add(this.panelNumberOfOrders);
            this.Controls.Add(this.btnOkCustomDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.panelTotalRenvenue);
            this.Controls.Add(this.panelTotalCounters);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.chartTopProducts);
            this.Controls.Add(this.chartGrossRevenue);
            this.Controls.Add(this.panelTotalProfit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FHomePageAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHomePageAdmin";
            this.Load += new System.EventHandler(this.FHomePageAdmin_Load);
            this.panelLowStockProduct.ResumeLayout(false);
            this.panelLowStockProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).EndInit();
            this.panelNumberOfOrders.ResumeLayout(false);
            this.panelNumberOfOrders.PerformLayout();
            this.panelTotalRenvenue.ResumeLayout(false);
            this.panelTotalRenvenue.PerformLayout();
            this.panelTotalCounters.ResumeLayout(false);
            this.panelTotalCounters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenue)).EndInit();
            this.panelTotalProfit.ResumeLayout(false);
            this.panelTotalProfit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLowStockProduct;
        private System.Windows.Forms.DataGridView dgvUnderstock;
        private System.Windows.Forms.Label lblLowStockProduct;
        private System.Windows.Forms.Panel panelNumberOfOrders;
        private System.Windows.Forms.Label lblOrderPercent;
        private System.Windows.Forms.Label lblNumOfOrdersValue;
        private System.Windows.Forms.Label lblNumberOfOrders;
        private System.Windows.Forms.Button btnOkCustomDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblRevenvuePercent;
        private System.Windows.Forms.Label lblTotalRevenueValue;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Panel panelTotalRenvenue;
        private System.Windows.Forms.Panel panelTotalCounters;
        private System.Windows.Forms.Label lblNumProducts;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblTotalCounter;
        private System.Windows.Forms.Label lblNumCustomers;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblProfitPercent;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenue;
        private System.Windows.Forms.Panel panelTotalProfit;
        private System.Windows.Forms.Label lblTotalProfitValue;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label lblEndDate;
        private Guna.UI2.WinForms.Guna2Button btnCustomDate;
        private Guna.UI2.WinForms.Guna2Button btnToday;
        private Guna.UI2.WinForms.Guna2Button btnLast7Days;
        private Guna.UI2.WinForms.Guna2Button btnLast30Days;
        private Guna.UI2.WinForms.Guna2Button btnThisMonth;
    }
}