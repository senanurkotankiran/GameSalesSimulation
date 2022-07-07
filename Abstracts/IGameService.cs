using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
    }
}
