using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "mehmet";
            int yas = 36;

            //---------------------------------

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "mehmet h";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "python";
            kurs2.Egitmen = "mehmet h2";
            kurs2.IzlenmeOrani = 78;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "flutter";
            kurs3.Egitmen = "mehmet h3";
            kurs3.IzlenmeOrani = 88;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "sql";
            kurs4.Egitmen = "mehmet h4";
            kurs4.IzlenmeOrani = 98;

            //Console.WriteLine(kurs1.KursAdi+" : "+kurs1.Egitmen+ " : "+kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : |" +kurs.Egitmen + "| time: " +kurs.IzlenmeOrani);
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
