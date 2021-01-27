using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("mehmet");
            Console.WriteLine(isimler.Length);

            isimler.Add("Mehmet");

            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Elemanlar)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
