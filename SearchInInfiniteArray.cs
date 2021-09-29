using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumleri
{
    class Program
    {
        
        private static int binarySearch_Uyarlama(int[] dizi, int aranan)
        {
            int pointer1 = 0;
            int pointer2 = 1;

            while (aranan > dizi[pointer2])
            {
                pointer1 = pointer2;
                pointer2 *= 2;
            }

            while (pointer1 <= pointer2)
            {
                int mid = (pointer1 + pointer2) / 2;

                if (aranan == dizi[mid])
                {
                    return mid;
                }
                else if (aranan < dizi[mid])
                {
                    pointer2 = mid - 1;
                }
                else
                {
                    pointer1 = mid + 1;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] dizi = { 5,7,9,10,12,15,16 };
            int aranan = 15;

            int Index = binarySearch_Uyarlama(dizi,aranan);
   
            Console.WriteLine(aranan + " degerinin indexi:" + Index);

            Console.ReadLine();
        }
    }
}
