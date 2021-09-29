using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionOrnekler
{
    class Program
    {

        static void stringPermutation(string ifade, int start, int j)
        {
            if (start == ifade.Length - 1)//Son karaktere vardıysa artık işlem yapmasına gerek yoktur.
            {
                return;
            }

            for (int i = start; i < ifade.Length; i++)
            {
                 /* if (start == 0)//Start'ın sıfır olduğu noktalar recursion tree nin root düğümüne tekabül etmektedir.
                  {
                     Console.WriteLine(ifade + "---Root--- "+i);
                  }*/

                //Swap Start
                char okunan = ifade[i];
                char degisen = ifade[j];

                string gecici;
                gecici = ifade.Remove(i, 1);
                gecici = gecici.Insert(i, degisen.ToString());

                gecici = gecici.Remove(j, 1);
                gecici = gecici.Insert(j, okunan.ToString());
                //Swap End

                stringPermutation(gecici, start + 1, j + 1);//Swap Sonrası yeni halini tekrar çağır

                if (j + 1 == gecici.Length - 1)///Eğer j+1 kelimenin sonuna denk geliyorsa o permütasyonlarınadan biridir.
                {
                    Console.WriteLine(gecici);
                }
            }
        }


        static void Main(string[] args)
        {
            stringPermutation("abc", 0, 0);
            Console.ReadKey();
        }
    }
}
