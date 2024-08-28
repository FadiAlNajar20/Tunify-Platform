using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;
using Tunify_Platform.Models;
using Tunify_Platform.Models.DTO;
using Tunify_Platform.Repositories.Interfaces;

namespace Tunify_Platform.Repositories.Services
{
    public class IdentityAccountService : IAccount
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private JwtTokenServices _jwtTokenService;

        public IdentityAccountService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, JwtTokenServices jwtTokenService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtTokenService = jwtTokenService;
        }

        public async Task<UserDTO> Register(RegisterDTO registerdUserDto, ModelStateDictionary modelState)
        {
            var user = new ApplicationUser()
            {
                UserName = registerdUserDto.UserName,
                Email = registerdUserDto.Email,

            };

            var result = await _userManager.CreateAsync(user, registerdUserDto.Password);

            if (result.Succeeded)
            {
               await _userManager.AddToRolesAsync(user, registerdUserDto.Roles);
               await _userManager.AddClaimAsync(user, new Claim ("Permission", "AdminPolicy"));
                return new UserDTO()
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Roles = await _userManager.GetRolesAsync(user),
                    Token = await _jwtTokenService.GenerateToken(user, TimeSpan.FromMinutes(240))
                };
            }

            foreach (var error in result.Errors)
            {
                var errorCode = error.Code.Contains("Password") ? nameof(registerdUserDto) :
                                error.Code.Contains("Email") ? nameof(registerdUserDto) :
                                error.Code.Contains("Username") ? nameof(registerdUserDto) : "";

                modelState.AddModelError(errorCode, error.Description);
            }

            return null;
        }

        // login
        public async Task<UserDTO> UserAuthentication(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);

            bool passValidation = await _userManager.CheckPasswordAsync(user, password);

            if (passValidation)
            {
                return new UserDTO()
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Token = await _jwtTokenService.GenerateToken(user, TimeSpan.FromMinutes(240))
                };
            }

            return null;
        }
        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<string> GenerateJwtToken(ApplicationUser user, IList<string> roles)
        {
            return await _jwtTokenService.GenerateToken(user, TimeSpan.FromHours(4));
        }

    }
}
