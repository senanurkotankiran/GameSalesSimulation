using GameDemo.Abstracts;
using GameDemo.Concretes;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.NationalityId = 32947797828;
            gamer1.FirstName = "Senanur";
            gamer1.LastName = "Kotankıran";
            gamer1.Year = new DateTime(2003, 2, 12);

            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            gamerManager.Add(gamer1);

            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "House Flipper";
            game1.Price = 140;

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "Yaz";
            campaign1.Rate = 10;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game1,gamer1,campaign1);
            
        }
    }
}
