using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Cars_HazirMetodlar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hazır metodlar ve Tarih/Saat işlemleri
            // String sınıfından çağırılan metodlar: Compare, Copy, Concat, Format, IsNullOrEmpty
            // String ifade ile birlikte çağrılan metodlar: ToLower, ToUpper, ComparTo, IndexOf, LastIndexOf, Insert...
            string metin1 = "Cansu AY";
            string metin2 = "cansu moon";

            int sonuc = String.Compare(metin1, metin2); // int döndürür. 0: Eşit, -1: İlk metin küçük, 1: İlk metin büyük

            string metin3 = String.Copy(metin1); // metin1'in kopyasını oluşturur

            // Concat metodu ile iki metni birleştirme.
            Console.WriteLine(String.Concat(metin1, " ", metin2));

            // Format: Metin içindeki {0}, {1} gibi yer tutuculara değer atama
            Console.WriteLine(String.Format("{0, 11}", metin2)); // 11 karakterlik alan ayırır ve metin2'yi sağa yaslar

            int x = 15;
            Console.WriteLine(String.Format(" {0: 0000} ", x)); // 4 karakterlik alan ayırır ve x'i 4 karakter olarak yazar // 0015 // öne sıfır ekler(2) 
            // kendisi de 2 karakter olduğu için toplamda 4 karakter olur.
            Console.WriteLine(String.Format("{0, 11", x)); // 11 karakterlik alan ayırır ve x'i sağa yaslar
            Console.WriteLine(String.Format("{0, 11: 0000", x)); // 11 karakterlik alan ayırır ve x'i sağa yaslar ve öne 2 sıfır ekler

            // IsNullOrEmpty: Metin boş mu ya da null mu kontrolü
            
            // string ifade ile birlikte çağrılan metodlar
            metin1.ToLower (); // metin1'i küçük harfe çevirir
            metin2.ToUpper(); // metin2'yi büyük harfe çevirir
            // metin2.Length; // metin2'nin karakter sayısını verir
            metin2.CompareTo(metin1); // metin2 ile metin1'i karşılaştırır. Compare metoduna benzer. 1, 0, -1 döndürür.
            // copyTo örnek:
            char[] metin4 = new char[10];
            metin1.CopyTo(0, metin4, 0, 5); // metin1'in 0. karakterinden itibaren 5 karakterini metin4'e kopyalar.

            // IndexOf: Metin içinde aranan karakterin ilk bulunduğu indeksi döndürür.
            // LastIndexOf: Metin içinde aranan karakterin son bulunduğu indeksi döndürür.
            // Insert: Metin içine yeni bir metin ekler.
            // Remove: Metin içinden belirtilen indeksten itibaren belirtilen sayıda karakteri siler.

            // Math sınıfı: Abs, Ceiling, Floor, Max, Min, Pow, Round, Sqrt
            // Abs: Mutlak değer
            // Ceiling: Üst sayıya yuvarlar
            // Floor: Alt sayıya yuvarlar
            // Max: İki sayıdan büyük olanı döndürür
            // Min: İki sayıdan küçük olanı döndürür
            // Pow: Bir sayının üssünü alır
            // Round: Sayıyı yuvarlar
            // Sqrt: Karekök alır


            // Tarih/Saat işlemleri

            DateTime tarih = DateTime.Now; // Şu anki tarihi ve saati alır
            Console.WriteLine(tarih);
            DateTime dogumTarihi = new DateTime(1990, 1, 1); // Yıl, ay, gün
            Console.WriteLine(dogumTarihi);
            dogumTarihi = dogumTarihi.AddYears(30); // 30 yıl ekler
            Console.WriteLine(dogumTarihi);
            DateTime today = DateTime.Today; // Bugünün tarihini alır
            Console.WriteLine(today);
            DateTime tomorrow = today.AddDays(1); // Bugünden 1 gün sonrasını alır





            





            
            
             


             
        }
    }
}
