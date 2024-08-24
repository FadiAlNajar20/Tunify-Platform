using Microsoft.EntityFrameworkCore;
using Tunify_Platform.Data;

namespace Tunify_Platform
{
        public class UserService : IUser
        {
            private readonly TunifyDBContext _context;

            public UserService(TunifyDBContext context)
            {
                _context = context;
            }

            public async Task<List<ModelUser>> GetAllUsersAsync()
            {
                var allUsers = await _context.ModelUsers.ToListAsync();
                return allUsers;
            }

            public async Task<ModelUser> GetUserByIdAsync(int id) => await _context.ModelUsers.FindAsync(id);

            public async Task<ModelUser> AddUserAsync(ModelUser User)
            {
                _context.ModelUsers.Add(User);
                await _context.SaveChangesAsync();
                return User;
            }

            public async Task<ModelUser> UpdateUserAsync(int id, ModelUser User)
            {
                var exsitingEmployee = await _context.ModelUsers.FindAsync(id);
                exsitingEmployee = User;
                await _context.SaveChangesAsync();
                return User;
            }

            public async Task DeleteUserAsync(int id)
            {
                var getUser = await GetUserByIdAsync(id);
                _context.Entry(getUser).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
    }
}
