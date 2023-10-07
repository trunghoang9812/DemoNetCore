using DemoDotNetCore.Domain.Entities;
using DemoDotNetCore.Infrastructor.DBConText;
using DemoDotNetCore.Infrastructor.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDotNetCore.Infrastructor.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DemoContext _context;

        public UserRepository(DemoContext context)
        {
            _context = context;
        }
        public User Create(User user)
        {
            return _context.Users.Add(user).Entity;
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public User Update(User user)
        {
            return _context.Update(user).Entity;
        }
        public int SaveChange()
        {
           return _context.SaveChanges();
        }
    }
}
