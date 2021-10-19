using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumleri
{
    class Program
    {

        //Çözüm 1
        public static int[] duplicateRemoveArrayBase(int[] dizi)
        {
            int[] yeni = new int[dizi.Length];
            int j = 0;

            for (int i = 0; i < dizi.Length - 1; i++)
            {
                if (dizi[i] == dizi[i + 1])
                {
                    continue;
                }

                yeni[j++] = dizi[i];
            }

            yeni[j] = dizi[dizi.Length - 1];

            Array.Resize(ref yeni, j + 1);

            return yeni;
        }

        //Çözüm 2
        public static int[] duplicateRemove(int[] dizi)
        {
            int j = 1;

            for (int i = 0; i < dizi.Length - 1; i++)
            {
                if (dizi[i] == dizi[i + 1])
                {
                    continue;
                }

                dizi[j++] = dizi[i + 1];
            }

            Array.Resize(ref dizi, j);

            return dizi;
        }

        static void Main(string[] args)
        {
            int[] dizi = { 1, 1, 2, 2, 3, 4, 4 };

            int[] cozum1 = duplicateRemoveArrayBase(dizi);
            int[] cozum2 = duplicateRemove(dizi);

            Console.ReadLine();
        }
    }
}