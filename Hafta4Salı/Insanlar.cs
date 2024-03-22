using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Salı
{
    internal class Insanlar
    {
        public virtual void Selamlama() // virtual metotlar : override edilebilir. ana classta bulunan metodu subclassda içeriği değiştirilerek kullanılabilir.
        {
            Console.WriteLine("Merhaba");
        }
    }
}
