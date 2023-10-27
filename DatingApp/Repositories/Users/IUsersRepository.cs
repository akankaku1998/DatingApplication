using DatingApp.Models;

namespace DatingApp.DataAccessLayer.Repositories
{
    public interface IUsersRepository
    {
        Task<IEnumerable<UsersModel>> GetAllUsersAsync();
        Task<UsersModel> GetUserByIdAsync(int id);
    }
}