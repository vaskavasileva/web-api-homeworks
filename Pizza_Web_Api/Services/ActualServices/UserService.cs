using Data.Interfaces;
using Domain_Models.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ActualServices
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepo;
        public UserService(IRepository<User> userRepo)
        {
            _userRepo = userRepo;
        }
        public bool CreateUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserModel GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel LogInUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
