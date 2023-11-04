using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Repositories.Users;
using DatingApp.ViewModels.Users;

namespace DatingApp.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepo;

        public UsersService(IUsersRepository usersRepo)
        {
            _usersRepo = usersRepo;
        }
        public UsersListVM GetAllUsersAsync()
        {
            var list = _usersRepo.GetAllOrWithIncluding();
            return new UsersListVM(list);
        }
        public async Task<UserViewModel> GetUserByIdAsync(int id)
        {
            var user = await _usersRepo.GetById(id);
            return new UserViewModel(user);
        }
    }
}