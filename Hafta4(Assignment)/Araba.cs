using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Assignment_
{
    internal class Araba
    {
        private string arabaNo;
        public string arabaAdi; // public olarak tanımlandı. get ve set metotları gerekli değil.
        private int motorGucu; 
        private string vitesDurumu;
        private float fiyat;
        private float otv;


        // Araba numarasi 6 haneli olmalidir.
        public string ArabaNo
        {
            get
            {
                return arabaNo;
            }
            set
            {
                if(value.Length == 6)
                {
                       arabaNo = value;
                }
                else
                {
                    Console.WriteLine("Araba numarasi 6 haneli olmalidir.");
                    Console.WriteLine("Araba numarasini yeniden giriniz: ");
                    arabaNo = Console.ReadLine();
                }
            }
        }


        // Arabanin motor gücü 1000 ile 2000 arasinda olmalidir.
        public int MotorGucu
        {
            get
            {
                return motorGucu;
            }
            set
            {
                if(value > 1000 && value < 2000)
                {
                    motorGucu = value;
                }
                else
                {
                    Console.WriteLine("Motor gucu 1000 ile 2000 arasında olmalı.");
                    Console.WriteLine("Motor gucunu yeniden giriniz:");
                    motorGucu = Convert.ToInt32(Console.ReadLine());
                }
            }
        }


        // Arabanin vites durumu manuel ya da otomatik olmalidir.
        public string VitesDurumu
        {
            get
            {
                return vitesDurumu;
            }
            set
            {
                if(value == "manuel" || value == "otomatik")
                {
                    vitesDurumu = value;
                }
                else
                {
                    Console.WriteLine("Vites durumu manuel ya da otomatik olmalidir.");
                    Console.WriteLine("Vites durumunu yeniden giriniz:");
                    vitesDurumu = Console.ReadLine();
                }
            }
        }

        // Arabanin fiyati 30000 100000 arasinda olmalidir.
        public float Fiyat
        {
            get
            {
                return fiyat;
            }
            set
            {
                if(value > 30000 && value < 100000)
                {
                    fiyat = value;
                }
                else
                {
                    Console.WriteLine("Fiyat 30000 ile 100000 arasinda olmalidir.");
                    Console.WriteLine("Fiyati yeniden giriniz:");
                    fiyat = Convert.ToSingle(Console.ReadLine());
                }
            }
        }

        // Arabanin otv orani 10 ile 60 arasinda olmalidir.
        public float Otv
        {
            get
            {
                return otv;
            }
            set
            {
                if(value > 10 && value < 60)
                {
                    otv = value;
                }
                else
                {
                    Console.WriteLine("OTV 10 ile 60 arasinda olmalidir.");
                    Console.WriteLine("OTVyi yeniden giriniz:");
                    otv = Convert.ToSingle(Console.ReadLine());
                }
            }
        }

    }
}
