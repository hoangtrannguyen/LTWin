using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FProductDetail : Form {
        public FProductDetail() {
            InitializeComponent();
        }

        private void FProductDetail_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.VER_POSITIVE);
        }

        private void timerClose_Tick(object sender, EventArgs e) {
            if(Opacity > 0.0) {
                Opacity -= 0.5;
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
