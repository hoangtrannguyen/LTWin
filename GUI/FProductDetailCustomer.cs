using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class FProductDetailCustomer : Form {
        public FProductDetailCustomer() {
            InitializeComponent();
            lblDescription.Text = "Mô tả: Mua từ năm 2023, giá gốc 400.000, không còn bảo hành<br>";
            lblDescription.Text += "Xuất xứ: Trung Quốc<br>";
            lblDescription.Text += "Tình trạng: Xe còn mới 85%, có trầy nhẹ<br>";
            lblDescription.Text += "Chất liệu: Nhựa ABS<br>";
            lblDescription.Text += "Màu sắc: Nâu đen<br>";
            lblDescription.Text += "Phụ kiện đi kèm: Pin sạc, bộ điều khiển từ xa<br>";
            lblDescription.Text += "Pin: Dùng pin AA sạc, dung lượng 1500m mAhPin<br>";
            lblDescription.Text += "Kích thước: 25cm x 15cm x 10cm";

        }

        private void FProductDetailCustomer_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.VER_POSITIVE);
            


        }

        private void timerClose_Tick(object sender, EventArgs e) {
            if(Opacity > 0.0) {
                Opacity -= 0.25;
            } else {
                timerClose.Stop();
                this.Close();
            }
        }


        private void btnClose_Click(object sender, EventArgs e) {
            timerClose.Start();
        }
    }
    
}
