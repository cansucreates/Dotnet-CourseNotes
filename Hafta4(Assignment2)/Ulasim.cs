using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Assignment2_
{
    abstract internal class Ulasim // Main class. Sadece ana class olarak kullanılabilir. Soyutlanmış. AnA classtan nesne üretilemez!!! Sadece childs.
        // abstract classlar içerisinde abstract methodlar bulunabilir.
    {
        private string seferNo;
        private string seferAdi;
        private string guzergah;
        public string soforAdi;
        public float biletFiyati;
        public int adet;


        // istenen propertylerin get ve set metotları
        public string SeferNo
        {
            get { return seferNo; }
            set
            {
                if (value.Length == 4)
                {
                    seferNo = value;
                }
                else
                {
                    Console.WriteLine("Sefer No 4 karakter olmalıdır.");
                    Console.WriteLine("Sefer No'yu yeniden giriniz: ");
                    // yeniden girilmesi için kullanıcıdan input alınıyor.
                    seferNo = Console.ReadLine();
                }
            }
        }

        public string SeferAdi
        {
            get
            {
                return seferAdi;
            }

            set
            {
                if(value == "sehirici")
                {
                    seferAdi = value;
                }
                else
                {
                    Console.WriteLine("Sefer adı sehirici olmalıdır.");
                    seferAdi = Console.ReadLine();
                }
            }
        }

        public string Guzergah
        {
            get
            {
                return guzergah;
            }

            set
            {
                if(value == "gebze" || value == "ataşehir" || value == "bağcılar" )
                {
                    guzergah = value;
                }
                else
                {
                    Console.WriteLine("Güzergah gebze, ataşehir ya da bağcılardan biri olmalıdır.");
                    guzergah = Console.ReadLine();
                }
            }
        }

        // classın metodları
        // toplam fiyat hesaplama
        public static float ToplamBiletFiyati(float biletFiyati, int adet)
        {
            float toplamFiyat = biletFiyati * adet;
            return toplamFiyat;
        }

        // kdv hesaplama
        public virtual float KdvHesapla(float toplamFiyat)
        {
            float kdv = toplamFiyat * 5 / 100;
            float kdvliFiyat = toplamFiyat + kdv;
            return kdvliFiyat;
        }

        // vergi hesaplama
        public virtual void VergiHesapla(float kdvliFiyat)
        {
            if (kdvliFiyat > 100 && kdvliFiyat < 500)
            {
                Console.WriteLine("Vergi: " + kdvliFiyat * 2 / 100); // %2 vergi
            }
            else if (kdvliFiyat > 500 && kdvliFiyat < 1000)
            {
                Console.WriteLine("Vergi: " + kdvliFiyat * 5 / 100); // %5 vergi
            }
        }
    }
}
