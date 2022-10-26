using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım gelitirici kursu";
            string kurs2 = "Probramlamaya başlangıç için kurs";
            string kurs3 = "Java";
            
            //array - liste 

            string[] kurslar = new string[] { "Yazılım gelitirici kursu", "Probramlamaya başlangıç için kurs", "Java", "Python","C#"};


            for (int i = 0  ; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
