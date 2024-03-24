using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Pazartesi
{
    internal class Ogrenciler
    {
        int tc;
        public string ad;
        string ogrNo;
        int not;
        public int bursMiktari;

        // Propertyler
        // Tc property'si
        public int Tc
        {
            get
            {
                return tc;
            }
            set
            {
                if (value%2==0 && value.ToString().Length == 8)
                {
                    tc = value;
                }
                else
                {
                    Console.WriteLine("TC 11 haneli olmalıdır.");
                    Console.WriteLine("TCyi yeniden giriniz: ");
                    tc = Convert.ToInt32(Console.ReadLine()); 
                }
            }
        }

        // OgrNo property'si
        public string OgrNo
        {
            get
            {
                return ogrNo;
            }
            set
            {
                if (value.Length == 6)
                {
                    ogrNo = value;
                }
                else
                {
                    ogrNo = "000000"; // Default değer
                }
            }
        }

        // Not property'si
        public int Not
        {
            get
            {
                return not;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    not = value;
                }
                else
                {
                    not = 0; // Default değer
                }
            }
        }
    }
}
