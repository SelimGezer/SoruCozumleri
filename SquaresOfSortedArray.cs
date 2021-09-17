using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumleri
{
    class Program
    {

        public static int[] kareleriSirala(int[] a)
        {
            int n = a.Length;

            int[] karelerArray = new int[n];     
            int karelerSonIndis = n - 1;

            int pointer1 = 0;
            int pointer2 = n - 1;

            while (pointer1 <= pointer2)
            {

                int pointer1Kare =(int) Math.Pow(a[pointer1], 2);
                int pointer2Kare =(int) Math.Pow(a[pointer2], 2);

                if (pointer1Kare > pointer2Kare)
                {
                    karelerArray[karelerSonIndis] = pointer1Kare;
                    pointer1++;
                }
                else
                {
                    karelerArray[karelerSonIndis] = pointer2Kare;
                    pointer2--;
                }

                karelerSonIndis--;
            }

            return karelerArray;
        }

        static void Main(string[] args)
        {
            int[] dizi = { -7,-5,-2,-1,0,4,6 };

            int[] sonuc = kareleriSirala(dizi);

            for (int i = 0; i < sonuc.Length; i++)
            {
                Console.Write(sonuc[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
