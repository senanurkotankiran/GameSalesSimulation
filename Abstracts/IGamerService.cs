using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstracts
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
