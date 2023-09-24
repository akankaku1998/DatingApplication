using DatingApp.Models;

namespace DatingApp.ViewModels.Users
{
    public class UsersListVM
    {
        public UsersListVM() { }
        public UsersListVM(IEnumerable<UsersModel> users)
        {
            List = users;
        }
        public IEnumerable<UsersModel> List { get; set; }
    }
}