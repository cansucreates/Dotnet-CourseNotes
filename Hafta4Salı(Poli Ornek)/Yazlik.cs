using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Salı_Poli_Ornek_
{
    internal class Yazlik : Ayakkabilar
    {
       public override int Zam(int fiyat, string marka) 
        { 
            return base.Zam(fiyat, marka); 
        } 
        
        public override int Indirim(int fiyat, string marka) 
        { 
            if (marka=="bambi")
            { 
                fiyat -= fiyat * 50 / 100; 
            } 

          else 
            {
                fiyat -= fiyat * 20 / 100;
            } 
            return fiyat; 
        } 
        public override void Hediye(string marka, string model) 
        { 
            base.Hediye(marka, model);
        }
    }
}
