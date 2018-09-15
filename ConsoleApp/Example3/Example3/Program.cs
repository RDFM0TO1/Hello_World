using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int sayici = 1;                  
            while(sayici<11)
            {
                Console.WriteLine($"{sayici}. sayiyi giriniz:");
                int girdi = int.Parse(Console.ReadLine());
                toplam = toplam + girdi;
                sayici = sayici + 1;
            }
            Console.WriteLine($"Girilen sayilarin toplami: {toplam}");
            Console.WriteLine($"Girilen sayilarin ortalaması: {toplam/(sayici-1)}");
            Console.ReadKey();
        }
    }
}
