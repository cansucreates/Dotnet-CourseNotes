using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3Ders2RefOut
{
    internal class Program
    {
        public static void Hesaplama(int x)
        {
            x += 20;
        }
        public static void Hesaplama2(ref int x) // ramdeki value değeri değişir
        {
            x += 20;
        }

        static void Main(string[] args)
        {
            // ref ve out keywordleri ile metotlara parametre gönderme
            // ref için sayının bir başlangıç değeri olmalıdır
            // out için sayının mainde bir başlangıç değeri olmasına gerek yoktur.
            // out için metot içerisinde bir değer atanmalıdır.
            int sayi = 10;
            Hesaplama(sayi);

            Hesaplama2(ref sayi); // ref keywordü ile metoda gönderilen parametre değeri değişir
            
        }
    }
}
