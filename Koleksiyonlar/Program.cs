﻿using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] isimler = new string[] { "mehmet", "kerem", "engin", "halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5]; //bellekte yeni 5 elemanlı array oluştu.aslında ekleme yapmadık.önceki array bellekten silindi
            isimler[4] = "ilker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
            */ // ctrl+k + ctrl+c

            List<string> isimler2 = new List<string> { "mehmet", "kerem", "engin", "halil" };
            
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("Mehmet");

            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
