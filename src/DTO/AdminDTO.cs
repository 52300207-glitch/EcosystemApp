namespace EcosystemApp.DTO
{
    public class AdminDTO
    {
        private int ID;
        private string Username;
        private string Password;

        public int GetID() { return ID; }

        public string GetUsername() { return Username; }

        public string GetPassword() { return Password; }

        public void SetID(int value) { this.ID = value; }

        public void SetUsername(string value) { this.Username = value; }

        public void SetPassword(string value) { this.Password = value; }


        public AdminDTO() { }

        public AdminDTO(int id, string username, string password)
        {
            this.ID = id;
            this.Username = username;
            this.Password = password;
        }
        public AdminDTO( string username, string password)
        {

            this.Username = username;
            this.Password = password;
        }
    }
}
