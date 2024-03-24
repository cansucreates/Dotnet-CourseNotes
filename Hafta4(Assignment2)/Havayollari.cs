using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Assignment2_
{
    internal class Havayollari : Ulasim
    {
        public string firmaAdi;
        private string musteriTipi;

        // constructor metot
        public string MusteriTipi
        {
            get
            {
                return musteriTipi;
            }
            set
            {
                if(value == "standart" || value == "ekonomik" || value == "business")
                {
                    musteriTipi = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz müşteri tipi girdiniz.");
                }
            }
        }

        // ana classtan gelen metodlar

        public void ToplamBiletFiyati()
        {
            float biletFiyati = 1000;
            float toplamFiyat = Ulasim.ToplamBiletFiyati(biletFiyati, adet);
            Console.WriteLine("Toplam bilet fiyatı: " + toplamFiyat);
        }

        public override float KdvHesapla(float toplamFiyat)
        {
            return base.KdvHesapla(toplamFiyat);
        }

        public override void VergiHesapla(float kdvliFiyat)
        {
            base.VergiHesapla(kdvliFiyat);
        }

        // bu sınıfa özel bonus metod

        public void Bonus(float toplamFiyat, string musteriTipi)
        {
            if (musteriTipi == "standart")
            {
                toplamFiyat += toplamFiyat * 15 / 100;
                Console.WriteLine("Standart müşteri tipi toplam fiyatı: " + toplamFiyat);
            }
            else if (musteriTipi == "ekonomik")
            {
                toplamFiyat += toplamFiyat * 10 / 100;
                Console.WriteLine("Ekonomik müşteri tipi toplam fiyatı: " + toplamFiyat);
            }
            else if (musteriTipi == "business")
            {
                toplamFiyat += toplamFiyat * 20 / 100;
                Console.WriteLine("Business müşteri tipi toplam fiyatı: " + toplamFiyat);
            }
        }

    }
}
