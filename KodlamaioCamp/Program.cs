using System;

namespace KodlamaioCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //do not repeat yourself!
            //type safety - tip güvenliği
            //alias - değer tutucu

            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.35;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("degismedi butonu");
            }

            //---------------------------------------------------

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);
        }
    }
}
