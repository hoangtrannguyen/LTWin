using Guna.UI2.WinForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FSeller : Form {
        public FSeller() {
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

        private async void FSeller_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
            await Task.Delay(100);

            OpenChildForm(new FHomePageSeller(), "Trang chủ");
            currentButton = btnHomePage;
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

        private void btnHomePage_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FHomePageSeller(), "Trang chủ");
                currentButton = (Guna2GradientButton)sender;
            }
        }
        bool isDropdown = false;

        private void btnProduct_Click(object sender, EventArgs e) {
            productTransition.Start();
        }

        private void productTransition_Tick(object sender, EventArgs e) {
            if(!isDropdown) {
                panelProduct.Height += 10;
                if(panelProduct.Height > 180) {
                    productTransition.Stop();
                    isDropdown = true;
                }
            } else {
                panelProduct.Height -= 10;

                if(panelProduct.Height < 55) {
                    productTransition.Stop();
                    isDropdown = false;
                }
            }
        }

        private void btnProductList_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FProductList(), "Danh sách sản phẩm");
                currentButton = (Guna2GradientButton)sender;
            }
        }

        private void btnCategory_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FCategory(), "Danh mục");
                currentButton = (Guna2GradientButton)sender;
            }
        }

        private void btnBrand_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FBrand(), "Thương hiệu");
                currentButton = (Guna2GradientButton)sender;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FInOrderSeller(), "Đơn hàng");
                currentButton = (Guna2GradientButton)sender;
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FStatistics(), "Thống kê");
                currentButton = (Guna2GradientButton)sender;
            }
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FUpdateUserInfo(), "Cập nhật thông tin");
                currentButton = (Guna2GradientButton)sender;
            }
        }
    }
}
