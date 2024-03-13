using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FHomePageSeller : Form {
        public FHomePageSeller() {
            InitializeComponent();
        }

        private void FHomePageSeller_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
        }


    }
}
