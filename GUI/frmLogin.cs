using System;
using System.Windows.Forms;

namespace GUI {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            (new frmRegister()).ShowDialog();  
        }

        private void frmLogin_Load(object sender, EventArgs e) {
             WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
        }
    }
}
