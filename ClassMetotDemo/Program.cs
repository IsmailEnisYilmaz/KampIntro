using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = 1;
            musteri1.MusteriAd = "Emel";
            musteri1.MusteriSoyad = "Kırklareli";
            musteri1.MusteriCinsiyet = "Kadın";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriID = 2;
            musteri2.MusteriAd = "İsmail Enis";
            musteri2.MusteriSoyad = "Yılmaz";
            musteri2.MusteriCinsiyet = "Erkek";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriID = 3;
            musteri3.MusteriAd = "Ali";
            musteri3.MusteriSoyad = "Veli";
            musteri3.MusteriCinsiyet = "Erkek";

            Musteri musteri4 = new Musteri();
            musteri4.MusteriID =4;
            musteri4.MusteriAd = "Hande";
            musteri4.MusteriSoyad = "Lale";
            musteri4.MusteriCinsiyet = "Kadın";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine("*************************************");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            Console.WriteLine("*************************************");
            musteriManager.MusteriListele(musteri1, musteri2, musteri3, musteri4);
        }
    }
}
