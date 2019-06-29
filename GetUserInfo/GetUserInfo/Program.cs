using System;

namespace GetUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Whats your name?");
            Console.ReadLine();

            Console.WriteLine("Is that your full name?/n(y/n)");
            string response = Console.ReadLine();

            if (response == "n")
            {
                Console.WriteLine("What's your last name?");
                Console.ReadLine();
            }







        }
    }
}
