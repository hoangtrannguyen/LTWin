using System.Windows.Forms;

namespace GUI {
    public partial class FProductDetailSeller : Form {
        public FProductDetailSeller() {
            InitializeComponent();
        }

        private void FProductDetailSeller_Load(object sender, System.EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.VER_POSITIVE);
        }

        private void btnClose_Click(object sender, System.EventArgs e) {
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, System.EventArgs e) {
            if(this.Opacity > 0) {
                this.Opacity -= 0.25;
            } else {
                timerClose.Stop();
                this.Close();
            }
        }
    }
}
