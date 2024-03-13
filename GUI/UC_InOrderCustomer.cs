using System.Windows.Forms;

namespace GUI {
    public partial class UC_InOrderCustomer : UserControl {
        public UC_InOrderCustomer() {
            InitializeComponent();
        }

        private void UC_InOrderCustomer_Load(object sender, System.EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.VER_POSITIVE);
        }

        private void btnOrderDetail_Click(object sender, System.EventArgs e) {
            (new FOrderDetail()).ShowDialog();
        }
    }
}
