using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucuncuHafta
{
    internal class Program
    {
        // geriye değer döndürmeyen(void) ve parametre almayan metot
        // main dışında tanımlanan metotlar main metodu içerisinde çağrılmalıdır.
        public static void Topla()
        {
            int x = 25;
            int y = 30;
            int toplam = x + y;
            Console.WriteLine("Toplam: " + toplam);
        }

        // geriye değer döndürmeyen ve parametre alan metot
        public static void Topla2(int x, int y)
        {
            int toplam = x + y;
            Console.WriteLine("Toplam: " + toplam);
        }

        // Örnek:
        public static void Hesapla(string ad, int d_yili)
        {
            int yas = 2024 - d_yili;
            Console.WriteLine(ad + " adlı kişinin yaşı: " + yas);
        }

        // Örnek metod:
        public static void Hesapla2(char cinsiyet, string ad, int d_yili)
        {
            int yas = 2024 - d_yili;
            if(cinsiyet == 'K')
            {
                Console.WriteLine(ad + " adlı bayan kişinin yaşı: " + yas);
            }
            else
            {
                Console.WriteLine(ad + " adlı erkek kişinin yaşı: " + yas);
            }
        }

        // geriye değer döndüren parametresiz metot
        public static int Topla3()
        {
            int x = 25;
            int y = 30;
            return x + y;
        }

        // geriye değer döndüren ve parametre alan metot
        public static int Topla4(int x, int y)
        {
            return x + y;
        }

        //örnek **********************************************: 

        // ana ekrandan ürün seçimi yapılsın 1-giyim 2-ayakkabı, 3-aksesuar ve fiyat, adeti, kdv oranı girilsin
        // zam metodu oluştur, girilen oran kadar zam uygulayıp fiyatı döndürsün
        // indirim metoduy oluştur girilen fiyat 1000 den büyükse girilen oran kadar indirim uygulayıp fiyatı döndürsün
        // azsa 50 tl indirim. 
        // giyim ve ayakkabı da zamn aksesuarda indirim metodu çalışsın.

        public static double Zam(double fiyat, int adet, float oran)
        {
            double topFiyat = fiyat * adet;
            topFiyat += topFiyat * oran / 100;
            return topFiyat;
        }

        public static double Indirim(double fiyat, int adet)
        {
            Console.WriteLine("İndirimin oranını giriniz: ");
            float oran = Convert.ToSingle(Console.ReadLine());
            if (fiyat > 1000)
            {
                double topFiyat = fiyat * adet;
                topFiyat -= topFiyat * oran / 100;
                return topFiyat;
            }
            else
            {
                double topFiyat = fiyat * adet;
                topFiyat -= 50;
                return topFiyat;
            }
         }



        static void Main(string[] args)
        {
            // 11.03.2024
            // METODLAR
            // ErişimBelirleyici(Access Modifiers) GeriDönüşTipi MetotAdı(ParametreListesi)
            // private = > Sadece tanımlandığı sınıf içerisinde erişilebilir. (Default)
            // public => Her yerden erişilebilir.
            // protected => Sadece tanımlandığı sınıf ve bu sınıftan türetilen sınıflardan erişilebilir.
            // internal => Sadece tanımlandığı proje içerisinde erişilebilir.
            // protected internal => Sadece tanımlandığı proje içerisinde ve bu sınıftan türetilen sınıflardan erişilebilir.

            // 1. Geriye değer dönmeyen/dönen ve parametre almayan/alan metot
            // 2. Geriye değer dönen/dönmeyen ve parametre almayan/alan metot

            // Örnek
            // geriye değer döndürmeyen(void) ve parametre almayan metot
            // static => Class'ın methodlarına direk ulaşmak istiyorsak method static yapılır.
            // Üstte ayrı yazılan metodlar çağırıldı.
            // =>> Topla();
            // =>> Topla2(10, 20);
            // ==> Hesapla("Ahmet", 1990);
            // ==> Hesapla2('E', "Ahmet", 1990);
            // int toplam = Topla3();
            // int toplam2 = Topla4(10, 20);

            // örnek ***********************************************:
            Console.WriteLine("Ürün seçiniz: 1-Giyim 2-Ayakkabı 3-Aksesuar");
            int secim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fiyatı giriniz: ");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Adeti giriniz: ");
            int adet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("KDV oranını giriniz: ");
            float kdv = Convert.ToSingle(Console.ReadLine());

            if (secim == 1 || secim == 2)
            {
                Console.WriteLine("Zam oranını giriniz: ");
                float oran = Convert.ToSingle(Console.ReadLine());
                double toplamFiyat = Zam(fiyat, adet, oran);
                Console.WriteLine("Toplam fiyat: " + toplamFiyat);
            }
            else if (secim == 3)
            {
                double toplamFiyat = Indirim(fiyat, adet);
                Console.WriteLine("Toplam fiyat: " + toplamFiyat);
            }
            else
            {
                Console.WriteLine("Hatalı seçim yaptınız.");
            }
        }
    }
}
