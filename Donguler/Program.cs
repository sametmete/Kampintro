using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Console.WriteLine("sayı gir");
                int sayi = int.Parse(Console.ReadLine());

                for (int i = 1; i <=sayi; i++)
                {
                    Console.WriteLine(i);
                }
            */

            string[] kurslar = new string[] { "Yazılım geliştirme yetiştirme kampı", 
                "Programlamaya giriş eğitimi", "Java", "C#", "Python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
