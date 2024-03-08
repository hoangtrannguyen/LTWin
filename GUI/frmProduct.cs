using System.Windows.Forms;

namespace GUI {
    public partial class frmProduct : Form {
        public frmProduct() {
            InitializeComponent();
            //string[] row = {"1", "2", "test", "test", "2000", "20", "20" };
            //for(int i = 0; i < 50; i++) {
            //    dgvProduct.Rows.Add(row);
            //}
            for(int i = 0; i < 8; i++) {
                flowPanel.Controls.Add(new UC_Product());
            }
        }

        private void flowPanel_Paint(object sender, PaintEventArgs e) {

        }

        private void frmProduct_Load(object sender, System.EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }
    }
}
