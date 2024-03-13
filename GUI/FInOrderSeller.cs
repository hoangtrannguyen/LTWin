using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FInOrderSeller : Form {
        public FInOrderSeller() {
            InitializeComponent();
        }

        private async void FInOrderSeller_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);

            for(int i = 0; i < 4; i++) {
                flowPanelInOrder.Controls.Add(new UC_InOrderSeller());

                await Task.Delay(100);
            }
        }
    }
}
