using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Salih Bora Öztürk";
            kurs1.IzlenmeOrani = 96;
           
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Unity";
            kurs2.Egitmen = "Ali Veli";
            kurs2.IzlenmeOrani = 22;
            
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C++";
            kurs3.Egitmen = "Musti Öztürk";
            kurs3.IzlenmeOrani = 70;

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};
            foreach (Kurs kursdon in kurslar)
            {
                Console.WriteLine(kursdon.KursAdi);
            }

           // Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen);

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
