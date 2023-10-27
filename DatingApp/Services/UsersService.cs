using DatingApp.DataAccessLayer.Repositories;
using DatingApp.ViewModels.Users;

namespace DatingApp.Services
{
    public class UsersService
    {
        private readonly IUsersRepository _usersRepo;

        public UsersService(IUsersRepository usersRepo)
        {
            _usersRepo = usersRepo;
        }
        public async Task<UsersListVM> GetAllUsersAsync()
        {
            return new UsersListVM(await _usersRepo.GetAllUsersAsync());
        }

        public async Task<UserViewModel> GetUserByIdAsync(int id)
        {
            return new UserViewModel(await _usersRepo.GetUserByIdAsync(id));
        }
    }
}