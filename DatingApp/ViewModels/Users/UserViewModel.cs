using DatingApp.Models;

namespace DatingApp.ViewModels.Users
{
    public class UserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }

        public UserViewModel()
        {
        }

        public UserViewModel(UsersModel user)
        {
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.Username = user.Username;
            this.Email = user.Email;
            this.PhoneNumber = user.PhoneNumber;
            this.Password = null;
        }
    }
}