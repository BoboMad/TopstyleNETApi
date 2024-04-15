using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topstyle.Data.Repos.Contexts;
using Topstyle.Data.Repos.Interfaces;
using Topstyle.Domain.Entites;

namespace Topstyle.Data.Repos.Implementations
{
    public class UserRepo : IUserRepo
    {
        private readonly TopstyleContext _context;
        public UserRepo(TopstyleContext context)
        {
            _context = context;
        }
        public async Task CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(int userId)
        {
            var userToRemove = await _context.Users.FirstOrDefaultAsync(u => u.UserId == userId);
            if (userToRemove != null)
            {
                _context.Users.Remove(userToRemove);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<User> GetUserById(int userId)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserId == userId);
        }

        public async Task UpdateUser(User user)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();
        }
    }
}
