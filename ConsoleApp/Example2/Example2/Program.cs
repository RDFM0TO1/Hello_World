using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Student
    {
        public String Isim { get; set; }
        private int ortalama;
        


        public Student(String ogrenciIsim, int ogrenciOrtalama)
        {
            Isim = ogrenciIsim;
            ortalama = ogrenciOrtalama;
        }

        public int Ortalama
        {
            get
            {
                return ortalama;
            }
            set
            {
                if (value > 0)
                    if (value < 100)
                        ortalama = value;
            }
        }
        
        public String Harfnotu
        {
            get
            {
                string harfnotu = string.Empty;
                if (ortalama > 80)
                    harfnotu = "A";
                else if (Ortalama > 60)
                    harfnotu = "B";
                else
                    harfnotu = "F";
                return harfnotu;
            }
           
        }

        class Program
        {
            static void Main(string[] args)
            {
                Student student1 = new Student("Ali Kızıl", 88);
                Student student2 = new Student("Ömer Aslan", 69);
                Student student3 = new Student("Timur Kaya", 33);
                Console.WriteLine($"{student3.Isim} isimli ogrencinin ortalaması: {student3.Ortalama} harf notu: {student3.Harfnotu}");
                Console.WriteLine($"{student1.Isim} isimli ogrencinin ortalaması: {student1.Ortalama} harf notu: {student1.Harfnotu}");
                Console.WriteLine($"{student2.Isim} isimli ogrencinin ortalaması: {student2.Ortalama} harf notu: {student2.Harfnotu}");
                Console.ReadKey();
            }
        }
    }
}
