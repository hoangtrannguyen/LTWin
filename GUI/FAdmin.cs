using Guna.UI2.WinForms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FAdmin : Form {
        public FAdmin() {
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
        private void btnProduct_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FProduct(), "Sản phẩm");
                currentButton = (Guna2GradientButton)sender;
            }
        }

        private async void FAdmin_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
            await Task.Delay(100);

            OpenChildForm(new FHomePageAdmin(), "Trang chủ");
            currentButton = btnHomePage;
        }

        private void timerClose_Tick(object sender, EventArgs e) {
            if(this.Opacity > 0.0) {
                this.Opacity -= 0.5;
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
                OpenChildForm(new FHomePageAdmin(), "Trang chủ");
                currentButton = (Guna2GradientButton)sender;
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e) {
            if(currentButton != (Guna2GradientButton)sender) {
                OpenChildForm(new FStatistics(), "Thống kê");
                currentButton = (Guna2GradientButton)sender;
            }
        }

    }
}
