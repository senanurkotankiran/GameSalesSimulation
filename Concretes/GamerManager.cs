using GameDemo.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concretes
{
    class GamerManager : IGamerService
    {
        private IGamerValidationService gamerValidationService;

        public GamerManager(IGamerValidationService gamerValidationService)
        {
            this.gamerValidationService = gamerValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (gamerValidationService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Kullanici dogrulamasi yapildi.Kullanici eklendi...");
            }
            else
            {
                Console.WriteLine("Kullanici bilgileri hatali...Tekrar deneyin");
                Console.ReadLine();
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu (kullanıcı) silindi...");
        }
    }
}
