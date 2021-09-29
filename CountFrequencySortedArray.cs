using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumleri
{
    class Program
    {

        //Aranan değerin dizide ilk karşılaştığımız indisini döndürür.
        private static int binarySearch_ilkiBul(int[] dizi, int aranan)
        {
            int pointer1 = 0;
            int pointer2 = dizi.Length - 1;

            int ilkPozisyon = -1;

            while (pointer1 <= pointer2)
            {
                int mid = (pointer1 + pointer2) / 2;

                if (aranan == dizi[mid])
                {
                    ilkPozisyon = mid;

                    pointer2 = mid - 1;
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

            return ilkPozisyon;
        }

        //Aranan değerin dizide son karşılaştığımız indisini döndürür.
        private static int binarySearch_sonuBul(int[] dizi, int aranan)
        {
            int pointer1 = 0;
            int pointer2 = dizi.Length - 1;

            int sonPozisyon = -1;

            while (pointer1 <= pointer2)
            {
                int mid = (pointer1 + pointer2) / 2;

                if (aranan == dizi[mid])
                {
                    sonPozisyon = mid;

                    pointer1 = mid + 1;
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

            return sonPozisyon;
        }

        static void Main(string[] args)
        {
            int[] dizi = { 1,1,2,2,2,2,3 };
            int aranan = 3;

            int ilkIndex = binarySearch_ilkiBul(dizi,aranan);
            int sonIndex = binarySearch_sonuBul(dizi,aranan);

            int frekans = sonIndex - ilkIndex + 1;

            Console.WriteLine(aranan + " degerinin frekansı:" + frekans);

            Console.ReadLine();
        }
    }
}
