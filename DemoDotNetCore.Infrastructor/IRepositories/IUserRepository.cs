using DemoDotNetCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDotNetCore.Infrastructor.IRepositories
{
    public interface IUserRepository
    {
        User Create(User user);
        User Update(User user);
        void Delete(User user);
        List<User> GetUsers();
        int SaveChange();
    }
}
