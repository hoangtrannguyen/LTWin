using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FBrand : Form {
        public FBrand() {
            InitializeComponent();
        }

        private void btnAddBrand_Click(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
            (new FBrandModule()).ShowDialog();
        }
    }
}
