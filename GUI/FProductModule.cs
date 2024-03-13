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

        private void btnClose_Click(object sender, EventArgs e) {
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e) {
            if(this.Opacity > 0) {
                this.Opacity -= 0.25;
            } else {
                timerClose.Stop();
                this.Close();
            }
        }
    }
}
