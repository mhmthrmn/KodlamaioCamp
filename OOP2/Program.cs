using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "mehmet";
            musteri1.Soyadi = "harman";
            musteri1.TcNo = "1111111";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.MusteriNo = "54321";
            musteri2.Id = 2;
            musteri2.SirketAdi = "MHCOMPANY";
            musteri2.VergiNo = "3333333";

            // gerçek - tüzel
            //SOLID

            Musteri musteri3 = new GercekMusteri(); // new görürsen ref.no
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
        }
    }
}
