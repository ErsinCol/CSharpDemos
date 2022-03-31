using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticAverageApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {22,30,62,53,82,50,42,64,56,35,38,94,14};
            float total = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine("Dizinin aritmetik ortalaması: {0:F2}",total / numbers.Length);
            Console.ReadKey();
        }
        
    }
}
