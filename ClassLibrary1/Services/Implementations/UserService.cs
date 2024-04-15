using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topsstyle.Core.Services.Interfaces;
using Topstyle.Data.Repos.Interfaces;
using Topstyle.Domain.Entites;

namespace Topsstyle.Core.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public async Task CreateUser(User user)
        {
            await _userRepo.CreateUser(user);
        }

        public async Task DeleteUser(int userId)
        {
            await _userRepo.DeleteUser(userId);
        }

        public async Task<User> GetUserById(int userId)
        {

            var user =  await _userRepo.GetUserById(userId);
            if (user == null)
            {
                throw new ArgumentNullException("No user found");
            }
            return user;
        }

        public async Task UpdateUser(User user)
        {
            await _userRepo.UpdateUser(user);
        }
    }
}
