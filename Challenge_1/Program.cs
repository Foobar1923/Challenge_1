using System;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                create a program that will ask the users name, age, and reddit username. have it tell them the information back, in the format:
                your name is (blank), you are (blank) years old, and your username is (blank)
             */
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            string userAge = Console.ReadLine();
            int intAge = Convert.ToInt32(userAge);
            Console.WriteLine("Please enter your Reddit username: ");
            string redditName = Console.ReadLine();

            Console.WriteLine("Your name is {0}, your age is {1} and your Reddit username is {2}.", userName, intAge, redditName);
        }
    }
}
