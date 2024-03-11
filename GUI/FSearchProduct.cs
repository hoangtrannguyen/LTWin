using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FSearchProduct : Form {
        public FSearchProduct() {
            InitializeComponent();
        }

        private async void frmSearchProduct_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);

            for(int i = 0; i < 8; i++) {
                flowPanelSearchProduct.Controls.Add(new UC_Product());

                await Task.Delay(200);
            }
        }

        private void flowPanelSearchProduct_Paint(object sender, PaintEventArgs e) {
            
        }
    }
}
