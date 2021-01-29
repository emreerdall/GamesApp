using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserService
    {
        void Create(User user);
        void Update(User user, string Email, string PhoneNumber);
        void Delete(User user);
        void Users();
    }
}
