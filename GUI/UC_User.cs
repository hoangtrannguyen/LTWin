using System.Windows.Forms;

namespace GUI {
    public partial class UC_User : UserControl {
        public UC_User() {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, System.EventArgs e) {
            (new FUserDetail()).ShowDialog();
        }
    }
}
