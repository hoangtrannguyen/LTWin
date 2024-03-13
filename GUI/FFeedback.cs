using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FFeedback : Form {
        public FFeedback() {
            InitializeComponent();
        }

        private void FFeedback_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.VER_POSITIVE);
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
    }
}
