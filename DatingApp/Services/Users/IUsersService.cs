using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.ViewModels.Users;

namespace DatingApp.Services.Users
{
    public interface IUsersService
    {
        UsersListVM GetAllUsersAsync();
        Task<UserViewModel> GetUserByIdAsync(int id);
    }
}