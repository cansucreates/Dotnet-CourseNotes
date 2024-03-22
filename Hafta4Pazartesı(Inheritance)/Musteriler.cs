using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Pazartesı_Inheritance_
{
    internal class Musteriler
    {
        // ortak fieldlar ana classa(base, super) yazılır.
        public int musteriNo;
        public string musteriAd;
        public string musteriTel;
        private double bakiye;

        // Bakiye fieldı için property yazılır.
        public double Bakiye // kapsulleme
        {
            get { return bakiye; }
            set 
            {
                if (value < 1000)
                {
                    bakiye = value;
                }
                else
                {
                    bakiye = value + 100;
                }
            }
        }

        // Bakiye fieldı için method yazıldı.
        public void BakiyeMesaji(double bakiyedekiDeger)
        {
            if (bakiyedekiDeger == 0)
            {
                Console.WriteLine("Borç bulunmamaktadır.");
            }
            else
            {
                Console.WriteLine("En kısa sürede borcu kapatın.");
            }
 
        }
    }
}
