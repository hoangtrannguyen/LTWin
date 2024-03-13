using System;
using System.Windows.Forms;

namespace GUI {
    public partial class UC_OrderHistoryCustomer : UserControl {
        public UC_OrderHistoryCustomer() {
            InitializeComponent();
        }

        private void btnFeedback_Click(object sender, EventArgs e) {
            (new FFeedback()).ShowDialog();
        }

        private void btnReOrder_Click(object sender, EventArgs e) {
            (new FProductDetailCustomer()).ShowDialog();
        }
    }
}
