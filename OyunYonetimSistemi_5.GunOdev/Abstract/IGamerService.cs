using OyunYonetimSistemi_5.GunOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunYonetimSistemi_5.GunOdev.Abstract
{
    public interface IGamerService
    {
        void GamerSave(Gamer gamer);
        void GamerUpdate(Gamer gamer);
        void GamerDelete(Gamer gamer);
    }
}
