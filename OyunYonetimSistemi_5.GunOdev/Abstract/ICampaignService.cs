using OyunYonetimSistemi_5.GunOdev.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunYonetimSistemi_5.GunOdev.Abstract
{
    public interface ICampaignService
    {
        void CampaingSave(Campaign campaign);
        void CampaingUpdate(Campaign campaign);
        void CampaingDelete(Campaign campaign);
    }
}
