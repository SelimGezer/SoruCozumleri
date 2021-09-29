using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionOrnekler
{
    class Program
    {
        static int factoriyel(int N)
        {
            if (N == 0)//0! 'in 1 olduğunu biliyoruz. Temel durum
            {
                return 1;
            }

            int sonuc = N * factoriyel(N - 1); //Her faktoriyel kendinden öncekilerle çarpılır. Özyinelemeli kısım

            return sonuc;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sonuc:" + factoriyel(7));
            Console.ReadKey();
        }
    }
}
