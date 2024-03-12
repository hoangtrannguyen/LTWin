using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FPayment : Form {
        public FPayment() {
            InitializeComponent();
        }

        private void FPayment_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.HOR_Positive);
        }
    }
}
