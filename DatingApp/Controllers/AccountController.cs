using System.Security.Cryptography;
using System.Text;
using DatingApp.Models;
using DatingApp.Repositories.Users;
using DatingApp.Services.Account;
using DatingApp.ViewModels.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace DatingApp.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly IAccountService _accountService;
        private readonly IUsersRepository _usersRepository;

        public AccountController(IAccountService accountService, IUsersRepository usersRepository)
        {
            _accountService = accountService;
            _usersRepository = usersRepository;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UsersModel>> Register(UserViewModel viewModel)
        {
            var isAttributeAlreadyExistsMsg = await _accountService.UserUniqueAlreadyExistsAsync(viewModel);
            if (!isAttributeAlreadyExistsMsg.IsNullOrEmpty())
            return BadRequest(isAttributeAlreadyExistsMsg);
            return await _accountService.RegisterUserAsync(viewModel);
        }

        [HttpPost("login")]
        public async Task<ActionResult<UsersModel>> Login(LoginViewModel login)
        {
            var user = await _usersRepository.FindAsync(login);
            if(user == null) return Unauthorized("Invalid Username/Phone Number/Email");
            using var hmac = new HMACSHA512(user.PasswordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(login.Password));
            for(int i = 0; i < computedHash.Length; i++)
            {
                if(computedHash[i] != user.PasswordHash[i])
                return Unauthorized("Invalid Password!");
            }
            return user;
        }
    }
}