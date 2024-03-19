namespace DTO {
    public class LoginDTO {

        private string username;
        private string password;
        private string role;
        private bool isActive;

        public LoginDTO() { }
        public LoginDTO(string username, string password, string role, bool isActive) {
            this.username = username;
            this.password = password;
            this.role = role;
            this.isActive = isActive;
        }

        public bool Username { get => this.isActive; }
        public bool Password { get => this.isActive; }
        public bool Role { get => this.isActive; }
        public bool IsActive { get => this.isActive; }

        public bool IsActiveAccount() {
            return this.IsActive;
        }
    }
}
