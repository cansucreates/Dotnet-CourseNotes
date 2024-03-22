using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta4Salı_Poli_Ornek_
{
    internal class Ayakkabilar // Ana Class
    {
        public int fiyat;
        public string marka;
        public string model;

        public virtual int Zam(int fiyat, string marka)
        {
            if (marka == "Adidas" || marka == "Puma")
            {
                fiyat += fiyat * 20 / 100;
            }
            else
            {
                fiyat += fiyat * 15 / 100;
            }
            return fiyat;
        }

        public virtual int Indirim(int fiyat, string marka)
        {
            if(marka == "Nike")
            {
                fiyat -= fiyat * 20 / 100;
            }
            else
            {
                fiyat -= fiyat * 10 / 100;
            }
            return fiyat;
        }

        public virtual void Hediye(string marka, string model)
        {
            if (marka == "Nike" && model=="Yürüyüş")
            {
                Console.WriteLine("Bu ayakkabıya bir tane çorap hediye");
            }
        }

        public void BilgiAl()
        {
            Console.WriteLine("Fiyat giriniz: ");
            fiyat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Marka giriniz: ");
            marka = Console.ReadLine();

            Console.WriteLine("Model giriniz: ");
            model = Console.ReadLine();

            Console.WriteLine("Fiyat: " + fiyat + " Marka: " + marka + " Model: " + model);
        }
    }
}

