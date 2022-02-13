using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello world"

            string Word = "Hello world!".ToLower();

            int hCounter = 0;

            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == 'h')
                {
                    hCounter++;
                }
            }

            if (hCounter != 1)
            {
                Console.WriteLine($"Lauses Hello World on {hCounter} 'h' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses Hello World on {hCounter} 'h' täht.");
            }


            int oCounter = 0;

            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == 'o')
                {
                    oCounter++;
                }

            }

            if (oCounter != 1)
            {
                Console.WriteLine($"Lauses Hello World on {oCounter} 'o' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses Hello World on {oCounter} 'o' täht.");
            }

            int lCounter = 0;

            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == 'l')
                {
                    lCounter++;
                }

            }

            if (lCounter != 1)
            {
                Console.WriteLine($"Lauses Hello World on {lCounter} 'l' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses Hello World on {lCounter} 'l' täht.");
            }





        }
    }
}
