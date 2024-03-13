using System;
using System.Windows.Forms;

namespace GUI {
    public partial class UC_ProductSeller : UserControl {
        public UC_ProductSeller() {
            InitializeComponent();
        }

        private void btnDetail_Click(object sender, EventArgs e) {
            (new FProductDetailSeller()).ShowDialog();
        }

        private void UC_ProductSeller_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.VER_POSITIVE);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            (new FProductModule()).ShowDialog();
        }
    }
}
