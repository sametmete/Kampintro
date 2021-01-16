using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }

        public int izlenmeOrani { get; set; }
    }
}
