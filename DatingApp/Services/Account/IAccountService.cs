using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Models;
using DatingApp.ViewModels.Users;

namespace DatingApp.Services.Account
{
    public interface IAccountService
    {
        Task<UsersModel> RegisterUserAsync(UserViewModel viewModel);
        Task<bool> UserUniqueAlreadyExistsAsync(UserViewModel user);
    }
}