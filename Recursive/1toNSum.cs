using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionOrnekler
{
    class Program
    {
        static void _1toN_SUM(int N, int toplam)
        {
            if (N > 20)//Temel durum. Nereye kadar toplanmasını istiyorsanız.
            {
                return;
            }

            for (int i = 0; i <= N; i++)
            {
                toplam += i;
                Console.Write(i + " ");
            }

            Console.WriteLine("Top:" + toplam);

            _1toN_SUM(N + 1, toplam = 0);//Özyinelemeli kısım. 
        }

        static void Main(string[] args)
        {
            _1toN_SUM(0,0);
            Console.ReadKey();
        }
    }
}
