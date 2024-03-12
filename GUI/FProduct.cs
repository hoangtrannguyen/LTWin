using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FProduct : Form {
        public FProduct() {
            InitializeComponent();
        }

        private void flowPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void btnAddProduct_Click(object sender, System.EventArgs e) {
            (new FProductModule()).ShowDialog();
        }

        private async void FProduct_Load(object sender, System.EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
            for(int i = 0; i < 8; i++) {
                flowPanel.Controls.Add(new UC_Product());

                await Task.Delay(100);
            }
        }
    }
}
