using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FOrderCustomerInfo : Form {
        public FOrderCustomerInfo() {
            InitializeComponent();
        }

        private async void FOrderCustomerInfo_Load(object sender, System.EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.VER_POSITIVE);
            for(int i =0; i < 4; i++) {
                flowPanelCustomerOrderProductInfo.Controls.Add(new UC_CustomerOrderProductInfo());

                await Task.Delay(100);
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e) {
            this.Close();
        }
    }
}
