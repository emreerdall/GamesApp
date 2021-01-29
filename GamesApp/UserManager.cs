using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserManager : IUserService
    {

        List<User> users = new List<User>();

        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Create(User user)
        {
            if (_userValidationService.Validate(user))
            {
                users.Add(user);
                Console.WriteLine("User is created: " + user.UserFirstName + " " + user.UserSurname + "\n");
            }
            else
            {
                Console.WriteLine("User couldn\'t be created\n");

            }
        }

        public void Delete(User user)
        {
            users.Remove(user);
            Console.WriteLine("User is deleted: " + user.UserFirstName + " " + user.UserSurname + "\n");
        }

        public void Update(User user, string Email, string PhoneNumber)
        {
            user.UserEmail = Email;
            user.UserPhoneNumber = PhoneNumber;

            Console.WriteLine("User is updated: " + user.UserFirstName + " " + user.UserSurname + "\n");
        }

        public void Users()
        {
            Console.WriteLine("Users on the system");
            Console.WriteLine("-------------------");
            foreach (var user in users)
            {
                Console.WriteLine(user.UserFirstName + " " + user.UserSurname);
            }
            Console.WriteLine("");
        }
    }
}
