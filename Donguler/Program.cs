using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici kursu";
            string kurs2 = "programlamaya başlangıç kursu";
            string kurs3 = "java";
            string kurs4 = "python";
            string kurs5 = "c++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            //array - dizi

            string[] kurslar = new string[] { "yazılım geliştirici kursu", "programlamaya başlangıç kursu", "java","python","c++" };

            for (int i = 0; i < kurslar.Length; i++) //i+=2 i=i+2 i++
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("sayfa sonu");
        }
    }
}
