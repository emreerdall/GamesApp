using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Discount(Game game, Campaign campaign)
        {
            game.GamePrice = game.GamePrice - campaign.CampaignRate * game.GamePrice;
            Console.WriteLine("Discount is applied\n" +
                              "New Price is: "+Convert.ToString(game.GamePrice));
        }
    }
}
