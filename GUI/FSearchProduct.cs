using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FSearchProduct : Form {
        public FSearchProduct() {
            InitializeComponent();
        }

        private void frmSearchProduct_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
    }
}
