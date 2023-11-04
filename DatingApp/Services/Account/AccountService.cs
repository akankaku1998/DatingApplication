using DatingApp.Models;
using DatingApp.Repositories.Users;
using DatingApp.ViewModels.Users;

namespace DatingApp.Services.Account
{
    public class AccountService : IAccountService
    {
        private readonly IUsersRepository _usersRepository;

        public AccountService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public async Task<UsersModel> RegisterUserAsync(UserViewModel viewModel)
        {
            var user = new UsersModel(viewModel);
            await _usersRepository.AddAsync(user);
            return user;
        }
        public async Task<bool> UserUniqueAlreadyExistsAsync(UserViewModel user) =>  await _usersRepository.CheckUniqueAttributes(user);
    }
}