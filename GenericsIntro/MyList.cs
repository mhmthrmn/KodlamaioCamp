using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] elemanlar;
        //constructor
        public MyList()
        {
            elemanlar = new T[0];
        }
        public void Add(T eleman)
        {
            T[] tempElemanlar = elemanlar;
            elemanlar = new T[elemanlar.Length + 1];
            for (int i = 0; i < tempElemanlar.Length; i++)
            {
                elemanlar[i] = tempElemanlar[i];
            }
            elemanlar[elemanlar.Length - 1] = eleman;
        }
    }
}
