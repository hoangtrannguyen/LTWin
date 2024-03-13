using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FHomePageAdmin : Form {
        public FHomePageAdmin() {
            InitializeComponent();
        }

        private void FHomePageAdmin_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
        }
    }
}
