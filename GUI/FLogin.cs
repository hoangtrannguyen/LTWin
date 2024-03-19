using System;
using System.Windows.Forms;

namespace GUI {

    public struct ROLE {
        public static readonly string ADMIN = "1";
        public static readonly string SELLER = "2";
        public static readonly string CUSTOMER = "3";
    }

    public partial class FLogin : Form {
        public FLogin() {
            InitializeComponent();
            //ReadSettings();
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

            //if(Properties.Settings.Default.Remember) {
            //    Login();
            //}

        }

        //private void ReadSettings() {
        //    if(Properties.Settings.Default.connStr == true) {
        //        txtEmail.Text = Properties.Settings.Default.Remember;
        //        txtPassword.Text = Properties.Settings.Default.Username;
        //        toggleRemember.Checked = true;
        //    } else {
        //        txtEmail.Text = "";
        //        txtPassword.Text = "";
        //        toggleRemember.Checked = false;
        //    }
        //}

        //private void SaveSettings() {
        //    if(toggleRemember.Checked) {
        //        Properties.Settings.Default.Remember = this.txtEmail.Text;
        //        Properties.Settings.Default.Username = this.txtPassword.Text;
        //        Properties.Settings.Default.connStr = true;
        //        Properties.Settings.Default.Save();
        //    } else {
        //        Properties.Settings.Default.Remember = this.txtEmail.Text;
        //        Properties.Settings.Default.Username = "";
        //        Properties.Settings.Default.connStr = false;
        //        Properties.Settings.Default.Save();
        //    }
        //}

        private void Login() {
            string role = txtEmail.Text;
            //if(Properties.Settings.Default.connStr) {
            //    role = Properties.Settings.Default.Remember;
            //} else {
            //    role = txtEmail.Text;
            //}
            //SaveSettings();
            if(role == ROLE.ADMIN) {
                this.Hide();
                (new FAdmin()).ShowDialog();
            } else if(role == "2") {
                this.Hide();
                (new FSeller()).ShowDialog();
            } else if(role == "3") {
                this.Hide();
                (new FCustomer()).ShowDialog();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            Login();
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e) {
            Login();
        }
    }
}
