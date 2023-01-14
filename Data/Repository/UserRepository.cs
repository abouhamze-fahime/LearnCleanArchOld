using Data.Context;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {

        private UniversityDbContext _context;
        public UserRepository(UniversityDbContext context)
        {
            _context = context;
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            
        }

        public bool IsExistEmail(string email)
        {
           return _context.Users.Any(e => e.Email == email);
        }

        public bool IsExistMobile(string mobile)
        {
            return _context.Users.Any(e => e.Mobile == mobile);
        }

        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(e => e.UserName == userName);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
