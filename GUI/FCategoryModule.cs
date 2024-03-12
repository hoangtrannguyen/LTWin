using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FCategoryModule : Form {
        public FCategoryModule() {
            InitializeComponent();
        }

        private void FCategoryModule_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
        }
    }
}
