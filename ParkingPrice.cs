using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç saat otoparkta kaldınız: ");
            int hour = int.Parse(Console.ReadLine());
            int price;

            if (hour == 1)
            {
                price = 10;
            }
            else if (hour == 2)
            {
                price = 17;
            }
            else if (hour == 3)
            {
                price = 20;
            }
            else if(hour == 4)
            {
                price = 22;
            }
            else
            {
                price = 22 + (hour - 4) * 5;
            }
            Console.WriteLine("Otopark ücreti: "+price);
            Console.ReadKey();
        }

        
    }
}
