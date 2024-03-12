using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FOrderHistory : Form {
        public FOrderHistory() {
            InitializeComponent();
        }

        private void flowPanelOrderHistory_Paint(object sender, PaintEventArgs e) {
            

        }

        private async void FOrderHistory_Load(object sender, System.EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.HOR_Positive);

            for(int i = 0; i < 4; i++) {
                flowPanelOrderHistory.Controls.Add(new UC_OrderHistoryCustomer());

                await Task.Delay(100);
            }
        }
    }
}
