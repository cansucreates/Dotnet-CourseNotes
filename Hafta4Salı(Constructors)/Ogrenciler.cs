using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Salı_Constructors_
{
    internal class Ogrenciler
    {
        public int ogrSayisi;
        public Ogrenciler()
        {
            Console.WriteLine("Öğrenci sınıfı yapıcı metodu çalıştı");
            ogrSayisi = 0; // 
        }

        // yıkıcı metot

        ~Ogrenciler()
        {
            Console.WriteLine("Öğrenci classından nesne üretilmedi");
        }
    }
}
