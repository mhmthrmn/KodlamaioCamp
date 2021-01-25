using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //name convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("sepete eklendi2 : "+ urunAdi);
        }
    }
}
