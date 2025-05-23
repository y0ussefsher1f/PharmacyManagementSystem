namespace PharmacyManagementSystem.Models
{
    public class Staff
    {
        private string username;
        private string password;

        public Staff(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }

    }
}