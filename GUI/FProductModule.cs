using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FProductModule : Form {
        public FProductModule() {
            InitializeComponent();
        }

        private void FProductModule_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
    }
}
