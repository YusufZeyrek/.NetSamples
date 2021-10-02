using System;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
                       
            Console.Write("İsminizi giriniz: ");
            name = Console.ReadLine();

            Console.Write("Soyisminizi giriniz: ");
            surname = Console.ReadLine();

            Console.WriteLine("Merhaba {0} {1} Hoşgeldin");

            Console.ReadLine();

        }
    }
}
