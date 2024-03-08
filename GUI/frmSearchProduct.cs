using System;
using System.Windows.Forms;

namespace GUI {
    public partial class frmSearchProduct : Form {
        public frmSearchProduct() {
            InitializeComponent();
        }

        private void frmSearchProduct_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
    }
}
