using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Pazartesı_Inheritance_
{
    internal class Bireysel:Musteriler // Bireysel sınıfı Musteriler sınıfından miras alır.
    {
        // Bireysel sınıfına özgü fieldlar yazılır.
        public int puan;
        public void PuanDurumu(int puan)
        {
            if (puan > 1000)
            {
                Console.WriteLine("Müşteriye hediye verilsin");
            }
        }
    }
}
