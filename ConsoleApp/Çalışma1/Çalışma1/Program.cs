using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            int carpim;
            string isim;
            Console.WriteLine("Isminizi giriniz:");
            isim = Console.ReadLine();
            Console.WriteLine($"Hoşgeldin {isim} lütfen ilk sayiyi giriniz");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen ikinci sayiyi giriniz");
            sayi2 = int.Parse(Console.ReadLine());
            if (sayi1 == sayi2) { Console.WriteLine($"{sayi1} ve {sayi2} birbirine eşit"); }
            else { Console.WriteLine($"{sayi1} ve {sayi2} birbirine eşit değil"); }
           
            Console.ReadKey();
        }
    }
}
