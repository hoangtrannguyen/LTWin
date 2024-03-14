using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FAdmin : Form {
        public FAdmin() {
            InitializeComponent();
        }

        private void btnManageUser_Click(object sender, EventArgs e) {
            
        }

        private async void FAdmin_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);

            for(int i =0; i < 4; i++) {
                flowPanelUser.Controls.Add(new UC_User());

                await Task.Delay(100);
            }
        }

        private void timerClose_Tick(object sender, EventArgs e) {
            if(this.Opacity > 0) {
                this.Opacity -= 0.25;
            } else {
                timerClose.Stop();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            timerClose.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
