using DatingApp.BusinessLogicLayer;
using DatingApp.Models;
using DatingApp.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // api/users
    public class UsersController : ControllerBase
    {
        private readonly UsersBusniessLayer _usersBL;
        public UsersController(UsersBusniessLayer usersBL)
        {
            _usersBL = usersBL;
        }

        [HttpGet]
        public async Task<ActionResult<UsersListVM>> List()
        {
            return await _usersBL.GetAllUsersAsync();
        }

        [HttpGet("{id}")] // api/users/6
        public async Task<ActionResult<UserViewModel>> GetUser(int id)
        {
            return await _usersBL.GetUserByIdAsync(id);
        }
    }
}