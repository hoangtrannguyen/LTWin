using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FProduct : Form {
        public FProduct() {
            InitializeComponent();
        }

        private void flowPanel_Paint(object sender, PaintEventArgs e) {

        }

        private async void frmProduct_Load(object sender, System.EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
            for(int i = 0; i < 8; i++) {
                flowPanel.Controls.Add(new UC_Product());

                await Task.Delay(100);
            }
        }

        private void btnAddProduct_Click(object sender, System.EventArgs e) {
            (new FProductModule()).ShowDialog();
        }
    }
}
