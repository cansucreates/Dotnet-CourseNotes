using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Salı
{
    internal class Turk : Insanlar
    {
        public override void Selamlama() // override edilmiş metot
        {
            base.Selamlama(); // ana classtaki virtual metotu olduğu gibi kullanmak için
        }
    }
}
