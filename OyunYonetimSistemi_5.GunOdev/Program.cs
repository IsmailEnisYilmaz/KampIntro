using OyunYonetimSistemi_5.GunOdev.Entities;
using OyunYonetimSistemi_5.GunOdev.Concrete;

using System;

namespace OyunYonetimSistemi_5.GunOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.GamerId = 1;
            gamer1.GamerFirstName = "İsmail Enis";
            gamer1.GamerLastName = "Yılmaz";
            gamer1.GamerIdentificationNumber = "11111111111";
            gamer1.GamerBirthYear = "2000";

            GamerCheckService gamerCheckService = new GamerCheckService();
            GamerManager gamerManager = new GamerManager(gamerCheckService);
            gamerManager.GamerSave(gamer1);
            /////////////////////////////////////////////////////////////////////
            Console.WriteLine("*************************************************");
            /////////////////////////////////////////////////////////////////////
            Game game = new Game();
            game.GameId = 1;
            game.GameName = "Call of Duty";
            game.GamePrice = 300;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignGame = game;
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "%10";
            campaign1.CampaignProportion = 10;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.CampaingSave(campaign1);

            /////////////////////////////////////////////////////////////////////
            Console.WriteLine("*************************************************");
            /////////////////////////////////////////////////////////////////////
            
            SaleManager saleManager = new SaleManager();
            saleManager.Sale(campaign1, gamer1);

        }
    }
}
//Gamer--Entities++    //Klasörler --> Entities(Varlık),Abstract(Soyut),Concrete(Somut),Adapters(Dış bir servis ile bağlantıda)
//Campaign--Entities++
//Game--Entities++
//IGamerService--Abstract++
//ICampaignService--Abstract++
//ISaleService--Abstract++
//IEntity--Abstract++
//IGamerCheckService--Abstract(CheckIfRealPerson(gerçek insan kontrolü))++
//GamerManager--Concrete++
//CampaignManager--Concrete++
//SaleManager--Concrete++
//GamerCheckManager--Concrete(Fake kontrol yazacaz)++