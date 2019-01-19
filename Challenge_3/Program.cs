using System;

namespace Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
                write a program that can encrypt texts with an alphabetical caesar cipher. This cipher can ignore numbers, symbols, and whitespace.

             */
             
            string encryptPhrase;
            int encryptShift;

            Console.WriteLine("Please enter a phrase to encrypt (Numbers, Symbols and Spaces will be ignored):");
            encryptPhrase = Console.ReadLine();
            
            Console.WriteLine("Pleae enter a shift variable:");
            encryptShift = Console.ReadLine();
            
        }
    }
}
