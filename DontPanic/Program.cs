using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses (Don't panic) nullig - 0
            //programm asendab kõik 'a' tähed lauses 4-ga


            string dpc = "Don't panic";

            dpc = dpc.Replace('o', '0');
            dpc = dpc.Replace('a', '4');

            Console.WriteLine(dpc);
        }
    }
}
