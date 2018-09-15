using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            int not = 0;
            int harfa=0;
            int harfb=0;
            int harfc=0;
            int harfd=0;
            int harff=0;
             
            while(not != -1)
            {
                Console.WriteLine("Ogrenci notunu giriniz(Programı sonlandırmak için -1 'e basınız!):");
                not = int.Parse(Console.ReadLine());
                switch (not / 10)
                {
                    case 10:
                    case 9:
                        ++harfa;
                        break;
                    case 8:
                    case 7:
                        ++harfb;
                        break;
                    case 6:
                        ++harfc;
                        break;
                    case 5:
                        ++harfd;
                        break;
                    case 4:
                    case 3:
                    case 2:
                    case 1:
                    case 0:
                        ++harff;
                        break;
                    
                }
                

            }
            Console.WriteLine($"Sınıfta toplam A notu sayısı: {harfa}");
            Console.WriteLine($"Sınıfta toplam B notu sayısı: {harfb}");
            Console.WriteLine($"Sınıfta toplam C notu sayısı: {harfc}");
            Console.WriteLine($"Sınıfta toplam D notu sayısı: {harfd}");
            Console.WriteLine($"Sınıfta toplam F notu sayısı: {harff}");
            Console.ReadKey();
        }
    }
}
