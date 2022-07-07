using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi : " + game.Name);
        }



        public void Delete(Game game)
        {
            Console.WriteLine("Oyun sistemden silindi...");
        }
    }
}
