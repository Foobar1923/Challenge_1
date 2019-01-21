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
            for (int i = 0; i < phrase.Length; i++)
            {
                for(int x = 0; x < key.Length; x++)
                {
                    /*
                    if phraseArray[i + cipherShift] > key.length
                    int temp = cipherShift - (key.length - phraseArray[i])
                    encryptedArrary[i] = key[temp]
                    */
                    
                    if(phraseArray[i] == key[x])
                    {
                        int temp = Array.IndexOf(phraseArray, i);
                        Console.WriteLine("Temp: {0}",temp);
                        //encryptedArray[i] = key[x + cipherShift];
                        Console.WriteLine("Encrypted phrase: {0}", encryptedArray[i]);
                    }
                }
            }
            //phrase = Convert.ToString(encryptedArray);
            //Console.WriteLine("Encrypted phrase: {0}", phrase);
        }
    }
}
