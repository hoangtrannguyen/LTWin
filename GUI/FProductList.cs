using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FProductList : Form {
        public FProductList() {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, System.EventArgs e) {
            (new FProductModule()).ShowDialog();
        }

        private async void FProductList_Load(object sender, System.EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.VER_POSITIVE);

            for(int i = 0; i < 4; i++) {
                if(flowPanelProduct.IsDisposed) {
                    return;
                }

                flowPanelProduct.Controls.Add(new UC_ProductSeller());

                await Task.Delay(100);
            }
        }

        private void flowPanelProduct_Paint(object sender, PaintEventArgs e) {

        }
    }
}
