using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FCustomer : Form {
        public FCustomer() {
            InitializeComponent();
        }

        private Form activeForm;
        private Guna2GradientButton currentButton;

        private void OpenChildForm(Form childForm, string title) {
            if(activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            lblTitle.Text = title;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(childForm);
            this.panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnSearchProduct_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FSearchProduct(), "Tìm kiếm sản phẩm");
                currentButton = (Guna2GradientButton)sender;
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
        }

        private void panelContent_Paint(object sender, PaintEventArgs e) {
        }

        private void timerClose_Tick(object sender, EventArgs e) {
            if(this.Opacity > 0.0) {
                this.Opacity -= 0.25;
            } else {
                timerClose.Stop();
                Application.Exit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            timerClose.Start();
        }

        private void btnCart_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FCart(), "Giỏ hàng");
                currentButton = (Guna2GradientButton)sender;
            }
        }
    }
}
