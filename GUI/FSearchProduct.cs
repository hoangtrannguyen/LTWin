using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FSearchProduct : Form {
        public FSearchProduct() {
            InitializeComponent();
        }

        private void flowPanelSearchProduct_Paint(object sender, PaintEventArgs e) {
            
        }

        private async void FSearchProduct_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.VER_POSITIVE);

            for(int i = 0; i < 8; i++) {

                flowPanelSearchProduct.Controls.Add(new UC_ProductCustomer());

                await Task.Delay(100);
            }
        }
    }
}
