using Microsoft.AspNetCore.Mvc.ModelBinding;
using Tunify_Platform.Models.DTO;

namespace Tunify_Platform.Repositories.Interfaces
{
    public interface IAccount
    {
        Task<UserDTO> Register(RegisterDTO registerdUserDto, ModelStateDictionary modelState);
        Task<UserDTO> UserAuthentication(string username, string password);
        Task Logout();
    }
}
