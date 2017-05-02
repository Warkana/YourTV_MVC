﻿using YourTV_BLL.Interfaces;
using YourTV_DAL.Repositories;

namespace YourTV_BLL.Services
{
    public class UserServiceCreator : IServiceCreator
    {
        public IUserService CreateUserService(string connection)
        {
            return new UserService(new IdentityUnitOfWork(connection));
        }
    }
}