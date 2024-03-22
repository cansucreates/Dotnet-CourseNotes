using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Salı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polimorfizm
            // aynı isimde farklı işlevde metotlar kullanılabilir.
            // virtual metotlar : override edilebilir. ana classta bulunan metodu subclassda içeriği değiştirilerek kullanılabilir.
            // virtual metotlar subclassta olduğu gibi de kullanılabilir.
            // virtual metotları override etmeden kullanılmaz.
            // ana classtan instance alınabilir. subclasslardan instance alınabilir.

            // abstract metotlar : içeriği olmayan metotlardır. subclasslarda içeriği doldurulur.
            // ana classtan instance alınamaz. subclasslardan instance alınabilir.

            Turk turk = new Turk();
            turk.Selamlama(); // Merhaba

            Ingiliz ingiliz = new Ingiliz();
            ingiliz.Selamlama(); // Hello

            Iskoc iskoc = new Iskoc();
            iskoc.Selamlama(); // Hollo
        }
    }
}
