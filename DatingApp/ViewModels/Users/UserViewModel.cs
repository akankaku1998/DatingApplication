using System.ComponentModel.DataAnnotations;
using DatingApp.Models;

namespace DatingApp.ViewModels.Users
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
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