using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionOrnekler
{
    class Program
    {
        static string reverseBinary(int deger, string sonuc)//reverse bit
        {
            if (deger == 1)//Temel durum.1 ' ulaşmışsa artık bölünecek bir şey kalmamış demektir.
            {
                Console.Write(deger);
                sonuc += "" + deger;
                return sonuc;
            }

            int kalan = deger % 2;
            Console.Write(kalan);

            deger = deger / 2;
            sonuc += "" + kalan;

            sonuc = reverseBinary(deger, sonuc);//yeni bölüm değeriyle tekrar çağrılıyor.

            return sonuc;
        }


        static void Main(string[] args)
        {
            //13 2'lik olarak 1101 'dir. Bunun tersi ise 1011 eder yani o da decimal olarak 11 sayısına denk gelir.

            string sonuc = reverseBinary(13, "");
            Console.ReadKey();
        }
    }
}
