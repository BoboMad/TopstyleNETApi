﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topstyle.Domain.Entites;

namespace Topsstyle.Core.Services.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(User user);
        Task<User> GetUserById(int userId);
        Task UpdateUser(User user);
        Task DeleteUser(int userId);

    }
}
