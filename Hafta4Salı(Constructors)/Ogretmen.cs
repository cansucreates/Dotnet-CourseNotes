using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Salı_Constructors_
{
    internal class Ogretmen
    {
        // yıkıcı metot
         ~Ogretmen() // nesne üretilmediğinde çalışır
        {
            Console.WriteLine("Öğretmen classından nesne üretilmedi");
            
        }
    }
}
