﻿using System.Windows.Forms;

namespace GUI {
    public partial class frmRegister : Form {
        public frmRegister() {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, System.EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
    }
}
