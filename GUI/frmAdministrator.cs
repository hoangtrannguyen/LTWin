using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace GUI {
    public partial class frmAdministrator : Form {
        public frmAdministrator() {
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
            OpenChildForm(new frmProduct(), "Sản phẩm");
                currentButton = (Guna2GradientButton)sender;
            }
        }

    }
}
