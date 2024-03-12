using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FBrandModule : Form {
        public FBrandModule() {
            InitializeComponent();
        }

        private void FBrandModule_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
        }
    }
}
