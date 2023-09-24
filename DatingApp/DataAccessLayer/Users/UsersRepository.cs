using DatingApp.Data;
using DatingApp.Models;

namespace DatingApp.DataAccessLayer.Users
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ApplicationDbContext _context;

        public UsersRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UsersModel> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public UsersModel GetUserById(int id)
        {
            return _context.Users.Find(id);
        }
    }
}