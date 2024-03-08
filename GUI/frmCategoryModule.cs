using System;
using System.Windows.Forms;

namespace GUI {
    public partial class frmCategoryModule : Form {
        public frmCategoryModule() {
            InitializeComponent();
        }

        private void frmCategoryModule_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
    }
}
