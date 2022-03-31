using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seasons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaçıncı ay: ");
            int month= Convert.ToInt32(Console.ReadLine());
            string season="";
            string[] months = { "OCAK", "ŞUBAT", "MART", "NİSAN", "MAYIS", "HAZİRAN", "TEMMUZ", "AĞUSTOS", "EYLÜL", "EKİM", "KASIM", "ARALIK" };    
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    season = "Kış"; break;
                case 3:
                case 4:
                case 5:
                    season = "İlkbahar"; break;
                case 6:
                case 7:
                case 8:
                    season = "Yaz"; break;
                case 9:
                case 10:
                case 11:
                    season = "Sonbahar"; break;
                default:
                    Console.WriteLine("Yanlış ay..."); break;
            }
            Console.WriteLine("Girdiğiniz ay {0} ... Mevsim: {1}",months[month-1],season);
            Console.ReadKey();
        }
    }
}
