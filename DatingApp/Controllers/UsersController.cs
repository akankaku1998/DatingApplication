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
        public ActionResult<UsersListVM> List()
        {
            return _usersBL.GetAllUsers();
        }

        [HttpGet("{id}")] // api/users/6
        public ActionResult<UserViewModel> GetUser(int id)
        {
            return _usersBL.GetUserById(id);
        }
    }
}