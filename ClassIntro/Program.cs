using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkan Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + ", İzlenme Oranı %" + kurs.IzlenmeOrani);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}

/*
namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.UrunAdi = "Beyaz Ayakkabı";
            urun1.Kategori = "Giyim";
            urun1.Fiyat = 500;
            urun1.Stok = 1000;
            urun1.Cinsiyet = "Erkek";

            Product urun2 = new Product();
            urun2.UrunAdi = "Etek";
            urun2.Kategori = "Giyim";
            urun2.Fiyat = 150;
            urun2.Stok = 5000;
            urun2.Cinsiyet = "Kadın";

            Product urun3 = new Product();
            urun3.UrunAdi = "T-shirt";
            urun3.Kategori = "Giyim";
            urun3.Fiyat = 110;
            urun3.Stok = 3500;
            urun3.Cinsiyet = "Herkes";

            Product urun4 = new Product();
            urun4.UrunAdi = "Cep Telefonu";
            urun4.Kategori = "Teknoloji";
            urun4.Fiyat = 5500;
            urun4.Stok = 800;
            urun4.Cinsiyet = "Herkes";

            Product[] urunler = new Product[] { urun1, urun2, urun3, urun4 };

            Console.WriteLine("FOR İLE LİSTELEME");
            int sayacfor = 1;
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(sayacfor + ".ÜRÜN");
                Console.WriteLine(urunler[i].UrunAdi + " adlı ürünün kategorisi " + urunler[i].Kategori + "dir. Fiyatı " + urunler[i].Fiyat + "TL olup stokta " + urunler[i].Stok + " tane bulunmaktadır. Ürünümüz " + urunler[i].Cinsiyet + " için uygundur.");
                Console.WriteLine("*****************************************************");
                sayacfor++;
            }
            Console.WriteLine("############################################################################");

            Console.WriteLine("FOREACH İLE LİSTELEME");
            int sayacforeach = 1;
            foreach (var urun in urunler)
            {
                Console.WriteLine(sayacforeach + ".ÜRÜN");
                Console.WriteLine(urun.UrunAdi + " adlı ürünün kategorisi " + urun.Kategori + "dir. Fiyatı " + urun.Fiyat + "TL olup stokta " + urun.Stok + " tane bulunmaktadır. Ürünümüz " + urun.Cinsiyet + " için uygundur.");
                Console.WriteLine("*****************************************************");
                sayacforeach++;
            }
            Console.WriteLine("############################################################################");

            Console.WriteLine("WHILE İLE LİSTELEME");
            int sayacwhile = 1;
            int a = 0;
            while (a < urunler.Length)
            {
                Console.WriteLine(sayacwhile + ".ÜRÜN");
                Console.WriteLine(urunler[a].UrunAdi + " adlı ürünün kategorisi " + urunler[a].Kategori + "dir. Fiyatı " + urunler[a].Fiyat + "TL olup stokta " + urunler[a].Stok + " tane bulunmaktadır. Ürünümüz " + urunler[a].Cinsiyet + " için uygundur.");
                Console.WriteLine("*****************************************************");
                sayacwhile++;
                a++;
            }
        }
    }

    class Product
    {
        public string UrunAdi { get; set; }
        public string Kategori { get; set; }
        public int Fiyat { get; set; }
        public int Stok { get; set; }
        public string Cinsiyet { get; set; }
    }
}
*/