using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumleri
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] dizi = new int[] { 1, 2, 3, 4, 5 };
            int k = 3;

            //Brute force yaklaşım
            int toplam = 0, geciciToplam = 0;

            for (int i = 0; i <= dizi.Length - k; i++)
            {
                geciciToplam = 0;

                for (int j = i; j < i + k; j++)
                {
                    geciciToplam += dizi[j];
                }
                Console.WriteLine(geciciToplam + " ");

                if (geciciToplam > toplam)
                {
                    toplam = geciciToplam;
                }
            }
            Console.WriteLine("Cevap Brute Force:" + toplam);

            Console.WriteLine("-----------");

            toplam = 0;
            geciciToplam = 0;

            //Sliding window yaklaşımı
            for (int i = 0; i < k; i++)//ilk k tane yi topluyoruz.
            {
                toplam += dizi[i];
            }
            Console.WriteLine(toplam + " ");

            geciciToplam = toplam;

            for (int i = 1; i <= dizi.Length - k; i++)//1'den başladığına dikkat edin.
            {
                geciciToplam = geciciToplam + dizi[i + k - 1] - dizi[i - 1];
                Console.WriteLine(geciciToplam + " ");

                if (geciciToplam > toplam)
                {
                    toplam = geciciToplam;
                }
            }
            Console.WriteLine("Cevap Sliding Window:" + toplam);

            Console.ReadLine();
        }
    }
}
