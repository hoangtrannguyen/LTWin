using System.Windows.Forms;

namespace GUI {
    public partial class UC_ProductCustomer : UserControl {
        public UC_ProductCustomer() {
            InitializeComponent();
        }
        private void UC_ProductCustomer_Load(object sender, System.EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
        }

        private void btnViewDetail_Click(object sender, System.EventArgs e) {
            (new FProductDetailCustomer()).ShowDialog();
        }

        
    }
}
