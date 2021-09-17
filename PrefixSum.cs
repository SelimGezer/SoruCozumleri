using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[] { 1, 2, 3, 4, 5 };
            
            List<string> sorgular = new List<string>();
            sorgular.Add("2,3");
            sorgular.Add("3,4");
            sorgular.Add("1,3");

          //Standart kaba kuvvet yaklaşım
            int toplam = 0;
            for (int i = 0; i < sorgular.Count; i++)//n adım
            {
                string sorgu = sorgular[i];

                toplam = 0;

           
                for (int j = sorgu[0] -'0'; j <= sorgu[2] -'0'; j++)//m adım
                {
                    toplam += dizi[j];
                }

                Console.Write(toplam + " ");

            }//0(n*m)

            Console.WriteLine("\n-----------------");

            //Prefix sum yaklaşımı
            int[] prefixSum = new int[dizi.Length];

            prefixSum[0] = dizi[0];

            for (int i = 1; i < dizi.Length; i++)//n adım
            {
                prefixSum[i] = prefixSum[i - 1] + dizi[i];
            }

            for (int i = 0; i < sorgular.Count; i++)//m adım
            {
                string sorgu = sorgular[i];
                int altSinir = sorgu[0] - '0';
                int ustSinir = sorgu[2] - '0';

                toplam = prefixSum[ustSinir] - prefixSum[altSinir - 1];
                Console.Write(toplam + " ");
            }
            //O(n+m)

            Console.Read();

        }
    }
}

