﻿using DatingApp.Models;
using DatingApp.Repositories.BaseEntity;
using DatingApp.ViewModels.Users;

namespace DatingApp.Repositories.Users
{
    public interface IUsersRepository: IEntityRepository<UsersModel>
    {
        Task<UsersModel> GetById(int id);
        Task<bool> CheckUniqueAttributes(UserViewModel user);
    }
}