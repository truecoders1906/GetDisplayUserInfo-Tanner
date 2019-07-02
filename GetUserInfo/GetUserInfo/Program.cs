using System;

namespace GetUserInfo
{
    class Program
    {

        static string askQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string UserFirstName;
            string UserLastName;
            string UserFullName;

            do
            {
                UserFirstName = askQuestion("Hello! Whats your first name?");
                Console.WriteLine("Nice to meet you, " + UserFirstName + "!");

                UserLastName = askQuestion("What's your last name?");

                UserFullName = askQuestion("So your full name is " + UserFirstName + " " + UserLastName + "?\n(y/n)");
            } while (UserFullName == "n");

            string FavNumber;
            bool FavNumberCheck;

            do
            {
                FavNumber = askQuestion("What is your favorite number?");
                FavNumberCheck = int.TryParse(FavNumber, out _);
            } while (FavNumberCheck == false);

            Console.WriteLine(FavNumber + " is a great number!");

            string HasPets = askQuestion("Do you have any pets? (y/n)");

            if (HasPets == "y")
            {
                Console.WriteLine("How many pets do you have?");
                string response = Console.ReadLine();
                int numberOfPets = int.Parse(response);

                string[] petNames = new string[numberOfPets];

                for (int i = 0; i < numberOfPets; i++)
                {
                    Console.WriteLine("What is the name of one of your pets?");
                    string petName = Console.ReadLine();
                    petNames[i] = petName;
                }

                Console.WriteLine("\nSo your name is " + UserFirstName + " " + UserLastName + ",\nYour favorite number is " + FavNumber + ",\n" +
                "you have " + response + " pet(s) named");

                foreach (var petName in petNames)
                {
                    Console.WriteLine(petName);
                }

                Console.WriteLine("\nWell met friend! It was nice getting to know you! Have a good day:)");

            }

            else
            {
                Console.WriteLine("That's a bummer. Pets are amazing companions.\nYou should think about getting one!\n");
                Console.WriteLine("So your name is " + UserFirstName + " " + UserLastName + ",\nYour favorite number is " + FavNumber + ",\n" +
                "and lastly you have no pets.");
                Console.WriteLine("Well met friend! It was nice getting to know you! Have a good day:)");
            }

        }
    }
}
