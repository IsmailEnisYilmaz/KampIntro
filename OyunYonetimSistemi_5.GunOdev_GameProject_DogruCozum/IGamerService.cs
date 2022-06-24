using System;
using System.Collections.Generic;
using System.Text;

namespace OyunYonetimSistemi_5.GunOdev_GameProject_DogruCozum
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
