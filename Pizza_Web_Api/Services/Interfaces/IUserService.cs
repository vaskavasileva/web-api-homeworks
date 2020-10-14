using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IUserService
    {
        List<UserModel> GetAllUsers();
        UserModel GetUserById(int id);
        bool UpdateUser(UserModel user);
        bool CreateUser(UserModel user);
        bool DeleteUser(int id);
        UserModel LogInUser(string username, string password);
    }
}
