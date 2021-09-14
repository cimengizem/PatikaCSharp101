using System;

namespace ConsoleProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("İsminiz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminiz: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);
            Console.ReadLine();
        }
    }
}
