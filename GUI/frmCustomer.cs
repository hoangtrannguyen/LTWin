using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class frmCustomer : Form {
        public frmCustomer() {
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
                OpenChildForm(new frmSearchProduct(), "Tìm kiếm sản phẩm");
                currentButton = (Guna2GradientButton)sender;
            }
        }
    }
}
