
namespace Student
{
    partial class FHocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gvHocSinh = new System.Windows.Forms.DataGridView();
            this.qLHocSinhDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHocSinhDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocSinhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocSinhDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocSinhDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(79, 88);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(69, 17);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Ho va ten";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(79, 132);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(51, 17);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Dia chi";
            // 
            // lblCmnd
            // 
            this.lblCmnd.AutoSize = true;
            this.lblCmnd.Location = new System.Drawing.Point(79, 192);
            this.lblCmnd.Name = "lblCmnd";
            this.lblCmnd.Size = new System.Drawing.Size(48, 17);
            this.lblCmnd.TabIndex = 2;
            this.lblCmnd.Text = "CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngay thang nam sinh";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(378, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(168, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(168, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(168, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // gvHocSinh
            // 
            this.gvHocSinh.AutoGenerateColumns = false;
            this.gvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHocSinh.DataSource = this.qLHocSinhDataSetBindingSource1;
            this.gvHocSinh.Location = new System.Drawing.Point(383, 69);
            this.gvHocSinh.Name = "gvHocSinh";
            this.gvHocSinh.RowHeadersWidth = 51;
            this.gvHocSinh.RowTemplate.Height = 24;
            this.gvHocSinh.Size = new System.Drawing.Size(317, 228);
            this.gvHocSinh.TabIndex = 11;
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvHocSinh);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCmnd);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTen);
            this.Name = "FHocSinh";
            this.Text = "HocSinh";
            this.Load += new System.EventHandler(this.FHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocSinhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocSinhDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocSinhDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView gvHocSinh;
        private System.Windows.Forms.BindingSource qLHocSinhDataSetBindingSource;
        private QLHocSinhDataSet qLHocSinhDataSet;
        private System.Windows.Forms.BindingSource qLHocSinhDataSetBindingSource1;
    }
}

