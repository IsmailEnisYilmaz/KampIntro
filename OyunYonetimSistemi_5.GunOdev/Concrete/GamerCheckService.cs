using OyunYonetimSistemi_5.GunOdev.Abstract;
using OyunYonetimSistemi_5.GunOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunYonetimSistemi_5.GunOdev.Concrete
{
    public class GamerCheckService : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
