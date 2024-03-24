using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Assignment2_
{
    internal class Karayollari : Ulasim // Karayolları sınıfı Ulasim sınıfından türetilmiştir.
    {
        // karayolları kendi fieldları
        private string plakaNo;
        private int turSayisi;
        public float gunlukKazanc;

        // plakaNo property'si
        public string PlakaNo
        {
            get { return plakaNo; }
            set
            {
                if(value.Length == 7)
                {
                    plakaNo = value;
                }
                else
                {
                    Console.WriteLine("Plaka No 7 karakter olmalıdır.");
                    Console.WriteLine("Plaka No'yu yeniden giriniz: ");
                    plakaNo = Console.ReadLine();
                }
            }
        }
        // turSayisi property'si
        public int TurSayisi
        {
            get
            {
                return turSayisi;
            }
            set
            {
                if(value > 0 && value < 11)
                {
                    turSayisi = value;
                }
                else
                {
                    Console.WriteLine("Tur sayısı 1 ile 10 arasında olmalıdır.");
                    Console.WriteLine("Tur sayısını yeniden giriniz: ");
                    turSayisi = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        // inheritance ile gelen metodların kullanımı ve virtual methodların override edilmesi
        public void ToplamBiletFiyati()
        {
            float biletFiyati = 199.9f; // fixed fiyat
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

        // karayolları sınıfına özel metodlar
        public void HaftalikKazanc(string guzergah, int turSayisi)
        {
            if (guzergah == "ataşehir" && turSayisi < 5)
            {
                float gelirVergisi = gunlukKazanc * 3 / 100;
                float haftalikKazanc = (gunlukKazanc * turSayisi) - gelirVergisi;
                Console.WriteLine("Haftalık kazancınız: " + haftalikKazanc);
            }
            else if (guzergah == "gebze" && turSayisi > 5)
            {
                float gelirVergisi = gunlukKazanc * 6 / 100;
                float haftalikKazanc = (gunlukKazanc * turSayisi) - gelirVergisi;
                Console.WriteLine("Haftalık kazancınız: " + haftalikKazanc);
            }
            else
            {
                Console.WriteLine("Haftalık kazancınız: " + gunlukKazanc * turSayisi);
            }
        }




    }
}
