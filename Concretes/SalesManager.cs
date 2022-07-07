using GameDemo.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concretes
{
    class SalesManager : ISalesService
    {
        public void Sales(Game game, Gamer gamer,Campaign campaign)
        {

            //oyuncu dogrulandıysa oyunu al , indirimi uygula ve satisi yap

            game.Price = game.Price - (game.Price * campaign.Rate/100);
            Console.WriteLine("Oyun" + gamer.FirstName + "tarafindan basariyla satin alindi. Harcanan Fiyat : " + game.Price);
        }
    }
}
