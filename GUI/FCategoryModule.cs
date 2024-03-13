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

        private void timerClose_Tick(object sender, EventArgs e) {
            if(this.Opacity > 0) {
                this.Opacity -= 0.25;
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
