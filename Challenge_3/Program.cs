using System;

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
            int cipherShift;
            char[] phraseArray;
            char[] encryptedArray = {};
            char[] key = {'a', 'b', 'c', 'd', 'e', 'f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            Console.WriteLine("Enter a phrase to encrypt (Numbers, Symbols and Spaces will be ignored):");
            phrase = Console.ReadLine();
            phraseArray = phrase.ToCharArray();
            Console.WriteLine("Enter the number to shift:");
            cipherShift = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref encryptedArray, phrase.Length); // change array size to length of phrase
            Console.WriteLine("Size: {0}", key.Length);
            for (int i = 0; i < phrase.Length; i++)
            {
                for(int x = 0; x < key.Length; x++)
                {
                    if(phraseArray[i] == key[x])
                    {
                        //encryptedArray[i] = key[x + cipherShift];
                        if(key[x + cipherShift] > key.Length)
                        {
                            Console.WriteLine("To Big");
                        }
                        Console.WriteLine("Encrypted phrase: {0}", encryptedArray[i]);
                    }
                }
            }
            //phrase = Convert.ToString(encryptedArray);
            //Console.WriteLine("Encrypted phrase: {0}", phrase);
        }
    }
}
