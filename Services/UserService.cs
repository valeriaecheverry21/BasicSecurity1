using BasicSecurity.Models;

namespace BasicSecurity.Services
{
    public class UserService : IUserService
    {
        List<User> users = new List<User>()
        { 
            new User(){ Email ="" , Pass = "12312312"}
        
        };

        public bool IsUser(string email, string pass) =>
            users.Where(u => u.Email == email && u.Pass == pass).Count() > 0;
    }
}
