using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using DatingApp.Models.BaseModels;
using DatingApp.ViewModels.Users;

namespace DatingApp.Models
{
    public class UsersModel : EntityBaseModel
    {
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
        public byte[] PasswordHash { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }

        public UsersModel()
        {
        }
        public UsersModel(UserViewModel model)
        {
            using var hmac = new HMACSHA512();
            this.FirstName = model.FirstName;
            this.LastName = model.LastName;
            this.Username = model.Username;
            this.Email = model.Email;
            this.PhoneNumber = model.PhoneNumber;
            this.PasswordSalt = hmac.Key;
            this.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(model.Password));
        }
    }
}