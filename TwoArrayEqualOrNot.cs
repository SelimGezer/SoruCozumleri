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
        public static bool n2(int[] dizi1, int[] dizi2)
        {
            if (dizi1.Length != dizi2.Length)
            {
                return false;
            }

            int[] check = new int[dizi1.Length];

            for (int i = 0; i < dizi1.Length; i++)
            {
                for (int j = 0; j < dizi2.Length; j++)
                {
                    if (dizi1[i] != dizi2[j] && j == dizi2.Length - 1)
                    {
                        return false;
                    }
                    if (dizi1[i] == dizi2[j] && check[j] != 1)
                    {
                        check[j] = 1;
                        break;
                    }
                }
            }
            return true;
        }

        //Çözüm 2
        public static bool siralamaCozumu(int[] dizi1, int[] dizi2)
        {
            if (dizi1.Length != dizi2.Length)
            {
                return false;
            }

            Array.Sort(dizi1);
            Array.Sort(dizi2);

            for (int i = 0; i < dizi1.Length; i++)
            {
                if (dizi1[i] != dizi2[i])
                {
                    return false;
                }
            }

            return true;
        }

        //Çözüm 3
        public static bool dictionaryCozumu(int[] dizi1, int[] dizi2)
        {
            if (dizi1.Length != dizi2.Length)
            {
                return false;
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < dizi1.Length; i++)
            {
                if (!dict.ContainsKey(dizi1[i]))
                {
                    dict.Add(dizi1[i], 1);
                }
                else
                {
                    dict[dizi1[i]]++;
                }
            }

            for (int i = 0; i < dizi2.Length; i++)
            {
                if (!dict.ContainsKey(dizi2[i]) || dict[dizi2[i]] == 0)
                {
                    return false;
                }
                else
                {
                    dict[dizi2[i]]--;
                }
            }

            return true;
        }


        static void Main(string[] args)
        {
            int[] dizi1 = { 1, 1, 3, 4, 5 };
            int[] dizi2 = { 5, 4, 3, 1, 2 };

            // Console.WriteLine(n2(dizi1, dizi2));
            // Console.WriteLine(siralamaCozumu(dizi1, dizi2));
            // Console.WriteLine(dictionaryCozumu(dizi1, dizi2));

            Console.ReadLine();
        }
    }
}