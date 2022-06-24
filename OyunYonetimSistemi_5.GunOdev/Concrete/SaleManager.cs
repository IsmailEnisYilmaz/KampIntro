using OyunYonetimSistemi_5.GunOdev.Abstract;
using OyunYonetimSistemi_5.GunOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunYonetimSistemi_5.GunOdev.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(Campaign campaign, Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " adlı oyuncuya " + (campaign.CampaignGame).GameName + " adlı oyun " + (campaign.CampaignGame).GamePrice + "TL ücretle satılmıştır. " + campaign.CampaignName + " kampanyası uygulanmıştır");
        }
    }
}
