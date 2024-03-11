using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FPayment : Form {
        public FPayment() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(650, 300);
        }

        private void FPayment_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
        }
    }
}
