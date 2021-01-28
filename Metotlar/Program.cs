using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun listele in urunler)
            {
                Console.WriteLine(listele.Adi);
                Console.WriteLine(listele.Fiyati);
                Console.WriteLine(listele.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("----------Metotlar---------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut","Yeşil armut",12,3);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,9);
            sepetManager.Ekle2("Elma", "Amasya Elması", 12,8);


        }
    }
}
