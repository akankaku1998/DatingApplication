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

        public UsersListVM GetAllUsers()
        {
            return new UsersListVM(_usersRepo.GetAllUsers());
        }

        public UserViewModel GetUserById(int id)
        {
            return new UserViewModel(_usersRepo.GetUserById(id));
        }
    }
}