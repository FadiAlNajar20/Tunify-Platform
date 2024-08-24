using Tunify_Platform;

namespace Tunify_Platform
{
    public interface IUser
    {
        Task<ModelUser> GetUserByIdAsync(int id);
        Task<List<ModelUser>> GetAllUsersAsync();
        Task<ModelUser> AddUserAsync(ModelUser user);
        Task<ModelUser> UpdateUserAsync(int id, ModelUser user);
        Task DeleteUserAsync(int id);
    }
}
