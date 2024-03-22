using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4SalıRecursiveMetodlar
{
    internal class Program
    {
        public void RecursiveMetot(int sayi)
        {
            sayi += 1;

            if (sayi < 15)
            {
                RecursiveMetot(sayi);
            }
            
        }

        static void Main(string[] args)
        {
            // Recursive Metodlar
            // Kendi kendini çağıran metotlardır.

            Program program = new Program();
            program.RecursiveMetot(3);
        }
    }
}
