using DatingApp.Models;

namespace DatingApp.DataAccessLayer.Users
{
    public interface IUsersRepository
    {
        Task<IEnumerable<UsersModel>> GetAllUsersAsync();
        Task<UsersModel> GetUserByIdAsync(int id);
    }
}