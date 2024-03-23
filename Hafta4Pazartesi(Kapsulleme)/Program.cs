using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Pazartesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kapsulleme: Classta tanımlanan private fieldlara erişmek için public propertyler kullanılır.
            // iki anahtar kelime: Get ve Set
            // Get: fieldın değerini döndürür.
            // Set: fielda değer atar.

            Musteriler m1 = new Musteriler();

            // m1._ad = "Ali"; // Erişilemez. Çünkü private.
            m1.Ad = "Ali"; // Propertylerle fieldlara erişim.
            m1.Soyad = "Veli"; // Propertylerle fieldlara erişim.
            m1.Yas = 25; // Propertylerle fieldlara erişim.

            Console.WriteLine("Öğrenci Adı:");
            Ogrenciler o1 = new Ogrenciler();
            o1.ad = Console.ReadLine();

            Console.WriteLine("Öğrenci TC:"); // Set bloğu çalışıyor.
            o1.Tc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Öğrenci TC: " + o1.Tc); // Get bloğu çalışıyor.

            Console.WriteLine("Öğrenci Öğrenci No:"); // Set bloğu çalışıyor.
            o1.OgrNo = Console.ReadLine();
            Console.WriteLine("Öğrenci Öğrenci No: " + o1.OgrNo); // Get bloğu çalışıyor.

            Console.WriteLine("Öğrenci Not:"); // Set bloğu çalışıyor.
            o1.Not = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Öğrenci Not: " + o1.Not); // Get bloğu çalışıyor.
        
        }
    }
}
