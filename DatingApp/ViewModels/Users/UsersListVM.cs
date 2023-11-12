using DatingApp.Models;

namespace DatingApp.ViewModels.Users
{
    public class UsersListVM
    {
        public UsersListVM() { }
        public UsersListVM(IEnumerable<UserViewModel> users)
        {
            List = users;
        }
        public IEnumerable<UserViewModel> List { get; set; }
    }
}