using System.Windows.Forms;

namespace GUI {
    public partial class UC_Product : UserControl {
        public UC_Product() {
            InitializeComponent();
        }

        private void UC_Product_Load(object sender, System.EventArgs e) {
            ratingStar.Value = 3.5f;
        }

        private void btnViewDetail_Click(object sender, System.EventArgs e) {
            (new frmProductDetail()).ShowDialog();
        }
    }
}
