using DatingApp.Data;
using DatingApp.Models;
using DatingApp.Repositories.BaseEntity;
using DatingApp.ViewModels.Users;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Repositories.Users
{
    public class UsersRepository : EntityRepository<UsersModel>, IUsersRepository
    {
        private readonly ApplicationDbContext _context;
        public UsersRepository(ApplicationDbContext context)
        :base(context)
        {
            _context = context;
        }

        public async Task<bool> CheckUniqueAttributes(UserViewModel user) => await
        _context.Users.AnyAsync(u => u.Username == user.Username || u.Email == user.Email || u.PhoneNumber == user.PhoneNumber);

        public async Task<UsersModel> GetById(int id) => await GetAllOrWithIncluding().SingleAsync(u => u.Id == id);
    }
}