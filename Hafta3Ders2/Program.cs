using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta3Ders2
{
    internal class Program
    {

        public static float Fis()
        {
            Console.WriteLine("Fiyat giriniz: ");
            float fiyat = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Adet giriniz: ");
            int adet = Convert.ToInt32(Console.ReadLine());
            
            fiyat *= adet;
            fiyat += fiyat * 0.18f;
            return fiyat;
        }

        public static void Hediye(float fiyat)
        {
            if (fiyat > 1000 && fiyat < 2000)
            {
                Console.WriteLine("50 TL hediye çeki kazandınız.");
            }
            else if (fiyat > 2000)
            {
                Console.WriteLine("100 TL hediye çeki kazandınız.");
            }
            else
            {
                Console.WriteLine("Hediye çeki kazanamadınız.");
            }
        }

        static void Main(string[] args)
        {
            // ana ekranda seçim yapılsın
            //1-Mutfak Eşyaları
              //-a- pişirme eşyaları
              //-b- sofra eşyaları
            //
            //2-Banyo Eşyaları
              //-a- temizlik eşyaları
              //-b- kişisel bakım eşyaları

            // fiş adında bir method olsun. bu method fiyat ve adet isteyip yüzde 18 kdv ile tutar hesaplasın.
            // hediye adında bir method. fiş metodundan çıkan sonuca göre
                // 1000 tl ve 2000 tl arasında ise 50 tl hediye çeki
                // 2000 tl ise 100 tl hediye çeki

            Console.WriteLine("Bir seçim yapınız: \n 1-Mutfak Eşyaları \n 2-Banyo Eşyaları");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    Console.WriteLine("Mutfak Eşyaları için seçim yapınız: \n a- pişirme eşyaları \n b- sofra eşyaları");
                    char secim2 = Convert.ToChar(Console.ReadLine());
                    switch (secim2)
                    {
                        case 'a':
                            Console.WriteLine("Pişirme eşyaları seçildi.");
                            float fiyat = Fis();
                            Hediye(fiyat);
                            break;
                        case 'b':
                            Console.WriteLine("Sofra eşyaları seçildi.");
                            Hediye(Fis());
                            break;
                        default:
                            Console.WriteLine("Hatalı seçim yaptınız.");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Banyo Eşyalarını seçtiniz");
                    break;
                default: 
                    Console.WriteLine("Hatalı seçim yaptınız.");
                    break;

            }

        }
    }
}
