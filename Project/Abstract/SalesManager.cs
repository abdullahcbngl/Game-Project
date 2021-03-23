using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISellService
    {
        public void Sell(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName+"\t"+gamer.LastName+"\t"+game.GameName+"oyununu"+campaign.CampaignName+"kampayasından yararlanarak satın aldı.");

        }

       
    }
}
