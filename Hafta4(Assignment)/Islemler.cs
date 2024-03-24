using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Assignment_
{
    internal class Islemler
    {
        // Otomobil fiyatı ve otv oranı alınarak otv fiyatı hesaplanır.
        public static float OtvHesapla(float fiyat, float otv)
        {
            float otvFiyati = fiyat * otv / 100;
            return otvFiyati;
           
        }

        // Otv fiyatı alınarak kdv fiyatı hesaplanır.
        public static float KdvHesapla(float otvFiyati)
        {
            float kdvFiyati = otvFiyati * 5 / 100;
            return kdvFiyati;
        }

        // Kasko ister mi?
        public void Kasko()
        {
            Console.WriteLine("Kasko ister misiniz? (E/H)");
            char kasko = Convert.ToChar(Console.ReadLine());
            if (kasko == 'E')
            {
                Console.WriteLine("Kasko fiyati: 15000 TL");
            }
            else if (kasko == 'H')
            {
                Console.WriteLine("SGK ödemesi: 10000 TL. Lütfen ödeyiniz. ");
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız.");
                Kasko();
            }
        }
    }
}
