using Data.DatabaseContext;
using Data.Interfaces;
using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private PizzaDbContext _context;
        public UserRepository(PizzaDbContext context)
        {
            _context = context;
        }
        public bool Create(User entity)
        {
            _context.Users.Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);
            _context.Users.Remove(user);
            return true;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.SingleOrDefault(u => u.Id == id);
        }

        public bool Update(User entity)
        {
            _context.Users.Update(entity);
            return true;
        }
    }
}
