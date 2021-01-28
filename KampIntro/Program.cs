using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            string kategoriEtiketi = "Kategori";
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış resmi");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış resmi");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }
            if(sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
