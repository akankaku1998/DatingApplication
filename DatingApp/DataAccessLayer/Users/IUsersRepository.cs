using DatingApp.Models;

namespace DatingApp.DataAccessLayer.Users
{
    public interface IUsersRepository
    {
        IEnumerable<UsersModel> GetAllUsers();
        UsersModel GetUserById(int id);
    }
}