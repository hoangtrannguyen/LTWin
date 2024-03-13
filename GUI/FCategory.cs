using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FCategory : Form {
        public FCategory() {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e) {
            (new FCategoryModule()).ShowDialog();
        }

        private void FCategory_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.VER_POSITIVE);


            for(int i =0; i < 4; i++) {
                string[] row = { i.ToString(), $"Category {i}" };
                dgvProduct.Rows.Add(row);
            }
        }
    }
}
