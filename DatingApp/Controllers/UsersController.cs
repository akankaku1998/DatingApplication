using DatingApp.Services;
using DatingApp.Services.Users;
using DatingApp.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly IUsersService _usersService;
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet(nameof(List))]
        public ActionResult<UsersListVM> List()
        {
            return _usersService.GetAllUsersAsync();
        }

        [HttpGet(nameof(GetUser))]
        public async Task<ActionResult<UserViewModel>> GetUser(int id)
        {
            return await _usersService.GetUserByIdAsync(id);
        }
    }
}