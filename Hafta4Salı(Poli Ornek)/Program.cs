using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Salı_Poli_Ornek_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Kışlık \n 2- Yazlık ");
            byte secim = Convert.ToByte(Console.ReadLine());
            if (secim == 1)
            {
                Kislik kislik = new Kislik();
                kislik.ozellik = Console.ReadLine();
                kislik.BilgiAl();
                Console.WriteLine(kislik.ozellik);
                int sonuc = kislik.Indirim(kislik.fiyat, kislik.marka);
                Console.WriteLine("İndirimli Fiyat: " + sonuc);
                kislik.Hediye(kislik.marka, kislik.model);
            }
            else
            {
                Yazlik yazlik = new Yazlik();
                yazlik.BilgiAl();
                Console.WriteLine("İndirimli Fiyat: " + yazlik.Indirim(yazlik.fiyat, yazlik.marka));
                yazlik.Zam(yazlik.fiyat, yazlik.marka);
                yazlik.Hediye(yazlik.marka, yazlik.model);
            }
        }
    }
}
