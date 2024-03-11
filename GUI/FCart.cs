using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FCart : Form {
        public FCart() {
            InitializeComponent();
        }

        private async void frmCart_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);

            for(int i = 0; i < 4; i++) {
                flowPanelCart.Controls.Add(new UC_CartItem());

                await Task.Delay(200);
            }
        }

        private void btnPay_Click(object sender, EventArgs e) {
            (new FPayment()).ShowDialog();

        }
    }
}
