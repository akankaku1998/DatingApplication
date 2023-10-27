using DatingApp.Services;
using DatingApp.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // api/users
    public class UsersController : ControllerBase
    {
        private readonly UsersService _usersService;
        public UsersController(UsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public async Task<ActionResult<UsersListVM>> List()
        {
            return await _usersService.GetAllUsersAsync();
        }

        [HttpGet("{id}")] // api/users/6
        public async Task<ActionResult<UserViewModel>> GetUser(int id)
        {
            return await _usersService.GetUserByIdAsync(id);
        }
    }
}