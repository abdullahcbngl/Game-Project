using GameProject;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationService());
            gamerManager.Add(new Gamer 
            { 
                ID=1, BirthYear = 1985, FirstName = "Ahmet", LastName = "Kaya", IdentityNumber = 12345 
            
            });

            Game game = new Game();
            game.GameName = "Scum";
            game.Id = 1;
            game.KindOfGame = "Video Game";
            game.GamePrice=50;

            Campaign campaign = new Campaign();
            campaign.CampaignId = 1;
            campaign.CampaignName = "Yeni Kayıt İndirimi";


         


        }
   
        

    }
}
