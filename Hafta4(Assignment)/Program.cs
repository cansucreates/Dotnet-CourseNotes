using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4_Assignment_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            Console.WriteLine("Araba numarası: ");
            araba.ArabaNo = Console.ReadLine();
            Console.WriteLine("Araba adı: ");
            araba.arabaAdi = Console.ReadLine();
            Console.WriteLine("Motor gücü: ");
            araba.MotorGucu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vites durumu: ");
            araba.VitesDurumu = Console.ReadLine();
            Console.WriteLine("Fiyat: ");
            araba.Fiyat = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Otv: ");
            araba.Otv = Convert.ToSingle(Console.ReadLine());

            float OtvFiyati = Islemler.OtvHesapla(araba.Fiyat, araba.Otv);
            float KdvFiyati = Islemler.KdvHesapla(OtvFiyati); // Otv fiyatı alınarak kdv fiyatı hesaplanır.

            Console.WriteLine("Otv fiyatı: " + OtvFiyati);
            Console.WriteLine("Kdv fiyatı: " + KdvFiyati);

            // Kasko ister mi?
            Islemler islemler = new Islemler();
            islemler.Kasko();


            Console.ReadLine();



            



            




          
        }
    }
}
