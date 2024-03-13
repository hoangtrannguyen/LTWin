using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FSetOrder : Form {
        public FSetOrder() {
            InitializeComponent();
        }

        private async void FSetOrder_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.VER_POSITIVE);

            for(int i = 0; i < 4; i++) {
                flowPanelCustomerOrderProductInfo.Controls.Add(new UC_CustomerOrderProductInfo());

                await Task.Delay(100);
            }
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
    }
}
