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

        private void frmLogin_Load(object sender, EventArgs e) {
             WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
        }
    }
}
