using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User()
            {
                UserId = 1,
                IdentityId = "12345678910",
                UserFirstName = "Emre",
                UserSurname = "Erdal",
                DateofBirth = new DateTime(1996, 08, 18),
                UserEmail = "EmreMail@gmail.com",
                UserPhoneNumber = "05310120101"
            };

            User user2 = new User()
            {
                UserId = 2,
                IdentityId = "123456",
                UserFirstName = "Engin",
                UserSurname = "Demiroğ",
                DateofBirth = new DateTime(1985, 01, 06),
                UserEmail = "EnginMail@gmail.com",
                UserPhoneNumber = "05310120102"
            };


            UserManager userManager = new UserManager(new UserValidationManager());
            userManager.Create(user1);
            userManager.Create(user2);

            userManager.Users();


            Game game1 = new Game()
            {
                GameId = 1,
                GameName = "AnyGame",
                GamePrice = 199.50
            };
            GameManager gameManager = new GameManager();
            gameManager.Buy(user1, game1);

            gameManager.Games();

            Campaign campaign1 = new Campaign()
            {
                CampaignId = 1,
                CampaignName = "TheCampaign",
                CampaignRate = 0.2
            };

            CampaignManager CampaignManager = new CampaignManager();
            CampaignManager.Discount(game1, campaign1);

            Console.ReadKey();
        }
    }
}
