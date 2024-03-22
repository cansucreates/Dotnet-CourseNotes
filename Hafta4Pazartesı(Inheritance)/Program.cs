using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Pazartesı_Inheritance_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Kurumsal \n 2- Bireysel");
            byte secim = Convert.ToByte(Console.ReadLine());
            if (secim == 1)
            {
                Kurumsal kurumsal = new Kurumsal();
                Console.WriteLine("Müşteri adı: ");
                kurumsal.musteriAd = Console.ReadLine(); // miras alınan sınıftaki fieldlara erişim
                Console.WriteLine("Müşteri no: ");
                kurumsal.musteriNo = Convert.ToInt32(Console.ReadLine()); // miras alınan sınıftaki fieldlara erişim
                Console.WriteLine("Müşteri telefon: ");
                kurumsal.musteriTel = Console.ReadLine(); // miras alınan sınıftaki fieldlara erişim
                Console.WriteLine("Bakiye: "); 
                kurumsal.Bakiye = Convert.ToDouble(Console.ReadLine()); // property set edildi.
                Console.WriteLine("Çalışma yılı: ");
                kurumsal.calismaYili = Convert.ToInt32(Console.ReadLine()); // kendi fieldına erişim

                kurumsal.BakiyeMesaji(kurumsal.Bakiye); // miras alınan sınıftaki methoda erişim
            }

            else if (secim == 2)
            {
                Bireysel bireysel = new Bireysel();
                Console.WriteLine("Müşteri adı: ");
                bireysel.musteriAd = Console.ReadLine(); // miras alınan sınıftaki fieldlara erişim
                Console.WriteLine("Müşteri no: ");
                bireysel.musteriNo = Convert.ToInt32(Console.ReadLine()); // miras alınan sınıftaki fieldlara erişim
                Console.WriteLine("Müşteri telefon: ");
                bireysel.musteriTel = Console.ReadLine(); // miras alınan sınıftaki fieldlara erişim
                Console.WriteLine("Bakiye: ");
                bireysel.Bakiye = Convert.ToDouble(Console.ReadLine()); // property set edildi.
                Console.WriteLine("Puan: ");
                bireysel.puan = Convert.ToInt32(Console.ReadLine()); // kendi fieldına erişim

                bireysel.PuanDurumu(bireysel.puan); // kendi methoduna erişim
                bireysel.BakiyeMesaji(bireysel.Bakiye); // miras alınan sınıftaki methoda erişim
            }

            AltKurumsal altKurumsal = new AltKurumsal();
            Console.WriteLine("Müşteri adı: ");
            altKurumsal.musteriAd = "Alt kurumsal"; // miras alınan sınıftaki fieldlara erişim altKurumsal < Kurumsal < Musteriler
        }
    }
}
