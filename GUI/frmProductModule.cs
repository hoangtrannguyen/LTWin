﻿using System;
using System.Windows.Forms;

namespace GUI {
    public partial class frmProductModule : Form {
        public frmProductModule() {
            InitializeComponent();
        }

        private void frmProductModule_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
    }
}
