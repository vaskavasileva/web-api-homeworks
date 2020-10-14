using Data.Interfaces;
using Domain_Models.Models;
using Mappings;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return _userRepo.Create(UserMapper.UserModelToUser(user));
        }

        public bool DeleteUser(int id)
        {
            return _userRepo.Delete(id);
        }

        public List<UserModel> GetAllUsers()
        {
            return UserMapper.UsersToUserModels(_userRepo.GetAll());
        }

        public UserModel GetUserById(int id)
        {
            return UserMapper.UserToUserModel(_userRepo.GetById(id));
        }

        public UserModel LogInUser(string username, string password)
        {
            return UserMapper.UserToUserModel(_userRepo.GetAll().SingleOrDefault(u => u.Username == username && u.Password == password));
        }

        public bool UpdateUser(UserModel user)
        {
            return _userRepo.Update(UserMapper.UserModelToUser(user));
        }
    }
}
