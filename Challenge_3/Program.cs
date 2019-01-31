using System;
using System.Linq;
using System.Configuration;

namespace Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*            
            write a program that can encrypt texts with an alphabetical caesar cipher. This cipher can ignore numbers, symbols, and whitespace.            
            cipher - shift each letter 1 to the left or right
            */

            string phrase;
            string encryptedPhrase = "";
            int cipherShift;
            char[] key = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            char[] phraseChar = {};
            Console.WriteLine("Enter a phrase to encode (Capital letters, symbols and spaces will be ignored): ");
            phrase = Console.ReadLine();
            phraseChar = phrase.ToCharArray();
            Console.WriteLine("Please enter the shift number: ");
            cipherShift = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < phrase.Length; i++) // checks phrase value
            {
                for(int x = 0; x < key.Length; x++) // checks key value
                {
                    if(phraseChar[i] == key[x])
                    {
                        encryptedPhrase += key[x]; // creates encrypted phrase based off current phrase + shifted key value
                    }
                }
            }
            Console.WriteLine("Test Phrase: {0}", encryptedPhrase);

        }
    }
}
