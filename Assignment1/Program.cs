using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ÇALIŞMA SORULARI 

            // PROBLEM 1 - SUYUN SICAKLIK DEĞERİ DİRİLDİĞİNDE SUYUN SICAKLIĞINA GÖRE MADDENİN HALİNİ(KATI,SIVI,GAZ)
            // GÖSTEREN PROGRAM. NOT: SUYUN KAYNAMA ISISI 100 DONMA ISISI 0 DERECE.
            Console.WriteLine("Suyun sıcaklık değerini giriniz: ");
            int suSicaklik = Convert.ToInt32(Console.ReadLine());

            if (suSicaklik <= 0)
            {
                Console.WriteLine("Su katı haldedir.");
            }
            else if (suSicaklik > 0 && suSicaklik < 100)
            {
                Console.WriteLine("Su sıvı haldedir.");
            }
            else
            {
                Console.WriteLine("Su gaz haldedir.");
            }

            // PROBLEM 2 - 2. Klavyeden girilen bir sayının kullanıcı seçimine bağlı olarak karesini, küpünü ve karekökünü
            // alan program

            Console.WriteLine("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1-Karesini almak için seçiniz\n2-Küpünü almak için seçiniz\n3-Karekökünü almak için seçiniz");
            char secim = Convert.ToChar(Console.ReadLine());

            if (secim == '1')
            {
                Console.WriteLine("Sayının karesi: " + (sayi * sayi));
            }
            else if (secim == '2')
            {
                Console.WriteLine("Sayının küpü: " + (sayi * sayi * sayi));
            }
            else if (secim == '3')
            {
                Console.WriteLine("Sayının karekökü: " + Math.Sqrt(sayi));
            }
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız.");
            }

            // PROBLEM 3 - KLAVYEDEN GİRİLEN 3 SAYININ EN KÜÇÜĞÜNÜ BULAN PROGRAM

            Console.WriteLine("1. sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. sayıyı giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 < sayi2 && sayi1 < sayi3)
            {
                Console.WriteLine("En küçük sayı: " + sayi1);
            }
            else if(sayi2 < sayi1 && sayi2 < sayi3)
            {
                Console.WriteLine("En küçük sayı: " + sayi2);
            }
            else
            {
                Console.WriteLine("En küçük sayı: " + sayi3);
            } 

            /* PROBLEM 4 - Klavyeden girilen boy ve cinsiyet bilgilerine göre kişinin ideal kilosunu aşağıdaki
            açıklamaya göre hesaplayıp ekrana “İdeal Kilonuz = ...” şeklinde yazdırınız.
            Not: Hesaplama Kadın için ayrı erkek için ayrı aşağıdaki bilgilere göre yapılık ekrana
            yazdırılacak.
            Kadınlar için: Boyunuzun ilk 150 santimetresi için 45 kilo, sonraki her 2.5 cm için 2.2 kilo
            ekler.
            Örnek olarak; boyunuz 160 cm ise, ideal kilonuz 45 + 8.8 = 53.8 kilogram olacaktır.
            Erkekler için: Boyunuzun ilk 150 santimetresi için 48 kilo, sonraki her 2.5 cm için 2.7 kilo
            ekler.
            Örnek olarak boyunuz 180 cm ise, ideal kilonuz 48 + 32.4 = 80.4 kilogram olacaktır  */

            Console.WriteLine("Boyunuzu giriniz: ");
            float boy = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Cinsiyetinizi giriniz: E/K ");
            char cinsiyet = Convert.ToChar(Console.ReadLine());

            if (cinsiyet == 'K')
            {
                if(boy >= 150)
                {
                    float idealKilo = 45 + ((boy - 150) / 2.5f) * 2.2f;
                    Console.WriteLine("İdeal kilonuz: " + idealKilo);
                }
                else
                {
                    Console.WriteLine("Hatalı boy girdiniz.");
                }
            }

            else if (cinsiyet == 'E')
            {
                if(boy >= 150)
                {
                    float idealKilo = 48 + ((boy - 150) / 2.5f) * 2.7f;
                    Console.WriteLine("İdeal kilonuz: " + idealKilo);
                }
                else
                {
                    Console.WriteLine("Hatalı boy girdiniz.");
                }
            }

            else
            {
                Console.WriteLine("Hatalı cinsiyet girdiniz.");
            }

            Console.ReadLine(); 

            
            
            // PROBLEM 5 - Muhtaç öğrencilere taban olarak 1000TL burs verilmektedir. Ancak öğrencinin okuduğu
            // okula göre bu paranın üzerine belirli miktarda ekleme yapılacaktır.Eğer ilkokul ise ekleme
            // yapılmayacak, ortaokul ise 20TL, lise ise 50TL, üniversite ise 100TL eklenecektir

            Console.WriteLine("Okul türünü giriniz: İlkokul, Ortaokul, Lise, Üniversite");
            string okulTuru = Console.ReadLine();

            int burs = 1000;

            if (okulTuru == "İlkokul")
            {
                Console.WriteLine("Burs miktarı: " + burs);
            }
            else if (okulTuru == "Ortaokul")
            {
                Console.WriteLine("Burs miktarı: " + (burs + 20));
            }
            else if (okulTuru == "Lise")
            {
                Console.WriteLine("Burs miktarı: " + (burs + 50));
            }
            else if (okulTuru == "Üniversite")
            {
                Console.WriteLine("Burs miktarı: " + (burs + 100));
            }
            else
            {
                Console.WriteLine("Hatalı okul türü girdiniz.");
            }

            

            // PROBLEM 6:   Bir satıcı sattığı mallardan belirli oranda komisyon almaktadır. 200TL’ye kadar olan
            // satışlardan % 3, daha fazla olanlardan ise % 2 komisyon almaktadır. Buna göre
            // klavyeden girilen 3 satış tutarından satıcının alacağı komisyonları ve toplam komisyonu
            // ekrana yazan program. (Not: Henüz döngüleri öğrenmedik döngü kullanmayınız).

            Console.WriteLine("1. satış tutarını giriniz: ");
            float satis1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("2. satış tutarını giriniz: ");
            float satis2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("3. satış tutarını giriniz: ");
            float satis3 = Convert.ToSingle(Console.ReadLine());

            float komisyon1 = 0;
            float komisyon2 = 0;
            float komisyon3 = 0;

            if (satis1 <= 200)
            {
                komisyon1 = satis1 * 3 / 100;
            }
            else
            {
                komisyon1 = satis1 * 2 / 100;
            }

            if (satis2 <= 200)
            {
                komisyon2 = satis2 * 3 / 100;
            }
            else
            {
                komisyon2 = satis2 * 2 / 100;
            }

            if (satis3 <= 200)
            {
                komisyon3 = satis3 * 3 / 100;
            }
            else
            {
                komisyon3 = satis3 * 2 / 100;
            }

            float toplamKomisyon = komisyon1 + komisyon2 + komisyon3;
            Console.WriteLine("1. satışın komisyonu: " + komisyon1);
            Console.WriteLine("2. satışın komisyonu: " + komisyon2);
            Console.WriteLine("3. satışın komisyonu: " + komisyon3);
            Console.WriteLine("Toplam komisyon: " + toplamKomisyon);

            

            // PROBLEM 7: Aylık elektrik faturası hesaplanacaktır. Kullanıcıdan kaç kWh tükettiğini alınız. Eğer
            // tüketim 150’den küçükse kWh’i 10 kuruş, eğer 150 ile 300 arasında ise 20 kuruş, 300
            // üzeri ise 40 kuruş olarak hesaplanmaktadır.Kişinin yaptığı tüketime göre faturasının kaç
            // TL olacağını hesaplayıp ekrana yazan program.

            Console.WriteLine("Kaç kWh tükettiğinizi giriniz: ");
            float tuketim = Convert.ToSingle(Console.ReadLine());

            float fatura = 0;

            if(tuketim < 150)
            {
                fatura = tuketim * 10 / 100;
            }
            else if(tuketim >= 150 && tuketim <= 300)
            {
                fatura = tuketim * 20 / 100;
            }
            else
            {
                fatura = tuketim * 40 / 100;
            }

            Console.WriteLine("Faturanız: " + fatura + " TL");


            Console.ReadLine();



        }
    }
}
