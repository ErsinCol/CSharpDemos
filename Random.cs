using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RANDOM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random=new Random();
            int toplam = 0;
            int olusturulan=0;
            for(int i = 0; i < 10; i++)
            {
                int randomSayi= random.Next(0, 100);
                if (randomSayi >= 30 && randomSayi <= 50) continue;
                toplam += randomSayi;
                olusturulan++;
                Console.WriteLine(randomSayi);
            }
            double aOrt = toplam / olusturulan;
            Console.WriteLine("Random sayıların aritmetik ortalaması: {0:F2}" ,aOrt);
            Console.ReadKey();
        }
    }
}
