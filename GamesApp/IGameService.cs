using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameService
    {
        void Buy(User user,Game game);
        void Refund(User user, Game game);
        void Games();
    }
}
