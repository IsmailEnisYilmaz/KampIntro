using System;

namespace GenericMyDictionary4.GunOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> kullaniciIdVeAdlar = new MyDictionary<int,string>();
            Console.WriteLine("Başlangıç Uzunluğu: " + kullaniciIdVeAdlar.Length);
            kullaniciIdVeAdlar.Add(1, "Enis");
            kullaniciIdVeAdlar.Add(2, "Leyla");
            kullaniciIdVeAdlar.Add(3, "Mustafa");
            kullaniciIdVeAdlar.Add(4, "Lale");


            for (int i = 0; i < kullaniciIdVeAdlar.Length; i++)
            {
                Console.WriteLine("ID: "+kullaniciIdVeAdlar.Keys[i] + ", Ad: " + kullaniciIdVeAdlar.Values[i]);
            }
            Console.WriteLine("Bitiş Uzunluğu: " + kullaniciIdVeAdlar.Length);
        }
    }
}
