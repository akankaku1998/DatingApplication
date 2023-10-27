using DatingApp.Models;

namespace DatingApp.Repositories.Users
{
    public interface IUsersRepository
    {
        Task<IEnumerable<UsersModel>> GetAllUsersAsync();
        Task<UsersModel> GetUserByIdAsync(int id);
    }
}