using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3Ders2Soru2
{
    internal class Program
    {
        public static void Yemekler(int corbaFiyat)
        {
            Console.WriteLine("1- Et Yemeği \n 2-Sebze Yemeği \n 3- Hiçbiri (sadece çorba)");
            int secim = Convert.ToInt32(Console.ReadLine());
            int fiyat = 0;
            if (secim == 1)
            {
                fiyat = corbaFiyat + 300;
                Console.WriteLine("Yemeğin fiyatı: " + 300 + " TL");
            }
            else if (secim == 2)
            {
                fiyat = corbaFiyat + 200;
                Console.WriteLine("Yemeğin fiyatı: " + 200 + " TL");
            }
            else if (secim == 3)
            {
                fiyat = corbaFiyat;
                Console.WriteLine("Yemek istemediniz.");
            }
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız.");
            }

            Console.WriteLine("Aldığınız çorbanın fiyatı: " + corbaFiyat + " TL");
            Console.WriteLine("Toplam fiyat: " + fiyat + " TL");

        }
        public static void Corbalar()
        {
            Console.Error.WriteLine("1-Mercimek Çorbası \n 2-Tavuk Suyu Çorbası \n 3-Diğer");
            int secim = Convert.ToInt32(Console.ReadLine());
            int fiyat = 20;
            if (secim == 1)
            {
                fiyat += 20;
            }
            else if (secim == 2)
            {
                fiyat += 30;
            }
            Yemekler(fiyat);

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Bir seçim yapınız: \n 1-Çorba \n 2-Yemek");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Corbalar();
            }
            else if (secim == 2)
            {
                Yemekler(0);
            }
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız.");
            }
            Console.ReadLine();
        }
    }
}
