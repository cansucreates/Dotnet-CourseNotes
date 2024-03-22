using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3Ders2Overloading
{
    class Program
    {
        /* public static void Topla()
        {
            int x = 25;
            int y = 30;
            int toplam = x + y;
            Console.WriteLine("Toplam: " + toplam);
        }
        public static void Topla(int x, int y)
        {
            int toplam = x + y;
            Console.WriteLine("Toplam: " + toplam);
        }

        public static void Topla(int x, int y, int z)
        {
            int toplam = x + y + z;
            Console.WriteLine("Toplam: " + toplam);
        } */

        public static float Ortalama(float x, float y)
        {
            return (x + y) / 2;
        }

        public static float Ortalama(float x, float y, float z)
        {
            return (x + y + z) / 3;
        }

        public static float Ortalama(float x, float y, float z, float t)
        {
            return (x + y + z + t) / 4;
        }

        static void Main(string[] args)
        {
            // Method overloading: Aynı isimde birden fazla metot tanımlanabilir. Ama 
            // metotların parametre sayıları ve/veya parametre tipleri farklı olmalıdır.
            // ÖRNEK:
            // 1- İlkokul
            // 2- Ortaokul
            // 3- Lise
            // Not ortalaması hesapla hepsinde
            // 1 için 1. ve 2. sınav notu alınacak
            // 2 için 1. 2. ve 3. sınav notu 3.sü sözlü not alınacak
            // 3 için 1. 2 sınav notu 3. sözlü 4.sü proje notu 

            Console.WriteLine ("1- İlkokul \n 2- Ortaokul \n 3- Lise");
            int secim = Convert.ToInt32(Console.ReadLine());

            if (secim == 1)
            {
                Console.WriteLine("1. sınav notu: ");
                float s1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("2. sınav notu: ");
                float s2 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ortalama: " + Ortalama(s1, s2));
            }
            else if (secim == 2)
            {
                Console.WriteLine("1. sınav notu: ");
                float s1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("2. sınav notu: ");
                float s2 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Sözlü notu: ");
                float sozlu = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ortalama: " + Ortalama(s1, s2, sozlu));
            }
            else if (secim == 3)
            {
                Console.WriteLine("1. sınav notu: ");
                float s1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("2. sınav notu: ");
                float s2 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("3. sınav notu: ");
                float s3 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Proje notu: ");
                float proje = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ortalama: " + Ortalama(s1, s2, s3, proje));
            }
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız.");
            }

            Console.ReadLine();


        }
    }
}
