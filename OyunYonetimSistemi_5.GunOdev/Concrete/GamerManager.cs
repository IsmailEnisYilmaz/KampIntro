using OyunYonetimSistemi_5.GunOdev.Abstract;
using OyunYonetimSistemi_5.GunOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunYonetimSistemi_5.GunOdev.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;


        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void GamerDelete(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " adlı oyuncu sistemden silindi.");
        }

        public void GamerSave(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.GamerFirstName + " adlı oyuncu sisteme eklendi.");
            }
            else
            {
                throw new Exception("Kişi geçerli değil.");
            }
            
        }

        public void GamerUpdate(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " adlı oyuncu güncellendi.");
        }
    }
}
