using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nimedes on pikem , kas ess- või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string lastName = Console.ReadLine();

            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine($"Eesnimi on pikem {firstName.Length} sümbolit.");
            }
            else if (firstName.Length < lastName.Length)
            {
                Console.WriteLine($"Perekonnanimi on pikem. {lastName.Length} sümbolit.");
            }


            Console.WriteLine("Kena päeva!");


        }
    }
}
