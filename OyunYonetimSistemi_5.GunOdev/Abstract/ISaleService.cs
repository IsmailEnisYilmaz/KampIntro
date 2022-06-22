using OyunYonetimSistemi_5.GunOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunYonetimSistemi_5.GunOdev.Abstract
{
    public interface ISaleService
    {
        void Sale(Campaign campaign,Gamer gamer);
    }
}
