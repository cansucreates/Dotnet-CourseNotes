using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinciHafta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PAZARTESİ 04 MART 2024

            // DÖNGÜLER
            // Switch Case problemi
            // Eğitim durumuna göre Lise için 1000 tl diğer tüm durumlar için 2000 burs miktarı gösteren program
            // burslarda yaş da sorulsun yaşı lise için 17den küçükler için bu burs verilsin
            // diğerlerinde 25 den küçükler için burs verilsin
            /* Console.WriteLine("Eğitim durumunuzu seçiniz Lise için 1 \n Önlisans için 2 \n Lisans için 3 \n Yüksek Lisans için 4");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch(secim)
            {
                case 1: 
                   Console.WriteLine("Yaşınızı giriniz: ");
                        int yas = Convert.ToInt32(Console.ReadLine());
                    switch(yas)
                    {
                        case int x when x <= 17:
                            Console.WriteLine("Burs miktarınız 1000 TL");
                            break;
                        default:
                            Console.WriteLine("Yaşınız uygun değil");
                            break;
                    }
                    break;
               case int x when (x >= 2 && x <= 4):
                    Console.WriteLine("Yaşınızı giriniz: ");
                    int yas2 = Convert.ToInt32(Console.ReadLine());
                    switch(yas2)
                    {
                        case int x when x <= 25:
                            Console.WriteLine("Burs miktarınız 2000 TL");
                            break;
                        default:
                            Console.WriteLine("Yaşınız uygun değil");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim");
                    break;


            // DÖNGÜLER:
             1. For Döngüleri ---dizi, koleksiyonlar üzerinde dolaşmak için çok kullanılır
             2. ForEach Döngüleri --mvc, .net, core listeleme yaparken en çok kullanılan döngü
             3. While Döngüleri --- ado.net te veritabanı işlemlerinde çok kullanılır
             4. Do While Döngüleri
             
            // 1. For Döngüleri
            //  1 den 10 a kadar olan sayıları ekrana yazdıran program
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("*********************************************");

            // 10 dan 1 e kadar olan sayıları ekrana yazdıran program
            for (int i = 10; i >= 1; i--)
            {
                           Console.WriteLine(i);
                        }

                        // 7 ile 35 arasındaki sayıların toplamı 
                        int toplam = 0;
                        for (int i = 7; i<35; i++)
                        {
                            toplam += i;
                        }
                        Console.WriteLine("7 ile 35 arasındaki sayıların toplamı: " + toplam);

                        // 7 ile 35 arasındaki sayıların ortalaması
                        int toplam2 = 0;
                        int sayac = 0; // sayı adedi
                        for(int i = 7; i<35; i++)
                        {
                            sayac++;
                            toplam2 += i;
                        }
                        Console.WriteLine("7 ile 35 arasındaki sayıların ortalaması: " + toplam2 / sayac);

                        // dışardan girilen 10 sayının toplamı
                        float toplam3 = 0;
                        for(int i = 1; i<=10; i++) // 10 kere dönecek (içerde illa i kullanmak zorunda değiliz)
                        {
                            Console.WriteLine( i + ". sayıyı giriniz: ");
                            float sayi = Convert.ToSingle(Console.ReadLine());
                            toplam3 += sayi;
                        }

                        // Örnek: dışarıdan girilen 6 sayıdan çift olanların toplamını tek olanların adedini bulan program
                        int toplam4 = 0;
                        int tekAdet = 0;
                        for (int i = 1; i <= 6; i++)
                        {
                            Console.WriteLine( i + ". Sayıyı giriniz: ");
                            int sayi = Convert.ToInt32(Console.ReadLine());
                            if (sayi%2 == 0)
                            {
                                toplam4 += sayi;
                            }
                            else
                            {
                                tekAdet++;
                            }
                        }

                        // SALI. 05 MART 2024

                        // While Döngüleri
                        // Parantez içinde tanımlanan koşul sağlandığı sürece döngü devam eder.

                        // birden 10 a kadar olan sayıları ekrana yazdıran program

                        int toplam5 = 0;
                        int sayi = 0;

                        while (sayi < 10)
                        {
                            sayi++;
                            toplam5 += sayi;
                        }

                        // dışarıdan girilen 6 sayıdan çift olanların toplamını tek olanların adedini bulan program
                        int toplam6 = 0;
                        int tekAdet2 = 0;

                        int i = 0;
                        while(i < 6)
                        {
                            i++;
                            Console.WriteLine(i + ". sayıyı giriniz: ");
                            int sayi2 = Convert.ToInt32(Console.ReadLine());

                            if (sayi2 % 2 == 0)
                            {
                                toplam6 += sayi2;
                            }
                            else
                            {
                                tekAdet2++;
                            }
                        }

                        // dışarıdan girilen sayının faktöriyelini bulan program

                        Console.WriteLine("Sayıyı giriniz: ");
                        int sayi3 = Convert.ToInt32(Console.ReadLine());

                        int faktoriyel = 1;
                        int j = 1;
                        while(j <= sayi3)
                        {
                            faktoriyel *= j;
                            j++;
                        }

                        // klavyeden 15 sayı girilene kadar girilen sayıların toplamını bulan program

                        int toplam7 = 0;
                        int k = 0;
                        while (k != 15)
                        {
                            Console.WriteLine("Sayıyı giriniz: ");
                            k = Convert.ToInt32(Console.ReadLine());

                            if (k == 15)
                            {
                                break;
                            }

                            toplam7 += k;
                         }
                        Console.WriteLine("Toplam: " + toplam7);

                        // klavyeden negatif sayı girilene kadar girilen sayıların toplamını bulan program

                        int toplamz = 0;
            int ix = 0;

                    while (ix >= 0)
            {
                Console.WriteLine("Sayıyı giriniz: ");
                        ix = Convert.ToInt32(Console.ReadLine());

                if (ix < 0)
                {
                    break;
                }

                toplam += ix;
            }

            Console.WriteLine("Toplam: " + toplam);
            Console.ReadLine(); 

            int toplam = 0;

            while (true)
            {
                Console.WriteLine("Sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi >= 0)
                {
                    toplam += sayi;

                }
                else
                {
                    break;
                }
            }
            

                // Random: rastgele değer atama.
                // Random bir classtır .net frameworkte

                Random rastgele = new Random(); // classtan bir nesne oluşturduk

                int sayi = rastgele.Next(10, 100); // 10 ile 100 arasında rastgele bir sayı üret
                                                   // 

            // 10 ile 100 arasında 10 adet rastgele sayı üretip ekrana yazdıran program
            int toplam = 0;
            int i = 0;
            Random random = new Random();
            while (i < 10)
            {
                i++;
                
                sayi = random.Next(10, 100);
                Console.WriteLine(sayi);
                toplam += sayi;
            }
            

            // Diziler (Arrays)
            // Aynı türdeki verileri saklamak için kullanılır.
            // diziler değerlerini belleğin heap bölgesinde saklar.

            int[] sayilar = new int[4]; // 4 elemanlı bir dizi tanımladık
            sayilar[0] = 15;
            sayilar[1] = 20;
            sayilar[2] = 45;
            sayilar[3] = 55;  // Dizi uzunluğu 4 olduğu için 0,1,2,3 indexleri vardır.

            // ForEach Döngüsü // dizinin uzunluğunu bilmediğimiz durumlarda kullanılır

            int[] sayilar1 = { 20, 56, 100, 50, 45 };
            Console.WriteLine(sayilar1[0]);

            foreach (int sayi in sayilar1) // Sayi dizinin türünden olmak zorunda
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("*********************************************");

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            


            // Örnek:

            Console.WriteLine("Kaç adet sayı gireceksiniz: ");
            int adet = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[adet]; // adet kadar elemanlı bir dizi tanımladık

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine((i+1) + ". sayıyı giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Girilen sayılar: ");
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }

            Console.ReadLine();

            Console.WriteLine("*********************************************");

            */

            // DERS 3. 06-03-2024

            // DİZİLER  
            // System.Array sınıfından türetilmiş bir sınıftır.

            // Matris dizileri (çok boyutlu diziler)

            // int[,] dizi = new int[3, 3]; // 3x3 lük bir matris tanımladık

            int[,] notlar = { { 1001, 60 }, {1003,100 }, {1005,80 } };
            Console.WriteLine(notlar[0,0]); // 0'ıncı satır 0'ıncı sütun (1001)
            Console.WriteLine(notlar[0,1]); // 0'ıncı satır 1'inci sütun (60)
            Console.WriteLine(notlar[1,0]); // 1'inci satır 0'ıncı sütun (1003)

            // Düzensiz diziler (jagged arrays)
            // Dizilerin içinde dizilerin bulunduğu yapıdır.
            // Dizilerin içindeki dizilerin uzunlukları farklı olabilir.
            int[][] jaggedArray = new int[3][]; // 3 elemanlı bir dizi tanımladık
            jaggedArray[0] = new int[2] { 10, 20 };
            jaggedArray[1] = new int[3] { 30, 40, 50 };
            jaggedArray[2] = new int[4] { 60, 70, 80, 90 };

            // # Getlength metodu ile dizinin uzunluğunu bulunur

            // 3 boyutlu dizi

            // öğrenci no, sınav notu , yaşı
            
            int[,,] ogrenci = { 
                {{1001}, {60},{12} }, 
                {{1003}, {100},{15} }, 
                {{1005}, {80},{13} } 
            };

            // örnek düzensiz dizilere

            int[][] ogrenciler = new int[3][]; // 3 elemanlı bir dizi tanımladık // ilk diziler şube // 2. diziler öğrenci
            ogrenciler[0] = new int[2] { 1001, 1002 }; // 2 öğrenci var bu ilk şubede
            ogrenciler[1] = new int[3] { 1003, 1004, 1005 }; // 3 öğrenci var bu ikinci şubede
            ogrenciler[2] = new int[4] { 1006, 1007, 1008, 1009 }; // 4 öğrenci var bu üçüncü şubede

            // Array listeler 
            // eleman sayısı belli olmayan, değişebilir boyutlu dizilerdir.
            // System.Collections namespace altında bulunur.

            ArrayList liste = new ArrayList(); // boş bir arraylist tanımladık
            liste.Add(10); // 0. indexe 10 ekledik
            liste.Add(20); // 1. indexe 20 ekledik
            liste.Add("Ahmet"); // 2. indexe string ekledik
            liste.Remove(20); // 20 elemanını sildik

            foreach(var eleman in liste)
            {
                Console.WriteLine(eleman);
            }

            // örnek

            ArrayList ogrNot = new ArrayList();
            ogrNot.Add(60);
            ogrNot.Add(100);
            ogrNot.Add(90);
            ogrNot.Add(80);

            foreach (int not in ogrNot)
            {
                Console.WriteLine(not);
            }


            // ArrayList sınıfından metodlar
            // Add() : eleman ekler
            // Remove() : eleman siler
            // Count : eleman sayısını verir
            // Clear() : tüm elemanları siler
            // Sort() : elemanları sıralar
            // Reverse() : elemanları ters çevirir
            // AddRange() : bir arraylisti diğerine ekler
            // BinarySearch() : elemanı arar
            // CopyTo() : arraylisti diziye kopyalar

            // örnekler

            int[] sayilar = { 10, 30, 60, 80, 90, 100 };
            string[] isimler = new string[4];
            isimler[0] = "Ali";
            isimler[1] = "Veli";
            isimler[2] = "Ömer";
            isimler[3] = "Ayşe";

            //normal dizilerde önce Array classı çağırılır. sonra metodlar kullanılır.
            Array.Sort(sayilar); // sıralama
            Array.IndexOf(sayilar, 60); // 60 elemanının indexini verir
            Array.Clear(sayilar, 0, 3); // 0'dan 3'e kadar olan elemanları siler






        }


    }
}
