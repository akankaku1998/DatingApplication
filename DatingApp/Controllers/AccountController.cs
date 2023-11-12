using DatingApp.Models;
using DatingApp.Services.Account;
using DatingApp.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

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
            var isAttributeAlreadyExistsMsg = await _accountService.UserUniqueAlreadyExistsAsync(viewModel);
            if (!isAttributeAlreadyExistsMsg.IsNullOrEmpty())
            return BadRequest(isAttributeAlreadyExistsMsg);
            return await _accountService.RegisterUserAsync(viewModel);
        }
    }
}