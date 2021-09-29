using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionOrnekler
{
    class Program
    {
        static void binary(int deger)
        {
            if (deger == 1)//Temel durum. Eğer değer 1 ise artık 2'ye bölünecek bir şey kalmamış demektir.
            {
                Console.Write(deger);
                return;
            }

            int kalan = deger % 2;
            deger = deger / 2;

            binary(deger);//Özyinelemeli kısım. Yebi bölüm değeriyle tekrar çağırıyoruz.

            Console.Write(kalan);
                  
        }

        static void Main(string[] args)
        {
            binary(10);
            Console.ReadKey();
        }
    }
}
