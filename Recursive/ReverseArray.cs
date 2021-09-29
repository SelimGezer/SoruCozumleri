using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionOrnekler
{
    class Program
    {
        static char[] diziReverse(char[] array, int p1, int p2)
        {
            if (p1 >= p2)//Temel durum. p1>=p2 olduğunda artık swap işlemini sağlayacak eleman kalmamış demektir.
            {
                return array;
            }

            array = diziReverse(array, p1 + 1, p2 - 1);//Özyinelemeli kısım. p1 ve p2 hareket ettiriliyor.

            //Swap işlemi
            char gecici = array[p2];
            array[p2] = array[p1];
            array[p1] = gecici;

            return array;
        }

        static void Main(string[] args)
        {
            string ifade = "selimgezer";
            char[] array = ifade.ToArray();
            char[] reverse = diziReverse(array, 0, array.Length - 1);

            for (int i = 0; i < reverse.Length; i++)
            {
                Console.Write(reverse[i]);
            }
            Console.ReadKey();
        }
    }
}
