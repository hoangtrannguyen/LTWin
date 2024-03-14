using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FStatistics : Form {
        public FStatistics() {
            InitializeComponent();
        }

        private async void FStatistics_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);

            for(int i = 0; i < 4; i++) {
                flowPanelProduct.Controls.Add(new UC_ProductSeller());
            }

            await Task.Delay(100);
        }
    }
}
