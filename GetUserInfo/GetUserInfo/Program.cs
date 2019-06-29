using System;

namespace GetUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Whats your first name?");
            string UserFirstName = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + UserFirstName + "!\n" +
                "What's Your last name?");

            string UserLastName = Console.ReadLine();

            Console.WriteLine("So your full name is " + UserFirstName + " " + UserLastName + "?");


            Console.WriteLine("What's your favorite number " + UserFirstName + "?");
            string FavNumber = Console.ReadLine();

            Console.WriteLine(FavNumber + " is a great number!");


            Console.WriteLine("Do you have any pets?");
            string HasPets = Console.ReadLine();

            Console.WriteLine("Sweet! Pets are always nice to have around.");


            Console.WriteLine("How many pets do you have?");
            string NumOfPets = Console.ReadLine();

            Console.WriteLine("So your name is " + UserFirstName + " " + UserLastName + ",\nYour favorite number is " + FavNumber + ",\n" +
                "and lastly you have " + NumOfPets + " pets, right?");
            Console.WriteLine("Well met friend! It was nice getting to know you! Have a good day:)");
            







        }
    }
}
