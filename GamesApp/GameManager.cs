using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        List<Game> games = new List<Game>(); // I couldn't design to create a new list for each user 

        public void Buy(User user, Game game)
        {
            games.Add(game);
            Console.WriteLine($"{game.GameName} is bought by {user.UserFirstName} {user.UserSurname}\n");
        }

        public void Refund(User user, Game game)
        {
            games.Remove(game);
            Console.WriteLine($"{game.GameName} is refund by {user.UserFirstName} {user.UserSurname}\n");
        }

        public void Games()
        {
            Console.WriteLine("User-owned games");
            Console.WriteLine("----------------");
            foreach (var game in games)
            {
                Console.WriteLine(game.GameName + ": " + Convert.ToString(game.GamePrice));
            }
            Console.WriteLine("");
        }
    }
}
