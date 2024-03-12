using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FCart : Form {
        public FCart() {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e) {
            (new FPayment()).ShowDialog();

        }

        private async void FCart_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);

            for(int i = 0; i < 4; i++) {
                flowPanelCart.Controls.Add(new UC_CartItem());

                await Task.Delay(100);
            }
        }
    }
}
