using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3Ders3OOP
{
    internal class Ogrenciler
    {
        public string tc;
        public string adSoyad;
        public string sinif;
        public int yas;


        public void Burs(int yas)
        {
            if (yas > 12)
            {
                Console.WriteLine("Burs alabilir");
            }
        }
    }
}
