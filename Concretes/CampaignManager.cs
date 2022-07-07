using GameDemo.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concretes
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} kampayasi sisteme eklendi...",campaign.Name);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi...");
        }

        public void Update(Campaign campaignn)
        {
            Console.WriteLine("Kampanya guncellemesi basariyla yapildi...");
        }
    }
}
