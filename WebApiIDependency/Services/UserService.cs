using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiIDependency.Models;

namespace WebApiIDependency.Services
{
    public class UserService
    {
        public User ValidateUser(string email, string password)
        {
            // Here you can write the code to validate
            // User from database and return accordingly
            // To test we use dummy list here
            //var userList = GetUserList();
            //var user = userList.FirstOrDefault(x => x.Email == email && x.Password == password);
            return new User { Name = "alex" };
        }

        //public List<User> GetUserList()
        //{
        //    // Create the list of user and return           
        //}
    }
}