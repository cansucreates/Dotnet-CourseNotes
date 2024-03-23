using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3Ders3OOP
{
    internal class Ogretmenler
    {
        public string tc;
        public string adSoyad;
        public double maas;
        public string brans;

        public void Maas(double maas)
        {
            if (maas < 30000)
            {
                Console.WriteLine("Ek ders alabilirsiniz.");
            }
        }
        
    }
}
