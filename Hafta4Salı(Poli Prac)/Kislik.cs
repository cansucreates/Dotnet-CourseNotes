using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Salı_Poli_Ornek_
{
    internal class Kislik : Ayakkabilar
    {
        public string ozellik; 
        public override int Indirim(int fiyat, string marka) 
        { 
            return base.Indirim(fiyat, marka); 
        }
        public override void Hediye(string marka, string model) 
        { 
            base.Hediye(marka, model); 
            Console.WriteLine("temizleme suyu hediyeli"); 
        }
    }
}
