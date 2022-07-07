using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstracts
{
    interface IGamerValidationService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
