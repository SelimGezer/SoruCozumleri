using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionOrnekler
{
    class Program
    {

        static void sayilar(int N, int NereyeKadar)
        {
            if (N == NereyeKadar)//Temel durum. Artan sayının(N) ulaşmak istediğime ulaştığımda sonlanıyor.
            {
                Console.Write(N + " ");
                return;
            }

            Console.Write(N + " ");

            sayilar(N + 1, NereyeKadar);//Özyinelemeli kısım 
        }

        static void sayilarTers(int N, int NereyeKadar)
        {
            if (N == NereyeKadar)//Temel durum. Artan sayının(N) ulaşmak istediğime ulaştığımda sonlanıyor.
            {
                Console.Write(N + " ");
                return;
            }

            sayilarTers(N + 1, NereyeKadar);//Özyinelemeli kısım 

            Console.Write(N + " ");
        }

        static void Main(string[] args)
        {
            sayilar(0, 20);//Artan sırada yazdır
            Console.WriteLine();
            sayilarTers(0, 20); //Azalan sırada saydır

            //Not: 2 methodta sadece ConsolewriteLine'LARIN yerinin farklı olduğuna dikkat edin!
            Console.ReadKey();
        }
    }
}
