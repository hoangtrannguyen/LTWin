using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FStatistics : Form {
        public FStatistics() {
            InitializeComponent();
        }

        private void FStatistics_Load(object sender, EventArgs e) {

            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.CENTER);
        }
    }
}
