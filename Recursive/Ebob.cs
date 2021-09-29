using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionOrnekler
{
    class Program
    {
        static int Ebob(int a, int b)
        {
            if (a == 0)//a=0 ise ebob b'dir.
                return b;
            if (b == 0)//b=0 ise ebob a'dır.
                return a;

            //Temel durum
            if (a == b)//a=b ise ebob 2'sinden biridir.
                return a;

           //Aşağıdaki kısım tamamen matematiksel yaklaşımdır.büyük olan sayıdan küçük çıkarılarak işlem gerçekleştirilir. Sonunda dönen değer ebob olacaktır.
            if (a > b)
                return Ebob(a - b, b);

            return Ebob(a, b - a);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Ebob(15, 20));
            Console.ReadKey();
        }
    }
}
