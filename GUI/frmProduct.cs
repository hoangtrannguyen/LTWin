using System.Windows.Forms;

namespace GUI {
    public partial class frmProduct : Form {
        public frmProduct() {
            InitializeComponent();
            string[] row = {"1", "2", "test", "test", "2000", "20", "20" };
            for(int i = 0; i < 50; i++) {
                dgvProduct.Rows.Add(row);
            }
        }
    }
}
