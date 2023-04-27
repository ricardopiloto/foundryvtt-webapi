using FoundryWebAPI.Models;

namespace FoundryWebAPI.V1.Repositories
{
    public static class UserRepository
    {
        public static User? Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "batman", Password = "batman" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}