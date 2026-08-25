using EcosystemApp.DTO;
using EcosystemApp.DAL;


namespace EcosystemApp.BUS
{
    public class UserBUS
    {
        private readonly UserDAL UserDAL = new UserDAL();
        public UserDTO Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            UserDTO user = UserDAL.GetUserWithEmployee(username.Trim(), password.Trim());

            if (user != null)
                return user;
            return null;
        }
    }
}
