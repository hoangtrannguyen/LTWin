using System;
using System.Windows.Forms;

namespace GUI {
    public partial class FBrand : Form {
        public FBrand() {
            InitializeComponent();
        }

        private void btnAddBrand_Click(object sender, EventArgs e) {
            (new FBrandModule()).ShowDialog();
            
        }

        private void FBrand_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);

            for(int i = 0; i < 4; i++) {
                string[] row = { i.ToString(), $"Brand {i}" };
                dgvProduct.Rows.Add(row);
            }
        }
    }
}
