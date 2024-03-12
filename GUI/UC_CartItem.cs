using System;
using System.Windows.Forms;

namespace GUI {
    public partial class UC_CartItem : UserControl {
        public UC_CartItem() {
            InitializeComponent();
        }

        private void UC_CartItem_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.HOR_Positive);
        }
    }
}
