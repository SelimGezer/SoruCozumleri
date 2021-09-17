using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozumleri
{
    class Program
    {
     
        public static bool checkSum(int[] dizi,int arananToplam)
        {
            int n = dizi.Length;

            int pointer1 = 0;
            int pointer2 = n - 1;

            while (pointer1 < pointer2)
            {
                int geciciToplam = dizi[pointer1] + dizi[pointer2];

                if(geciciToplam == arananToplam)
                {               
                    return true;
                }

                if (geciciToplam > arananToplam)
                {
                    pointer2--;
                }
                else
                {
                    pointer1++;
                }
            }

            return false;
        }

   
      
        static void Main(string[] args)
        {

             int[] dizi = { -1, 0, 4, 5, 7, 9, 12 };

             bool sonuc = checkSum(dizi, 21);

             Console.WriteLine("Sonuç:" + sonuc);


            Console.ReadLine();
        }
    }
}
