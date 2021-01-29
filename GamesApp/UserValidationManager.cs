using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.UserFirstName == user.UserFirstName && user.UserSurname == user.UserSurname && 
                user.IdentityId == user.IdentityId && user.DateofBirth.Year == user.DateofBirth.Year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
