using DTO;
using System.Data.SqlClient;

namespace DAO {
    public class UserDAO {
        
        DBConnection db = new DBConnection();

        public bool AddUser(UserDTO userDTO) {
            string query = $"INSERT INTO tblAccount VALUES (@avatar, @address, @fullname, @phoneNumber, @gender, @email, @username, @password, @isActive, @roleID)";

            SqlParameter[] sqlParameters = {
                new SqlParameter("@avatar", userDTO.Avatar),
                new SqlParameter("@address", userDTO.Address),
                new SqlParameter("@fullname", userDTO.Fullname),
                new SqlParameter("@phoneNumber", userDTO.PhoneNumber),
                new SqlParameter("@gender", userDTO.Gender),
                new SqlParameter("@email", userDTO.Email),
                new SqlParameter("@username", userDTO.Username),
                new SqlParameter("@password", userDTO.Password),
                new SqlParameter("@isActive", userDTO.IsActive),
                new SqlParameter("@roleID", userDTO.RoleID),
            };

            return db.ExecuteNonQuery(query, sqlParameters);
        }

        public bool UpdateUser(UserDTO userDTO) {
            string query = $"UPDATE tblAccount SET avatar = @avatar, address = @address, full_name = @fullname, phone_number = @phoneNumber, gender = @gender, email = @email, username =  @username, password = @password, is_active = @isActive, role_id = @roleID WHERE user_id = @userID";

            SqlParameter[] sqlParameters = {
                new SqlParameter("@avatar", userDTO.Avatar),
                new SqlParameter("@address", userDTO.Address),
                new SqlParameter("@fullname", userDTO.Fullname),
                new SqlParameter("@phoneNumber", userDTO.PhoneNumber),
                new SqlParameter("@gender", userDTO.Gender),
                new SqlParameter("@email", userDTO.Email),
                new SqlParameter("@username", userDTO.Username),
                new SqlParameter("@password", userDTO.Password),
                new SqlParameter("@isActive", userDTO.IsActive),
                new SqlParameter("@roleID", userDTO.RoleID),
            };

            return db.ExecuteNonQuery(query, sqlParameters);
        }

        public bool DeleteUser(UserDTO userDTO) {
            string query = $"INSERT INTO tblAccount VALUES (@avatar, @address, @fullname, @phoneNumber, @gender, @email, @username, @password, @isActive, @roleID)";

            SqlParameter[] sqlParameters = {
                new SqlParameter("@avatar", userDTO.Avatar),
                new SqlParameter("@address", userDTO.Address),
                new SqlParameter("@fullname", userDTO.Fullname),
                new SqlParameter("@phoneNumber", userDTO.PhoneNumber),
                new SqlParameter("@gender", userDTO.Gender),
                new SqlParameter("@email", userDTO.Email),
                new SqlParameter("@username", userDTO.Username),
                new SqlParameter("@password", userDTO.Password),
                new SqlParameter("@isActive", userDTO.IsActive),
                new SqlParameter("@roleID", userDTO.RoleID),
            };

            return db.ExecuteNonQuery(query, sqlParameters);
        }
    }
}
