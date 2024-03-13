using System;
using System.Windows.Forms;

namespace GUI {
    public partial class UC_InOrderSeller : UserControl {
        public UC_InOrderSeller() {
            InitializeComponent();
        }

        private void btnDetail_Click(object sender, EventArgs e) {
            (new FOrderCustomerInfo()).ShowDialog();
        }

        private void UC_InOrderSeller_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 100, WinAPI.VER_POSITIVE);
        }
    }
}
