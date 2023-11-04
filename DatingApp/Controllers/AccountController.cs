using DatingApp.Models;
using DatingApp.Services.Account;
using DatingApp.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UsersModel>> Register(UserViewModel viewModel)
        {
            if(await _accountService.UserUniqueAlreadyExistsAsync(viewModel))
            return BadRequest("Username or Email or Phone Number is already exists!");
            return await _accountService.RegisterUserAsync(viewModel);
        }
    }
}