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

        public async Task<string> CheckUniqueAttributes(UserViewModel user)
        {
            if(await _context.Users.AnyAsync(u => u.Username == user.Username))
               return "Username is already exists!";
            else if(await _context.Users.AnyAsync(u => u.Email == user.Email))
                return "Email is already exists!";
            else if (await _context.Users.AnyAsync(u => u.PhoneNumber == user.PhoneNumber))
                return "Phone Number is already exists!";
            return null;
        }

        public async Task<UsersModel> FindAsync(LoginViewModel login)
        => await _context.Users.SingleOrDefaultAsync(
            u => u.Username == login.UsernameEmailPhoneNumber ||
            u.PhoneNumber == login.UsernameEmailPhoneNumber ||
            u.Email == login.UsernameEmailPhoneNumber
            );

        public async Task<UsersModel> GetById(int id)
        => await GetAllOrWithIncluding().SingleAsync(u => u.Id == id);
    }
}