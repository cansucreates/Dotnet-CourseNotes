using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    internal class Program
    {
        static void Main(string[] args)

            // Fullstack Course Notları
        {
            // byte = 1 bayt (0-255)
            // sbyte = 1 bayt (-128 - 127)
            // short = 2 bayt (-32,768 - 32,767)
            // ushort = 2 bayt (0 - 65,535)
            // int = 4 bayt (-2,147,483,648 - 2,147,483,647)
            // uint = 4 bayt (0 - 4,294,967,295)
            // long = 8 bayt (-9,223,372,036,854,775,808 - 9,223,372,036,854,775,807)
            // ulong = 8 bayt (0 - 18,446,744,073,709,551,615)
            // float = 4 bayt (1.5 x 10^-45 - 3.4 x 10^38)
            // double = 8 bayt (5.0 x 10^-324 - 1.7 x 10^308)
            // decimal = 16 bayt (1.0 x 10^-28 - 7.9 x 10^28)
            // char = 2 bayt (0 - 65,535)
            // bool = 1 bayt (true, false)
            // string = 2 byte * karakter sayısı
            // object = 4 byte (32 bit) veya 8 byte (64 bit)
            // var = değişkenin türü derleme zamanında belirlenir
            // datetime tarih = new datetime(2019, 1, 1); // class üzerinden çalışır

            /* string ad = "Ahmet";
            string soyad = "Yılmaz";
            int yas = 25;
            bool evliMi = false;

            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Yaş: " + yas);
            Console.WriteLine("Evli mi: " + evliMi);


            Console.WriteLine("Fiyat giriniz: ");
            int fiyat = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Cinsiyet giriniz: E/K ");
            char cinsiyet = Convert.ToChar(Console.ReadLine()); */

            // CTRL + K + C = Comment


            // 3. DERS 28.02.2024

            // PROBLEM 1 - KISA VE UZUN KENAR ÖLÇÜSÜ GİRİLEN DİKDÖRTGENİN ALANINI VE ÇEVRESİNİ HESAPLAYAN PROGRAM

            Console.WriteLine("Kısa kenar ölçüsü giriniz: ");
            float kisaKenar = Convert.ToSingle(Console.ReadLine());
            float uzunKenar = Convert.ToSingle(Console.ReadLine());

            float alan = kisaKenar * uzunKenar;
            float cevre = (kisaKenar + uzunKenar) * 2;

            Console.WriteLine("Alan: " + alan);
            Console.WriteLine("Çevre: " + cevre);

            Console.WriteLine("diktörgenin alanı: " + (kisaKenar * uzunKenar));
            Console.WriteLine("diktörgenin çevresi: " + (2 * (kisaKenar + uzunKenar)));

            // PROBLEM 2 - NOTLARI ALIP ORTALAMAYI HESAPLAYAN VE 50'DEN BÜYÜKSE GEÇTİ, DİĞERLERİ İÇİN KALDI YAZDIRAN PROGRAM

            //Console.WriteLine("1. Notu giriniz: ");
            //float not1 = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("2. Notu giriniz: ");
            //float not2 = Convert.ToSingle(Console.ReadLine());

            //float ortalama = (not1 + not2) / 2;

            //if (ortalama >= 50)
            //{
            //    Console.WriteLine("Geçti");
            //}
            //else
            //{
            //    Console.WriteLine("Kaldı");
            //}

            Console.WriteLine("1. Notu giriniz: ");
            float not1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("2. Notu giriniz: ");
            float not2 = Convert.ToSingle(Console.ReadLine());

            if((not1+not2)/2>= 50) // Bir değişkenin değerini kullanmadan direk işlem yapılabilir.
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }

            // PROBLEM 3 - KULLANICI ADI VE ŞİFRE İLE GİRİŞ YAPAN PROGRAM
            string k_adi = "admin"; 
            string sif = "12345";


            Console.WriteLine("Kullanıcı adını giriniz: ");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz: ");
            string sifre = Console.ReadLine();


            if (k_adi == kullaniciAdi && sif == sifre)
            {
                Console.WriteLine("Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı");
            }

            // iç içe if kullanımı

            if (k_adi == kullaniciAdi)
            {
                Console.WriteLine("Şifrenizi giriniz:");

                if (sif == sifre)
                {
                    Console.WriteLine("Giriş başarılı");
                }
                else
                {
                    Console.WriteLine("Şifre hatalı");
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı adı hatalı");
            }

            // PROBLEM 4 - ÖĞRENCİNİN NOTU 0 İSE DERS TEKRARU
            // NOTU 100 İSE BAŞARILARIN DEVAMINI DİLERİM
            // NOTU 50DEN BÜYÜKSE GEÇTİ DEĞİLSE KALDI YAZDIRAN PROGRAM

            notalani:
            Console.WriteLine("Öğrencinin notunu giriniz: ");
            byte not = Convert.ToByte(Console.ReadLine());

            if (not == 0)
            {
                Console.WriteLine("Ders tekrarı");
            }
            else if (not == 100)
            {
                Console.WriteLine("Başarıların devamını dilerim");
            }
            else if (not >= 50)
            {
                Console.WriteLine("Geçti");
            }
            else
            {
                Console.WriteLine("Kaldı");
            }

            goto notalani; // goto komutu ile programın başına dönebiliriz.


            // PROBLEM 5 - 100 lük sistemdeki notu girilen öğrencinin notunu 5lik sistemdeki not karşılığını bulan program
            // 0-40 için 1
            // 40-55 için 2
            // 55-70 için 3
            // 70-85 için 4
            // 85-100 için 5

            Console.WriteLine("Notunuzu giriniz: ");
            byte yuzlukNot = Convert.ToByte(Console.ReadLine());

            if(yuzlukNot < 0 || yuzlukNot > 100)
            {
                Console.WriteLine("Geçersiz not girdiniz");
            }

            else
            {
                if (yuzlukNot < 40)
                {
                    Console.WriteLine("5'lik sistemde notunuz: 1");
                }
                else if (yuzlukNot < 55)
                {
                    Console.WriteLine("5'lik sistemde notunuz: 2");
                }
                else if (yuzlukNot < 70)
                {
                    Console.WriteLine("5'lik sistemde notunuz: 3");
                }
                else if (yuzlukNot < 85)
                {
                    Console.WriteLine("5'lik sistemde notunuz: 4");
                }
                else if (yuzlukNot <= 100)
                {
                    Console.WriteLine("5'lik sistemde notunuz: 5");
                }
            }



 










        }
    }
}
