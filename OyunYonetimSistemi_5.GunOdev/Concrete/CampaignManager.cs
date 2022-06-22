using OyunYonetimSistemi_5.GunOdev.Abstract;
using OyunYonetimSistemi_5.GunOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunYonetimSistemi_5.GunOdev.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void CampaingDelete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi.");
        }

        public void CampaingSave(Campaign campaign)
        {
            Console.WriteLine("Oyunun Kampayasız Fiyatı: " + (campaign.CampaignGame).GamePrice);
            (campaign.CampaignGame).GamePrice -= ((campaign.CampaignGame).GamePrice)*(campaign.CampaignProportion)/100;
            Console.WriteLine("Oyuna %" + campaign.CampaignProportion + " kampanya uygulandı.");
            Console.WriteLine("Oyunun Yeni Fiyatı: " + (campaign.CampaignGame).GamePrice);
        }

        public void CampaingUpdate(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
    }
}
