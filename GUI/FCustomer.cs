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
       

        private void FCustomer_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);

            OpenChildForm(new FHomePageCustomer(), "Trang chủ");
            currentButton = btnHomePage;
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

        private void btnSearchProduct_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FSearchProduct(), "Tìm kiếm sản phẩm");
                currentButton = (Guna2GradientButton)sender;
            }
        }

        private void btnCart_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FCart(), "Giỏ hàng");
                currentButton = (Guna2GradientButton)sender;
            }
        }

        private void btnOrderStatus_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FInOrder(), "Đơn hàng");
                currentButton = (Guna2GradientButton)sender;
            }
        }

        private void btnOrderHistory_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FOrderHistory(), "Lịch sử mua hàng");
                currentButton = (Guna2GradientButton)sender;
            }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FUpdateUserInfo(), "Cập nhật thông tin");
                currentButton = (Guna2GradientButton)sender;
            }
        }

        private void btnHomePage_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FHomePageCustomer(), "Trang chủ");
                currentButton = (Guna2GradientButton)sender;
            }
        }
    }
}
