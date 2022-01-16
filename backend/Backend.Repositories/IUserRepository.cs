using Backend.Models;

namespace Backend.Repositories
{
    public interface IUserRepository:IRepository<User>
    {
        User ValidateUser(string email, string password);
    }
}
