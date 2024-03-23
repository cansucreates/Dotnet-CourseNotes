using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Salı
{
    abstract internal class Ayakkabi // Main class. Sadece ana class olarak kullanılabilir. Soyutlanmış. AnA classtan nesne üretilemez!!! Sadece childs.
        // abstract classlar içerisinde abstract methodlar bulunabilir.
    {
        public string marka;

        // normal method
        public void Merhaba()
        {
            Console.WriteLine("Merhaba");
        }

        // abstract method. ana class abstract olmalı. 
        public abstract void Selamla(); // gövdesi olmayan method. Bu method subclasslarda override edilerek her class için farklı bir gövde verilebilir.
     


    }
}
