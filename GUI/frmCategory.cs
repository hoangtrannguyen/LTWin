using System;
using System.Windows.Forms;

namespace GUI {
    public partial class frmCategory : Form {
        public frmCategory() {
            InitializeComponent();
        }

        private void frmCategory_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        private void btnAddCategory_Click(object sender, EventArgs e) {
            (new frmCategoryModule()).ShowDialog();
        }
    }
}
