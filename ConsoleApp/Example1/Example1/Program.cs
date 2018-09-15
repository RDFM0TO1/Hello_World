using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    /*Bu örnekte sınıf ve nesne oluşturma ve kullanımlarıyla alakalı örnekler yapıldı.
     tanımlanan sınıf içerisinden get ve set fonksiyonlarıyla değerler alındı ve verildi
     kapsülleme işlemi yapıldı(kapsülleme işlemi sınıfta tanımlanan özelliklerin belirli metodlar ve
     şartlar ile kodu yazan kişi tarafından kontrol edilmesi direkt olarak değiştirilememesini sağlar
     oluşturulan sınıfla aynı ismi taşıyan fonksiyon ilk olarak çalıştırılır ve buna çeşitli değerler atanabilir bu sayede
     set işlemini ekstaradan yapmaya gerek kalmadan new ile sınıf kullanılırken çeşitli tanımlamalar yapılabilir.*/
    class insan
    {
        public insan()
        {
            Console.WriteLine("Bir insan yaratıldı");
        }
        public insan(int yenikilo)
        {
            kilo = yenikilo;
        }
        public String isim;
        private int kilo;
        public int Kilo
        {
            get
            {
                return kilo;
            }
            set
            {
                if (value < 0)
                    kilo = 0;
                else
                    kilo = value;
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            insan Ali = new insan (54);
            Ali.isim = "Ali Demir";
            //Ali.Kilo=54;
            insan Veli = new insan();
            Veli.isim = "Veli Kara";
            Veli.Kilo=-2;
            Console.WriteLine($"alinin kilosu:{Ali.Kilo}");
            Console.WriteLine($"velinin kilosu:{Veli.Kilo}");

            Console.ReadKey();
        }
    }
}
