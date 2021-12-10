using System;
using System.Collections.Generic;

namespace MyDictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> isimler = new MyDictionary<int, string>();
            isimler.Add(20, "İsim_1");
            isimler.Add(20, "İsim_2"); // Kullanılan Key Hatası Geliyor mu Test
            isimler.Add(21, "İsim_3"); 
            isimler.Add(22, "İsim_3"); // Aynı value sorun çıkartmamalı!
            isimler.Add(23, "İsim_5");

            isimler.GetDictionary();  // Yazdırsın kendini görelim
        }
    }
}
