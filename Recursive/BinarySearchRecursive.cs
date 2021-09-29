using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionOrnekler
{
    class Program
    {
        static int binarSearchRecursive(int[] array, int p1, int p2, int aranan)
        {
            if (p1 <= p2)//pointerlar birbirine eşit olduktan sonra artık taranacak elemanın kalmadığı anlamına gelir.
            {
                int mid = (p1 + p2) / 2;

                if (aranan == array[mid])
                {
                    return mid;
                }
                else if (aranan > array[mid])
                {
                    return binarSearchRecursive(array, mid + 1, p2, aranan);//Özyineleme p1'in yeri mid+1 'e çekilir.
                }
                else
                {
                    return binarSearchRecursive(array, p1, mid - 1, aranan);//Özyineleme p2'nin yeri mid-1'e çekilir.
                }
            }

            return -1;//taramada aranan eleman bulunamamıştır
        }


        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7 };
            int aranan = 7;
            int index=binarSearchRecursive(dizi , 0, dizi.Length-1, aranan);
            Console.WriteLine(aranan + " değerinin indisi:" + index);
            Console.ReadKey();
        }
    }
}
