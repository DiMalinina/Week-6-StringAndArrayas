using System;

namespace HelloWorldReversed
{

    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello World!" tagurpidi.


            string sentence = "Hello World!";

            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                Console.Write(sentence[i]);
            }

        }



    }



}
   








