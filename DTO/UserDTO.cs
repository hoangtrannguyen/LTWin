namespace DTO {
    public class UserDTO {

        private string userID;
        private byte[] avatar;
        private string fullname;
        private string address;
        private string phoneNumber;
        private string gender;
        private string email;
        private string username;
        private string password;
        private bool isActive;
        private string roleID;

        public UserDTO(byte[] avatar, string fullname, string address, string phoneNumber, string gender, string email, string username, string password, bool isActive, string roleID) {
            this.avatar = avatar;
            this.fullname = fullname;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.gender = gender;
            this.email = email;
            this.username = username;
            this.password = password;
            this.isActive = isActive;
            this.roleID = roleID;
        }

        public string UserID { get => userID; }
        public byte[] Avatar { get => avatar; }
        public string Fullname { get => fullname; }
        public string Address { get => address; }
        public string PhoneNumber { get => phoneNumber; }
        public string Gender { get => gender; }
        public string Email { get => email; }
        public string Username { get => username; }
        public string Password { get => password; }
        public bool IsActive { get => isActive; }
        public string RoleID { get => roleID; }

        public bool IsAvatarSelected() {
            return Avatar != null && Avatar.Length > 0;
        }

        public bool IsValidFullname() {

        }

        public bool IsValidAddress() {

        }

        public bool IsValidPhoneNumber() {

        }

        public bool IsCheckedGender() {

        }

        public bool IsValidEmail() {

        }

        public bool IsValidUsername() {

        }

        public bool IsValidPassword() {

        }

        public bool IsActiveUser() {

        }

        public bool IsRoleIDSelected() {

        }
    }
}
