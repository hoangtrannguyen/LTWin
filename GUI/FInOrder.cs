using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FInOrder : Form {
        public FInOrder() {
            InitializeComponent();
        }

        private async void FInOrder_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);

            for(int i =0; i < 4; i++) {
                flowPanelInOrder.Controls.Add(new UC_InOrderCustomer());
                
                await Task.Delay(100);
            }

        }
    }
}
