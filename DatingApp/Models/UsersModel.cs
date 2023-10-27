using DatingApp.Models.BaseModels;

namespace DatingApp.Models
{
    public class UsersModel : EntityBaseModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
    }
}