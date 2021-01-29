using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerUserManager : IGamerUserService
    {
        public void Add(User user)
        {
            Console.WriteLine(user.FirstName + " User Added.");
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " User Deleted.");
        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " User Updated.");
        }
    }
}
