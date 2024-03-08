using System;
using System.Windows.Forms;

namespace GUI {
    public partial class frmBrand : Form {
        public frmBrand() {
            InitializeComponent();
        }

        private void btnAddBrand_Click(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
            (new FBrandModule()).ShowDialog();
        }
    }
}
