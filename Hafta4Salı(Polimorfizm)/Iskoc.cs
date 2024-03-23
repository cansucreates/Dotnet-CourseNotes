using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Salı
{
    internal class Iskoc : Insanlar
    {
        public override void Selamlama() // override edilmiş metot
        {
            Console.WriteLine("Hollo"); // değiştirilmiş metot
        }
    }
}
