using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FSetOrder : Form {
        public FSetOrder() {
            InitializeComponent();
        }

        private void FSetOrder_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.VER_POSITIVE);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e) {
            if(Opacity > 0.0) {
                Opacity -= 0.5;
            } else {
                timerClose.Stop();
                this.Close();
            }
        }

        private void lblTotalMoney_Click(object sender, EventArgs e) {

        }
    }
}
