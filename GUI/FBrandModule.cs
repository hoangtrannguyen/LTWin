using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FBrandModule : Form {
        public FBrandModule() {
            InitializeComponent();
        }

        private void FBrandModule_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 100, WinAPI.VER_POSITIVE);
        }

        private void timerClose_Tick(object sender, EventArgs e) {
            if(this.Opacity > 0) {
                this.Opacity -= 0.2;
            } else {
                timerClose.Stop();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            timerClose.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            timerClose.Start();
        }
    }
}
