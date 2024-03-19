using DTO;

namespace DAO {
    public class LoginDAO {

        DBConnection db = new DBConnection();

        public LoginDAO() {

        }

        public bool Login(LoginDTO loginDTO) {
            string query = $"SELECT * FROM Account WHERE username = {loginDTO.Username} AND password = {loginDTO.Password}";

            return db.ExecuteNonQuery(query);
        }
    }
}
