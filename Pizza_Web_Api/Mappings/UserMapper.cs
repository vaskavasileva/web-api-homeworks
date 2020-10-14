using Domain_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mappings
{
    public static class UserMapper
    {
        public static User UserModelToUser(UserModel model)
        {
            return new User()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                Phone = model.Phone,
                Username = model.Username,
                Password = model.Password
            };
        }

        public static UserModel UserToUserModel(User user)
        {
            return new UserModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                Phone = user.Phone,
                Username = user.Username,
                Password = user.Password
            };
        }

        public static List<User> UserModelsToUsers(List<UserModel> models)
        {
            return models.Select(m => UserModelToUser(m)).ToList();
        }

        public static List<UserModel> UsersToUserModels(List<User> users)
        {
            return users.Select(u => UserToUserModel(u)).ToList();
        }
    }
}
