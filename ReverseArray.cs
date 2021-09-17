using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumleri
{
    class Program
    {
        //Two Pointerlı Yaklaşım
        public static char[] reverseArr(char[] dizi)
        {
            int pointer1 = 0;
            int pointer2 = dizi.Length - 1;

            while (pointer1 < pointer2)
            {
                char gecici = dizi[pointer2];
                dizi[pointer2] = dizi[pointer1];
                dizi[pointer1] = gecici;

                pointer1++;
                pointer2--;
            }

            return dizi;
        }

        //İlk akla gelen yaklaşım
        public static char[] reverseBad(char[] dizi)
        {
            char[] yeni = new char[dizi.Length];

            int j = 0;
            for (int i = dizi.Length-1; i > -1; i--)
            {
                yeni[j] = dizi[i];
                j++;
            }

            return yeni;
        }

        static void Main(string[] args)
        {

           reverseBad(new char[] { 's', 'e', 'l', 'i', 'm', '2', '7' });

           reverseArr(new char[] { 's', 'e', 'l', 'i', 'm', '2', '7' });


            Console.ReadLine();
        }
    }
}
