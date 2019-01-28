using System;
using System.Linq;
using System.Configuration;
using System.Text.RegularExpressions;

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
            Console.WriteLine("Enter a phrase to encode (Capital letters, symbols and spaces will be ignored): ");
            phrase = Console.ReadLine();
            Console.WriteLine("Please enter the shift number: ");
            cipherShift = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < phrase.Length; i++)
            {
<<<<<<< HEAD
                for(int x = 0; x < key.Length; x++)
                {
                    if(phrase[i + cipherShift] < key.Length)
=======
                //int temp = Array.IndexOf(phraseArray,phraseArray[i]);
                Regex rgx = new Regex(phrase);
                Match match = rgx.Match(phrase);
                foreach(Match m in rgx.Matches(phrase, phraseArray[i]))
                    Console.WriteLine("Temp: {0}", m.Index);
                for(int x = 0; x < key.Length; x++)
                {
                    /*if(temp > key[x])
>>>>>>> .
                    {
                        encryptedPhrase += encryptedPhrase.Append(key[x + cipherShift]);
                    }
<<<<<<< HEAD
=======
                    else
                        if(phraseArray[i] == key[x])
                        {
                            encryptedArray[i] = key[x + cipherShift];
                            Console.WriteLine("Encrypted phrase: {0}", encryptedArray[i]);
                        }
                    */
>>>>>>> .
                }
            }
            Console.WriteLine("Test Phrase: {0}", encryptedPhrase);

        }
    }
}
