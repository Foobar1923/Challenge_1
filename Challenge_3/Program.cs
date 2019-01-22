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
            int cipherShift, phraseSize;
            char[] phraseArray;
            char[] encryptedArray = {};
            char[] key = {'a', 'b', 'c', 'd', 'e', 'f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            Console.WriteLine("Enter a phrase to encrypt (Numbers, Symbols and Spaces will be ignored):");
            phrase = Console.ReadLine();
            phraseArray = phrase.ToCharArray();
            Console.WriteLine("Enter the number to shift:");
            cipherShift = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref encryptedArray, phrase.Length); // change array size to length of phrase
            phraseSize = phrase.Length;
            for (int i = 0; i < phraseSize; i++)
            {
                int temp = Array.IndexOf(phraseArray,phraseArray[i]);
                Console.WriteLine("Temp: {0}", temp);
                for(int x = 0; x < key.Length; x++)
                {
                    if(temp > key[x])
                    {
                        int overFlow = (temp % i) + cipherShift;
                        encryptedArray[i] = key[overFlow];
                    }
                    else
                        if(phraseArray[i] == key[x])
                        {
                            encryptedArray[i] = key[x + cipherShift];
                            Console.WriteLine("Encrypted phrase: {0}", encryptedArray[i]);
                        }
                }
            }
            //phrase = Convert.ToString(encryptedArray);
            //Console.WriteLine("Encrypted phrase: {0}", phrase);
        }
    }
}
