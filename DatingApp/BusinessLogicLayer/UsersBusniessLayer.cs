using DatingApp.DataAccessLayer.Users;
using DatingApp.ViewModels.Users;

namespace DatingApp.BusinessLogicLayer
{
    public class UsersBusniessLayer
    {
        private readonly IUsersRepository _usersRepo;

        public UsersBusniessLayer(IUsersRepository usersRepo)
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