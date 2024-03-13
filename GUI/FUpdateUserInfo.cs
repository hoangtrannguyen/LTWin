using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FUpdateUserInfo : Form {
        public FUpdateUserInfo() {
            InitializeComponent();
        }

        private void FUpdateUserInfo_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.VER_POSITIVE);
        }
    }
}
