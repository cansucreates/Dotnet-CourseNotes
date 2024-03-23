using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3Ders3OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CLASS
            // class: nesne üretmek için kullanılan bir yapıdır.
            Insanlar insan = new Insanlar();
            insan.adsoyad = "Ali Veli";
            Insanlar insan2 = new Insanlar();
            insan2.adsoyad = "Ayşe Fatma";

            Okul okul = new Okul();
            
            Ogrenciler ogrenciler = new Ogrenciler();

            Console.WriteLine("Öğrencinin adını giriniz: ");
            ogrenciler.adSoyad = Console.ReadLine();
            Console.WriteLine("Tc giriniz: ");
            ogrenciler.tc = Console.ReadLine();
            Console.WriteLine("Yaş giriniz: ");
            ogrenciler.yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sınıf giriniz: ");
            ogrenciler.sinif = Console.ReadLine();

            ogrenciler.Burs(ogrenciler.yas);


            Ogretmenler ogretmen = new Ogretmenler();
            Ogretmenler ogretmen2 = new Ogretmenler();

            Console.WriteLine("Birinci öğretmenin adını giriniz: ");
            ogretmen.adSoyad = Console.ReadLine();
            Console.WriteLine("Birinci öğretmenin branşını giriniz: ");
            ogretmen.brans = Console.ReadLine();
            Console.WriteLine("Birinci öğretmenin maaşını giriniz: ");
            ogretmen.maas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birinci öğretmenin tc'sini giriniz: ");
            ogretmen.tc = Console.ReadLine();

            Console.WriteLine("İkinci öğretmenin adını giriniz: ");
            ogretmen2.adSoyad = Console.ReadLine();
            Console.WriteLine("İkinci öğretmenin branşını giriniz: ");
            ogretmen2.brans = Console.ReadLine();
            Console.WriteLine("İkinci öğretmenin maaşını giriniz: ");
            ogretmen2.maas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci öğretmenin tc'sini giriniz: ");
            ogretmen2.tc = Console.ReadLine();

            ogretmen.Maas(ogretmen.maas);
            ogretmen2.Maas(ogretmen2.maas);

            // static kavramı: nesne üretmeden içindeki özelliklere ve metotlara ulaşabilmemizi sağlar.
            // static metotlara nesne üzerinden ulaşamayız. direk class üzerinden ulaşabiliriz.
            // classı static yaparsak içindeki tüm özellikler ve metotlar static olur. ve classtan bir nesne oluşturulmaması için kullanılır.



        }
    }
}
