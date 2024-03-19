using DAO;
using DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI {
    public struct GENDER {
        public static readonly int MALE = 1;
        public static readonly int FEMALE = 0;
    }
    
    public partial class FRegister : Form {
       
        private string imgLocation = "";
        UserDAO userDAO = new UserDAO();

        public FRegister() {
            InitializeComponent();
        }

        private void FRegister_Load(object sender, System.EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
        }

        private int GetGenderCode() {
            if(radMale.Checked) {
                return GENDER.MALE;
            }

            return GENDER.FEMALE;
        }

        private void btnUpload_Click(object sender, System.EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "PNG Files (*.PNG)|*.png|JPG Files (*.JPG)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";

            if(openFileDialog.ShowDialog() == DialogResult.OK) {
                imgLocation = openFileDialog.FileName.ToString();
                ptrbAvatar.ImageLocation = imgLocation;
            }
        }

        private byte[] ConvertImageToBytes(string imgLocation) {
            byte[] avatar = null;
            FileStream fs = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            avatar = br.ReadBytes((int)fs.Length);

            return avatar;
        }

        private Image ConvertBytesToImage(byte[] img) {
            MemoryStream ms = new MemoryStream(img);

            return Image.FromStream(ms);
        }

        private void btnRegister_Click(object sender, System.EventArgs e) {
            byte[] avatar = ConvertImageToBytes(imgLocation);

            UserDTO userDTO = new UserDTO(avatar, txtName.Text.Trim(), txtAddress.Text.Trim(), txtPhoneNumber.Text.Trim(), GetGenderCode().ToString(), txtEmail.Text, txtUsername.Text, txtPassword.Text, true, ROLE.CUSTOMER);

            userDAO.AddUser(userDTO);
        }

        private void guna2Button1_Click(object sender, EventArgs e) {
            SqlConnection conn = new SqlConnection("Data Source=DELL\\TANTRUSQL;Initial Catalog=ExchangeItem;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            string sql = $"SELECT avatar FROM tblAccount WHERE full_name = '{txtName.Text}'";
            DBConnection db = new DBConnection();
            DataTable dt = db.ExecuteQueryDataTable(sql);

            byte[] img = (byte[])dt.Rows[0]["avatar"];

            if(img != null) {
                MemoryStream ms = new MemoryStream(img);
                Image image = ConvertBytesToImage(img);
                ptrbAvatar.Image = image;
            }
        }
    }
}
