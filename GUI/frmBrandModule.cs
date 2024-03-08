using System;
using System.Windows.Forms;

namespace GUI {
    public partial class frmBrandModule : Form {
        public frmBrandModule() {
            InitializeComponent();
        }

        private void frmBrandModule_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
    }
}
