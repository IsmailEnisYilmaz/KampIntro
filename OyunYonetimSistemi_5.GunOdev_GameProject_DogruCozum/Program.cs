using System;

namespace OyunYonetimSistemi_5.GunOdev_GameProject_DogruCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "ENGİN", LastName = "DEMİROĞ", IdentityNumbers = 12345 });
        }
    }
}
