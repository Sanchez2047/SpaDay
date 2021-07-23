using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Data
{
    public class UserData
    {
        private static List<User> _users = new List<User>();
        public static void Add(User newUser)
        {
            _users.Add(newUser);
        }

    }
}
