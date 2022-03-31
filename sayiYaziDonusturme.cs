using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiYaziDonusturme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayıyı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int yuzler = sayi / 100;
            int onlar = (sayi % 100) / 10;
            int birler = sayi % 10;
            string[] onlarDizisi = { "","on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string[] yazi = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            Console.WriteLine(yazi[yuzler] + " yüz" +" "+onlarDizisi[onlar]+" "+ yazi[birler]);
            Console.ReadKey();
        }
    }
}
