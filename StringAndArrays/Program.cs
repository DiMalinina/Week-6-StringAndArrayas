using System;

namespace StringAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm kuvad kasutaja eesnime pikkust

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            //int firstNamelength = firstName.Length;

            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");
        }
    }
}
