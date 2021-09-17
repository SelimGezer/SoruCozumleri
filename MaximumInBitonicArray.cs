using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumleri
{
    class Program
    {
        public static int maxElement(int[] dizi)
        {
            int n = dizi.Length;

            int pointer1 = 0;
            int pointer2 = n - 1;

            while (pointer1 <= pointer2)
            {
                int mid = (pointer1 + pointer2) / 2;
            
                if(dizi[mid] > dizi[mid-1] && dizi[mid] > dizi[mid + 1])
                {
                    return dizi[mid];
                }
                else if(dizi[mid] < dizi[mid - 1])
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
            int[] dizi = { 2,4,6,8,10,15,3,1 };

            int max = maxElement(dizi);

            Console.Write("Max:" + max);
      
            Console.ReadLine();
        }
    }
}
