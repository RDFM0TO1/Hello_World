using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1;
            int sayi2;
            int toplam;

            Console.Write("Toplamak istediginiz ilk sayiyi giriniz");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("Toplamak istediginiz ikinci sayiyi giriniz");
            sayi2 = int.Parse(Console.ReadLine());

            toplam = sayi1 + sayi2;
            Console.WriteLine($"Toplam işleminin sonucu {toplam}");
            bool Enter = false;
            Console.WriteLine("Çıkmak için herhangi bir tuşa basınız!");
            Console.ReadKey();



        }
    }
}
