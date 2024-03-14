using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FLogin : Form {
        public FLogin() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            (new FRegister()).ShowDialog();  
        }

        private void FLogin_Load(object sender, EventArgs e) {
             WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
            txtEmail.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string role = txtEmail.Text;
            if(role == "1") {
                (new FAdmin()).ShowDialog();
            } else if(role == "2") {
                (new FSeller()).ShowDialog();
            } else if(role == "3") {
                (new FCustomer()).ShowDialog();
            }
        }
    }
}
