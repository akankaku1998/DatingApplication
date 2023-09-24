using DatingApp.Models;

namespace DatingApp.ViewModels.Users
{
    public class UserViewModel
    {
        public UserViewModel(UsersModel user)
        {
            User = user;
        }

        public UsersModel User { get; set; }
    }
}