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

            string NumOfPets;
            bool NumOfPetsCheck;
            int NumberOfPets;

            if (HasPets == "y")
            {
                do
                {
                    NumOfPets = askQuestion("How many pets do you have?");
                    NumOfPetsCheck = int.TryParse(NumOfPets, out NumberOfPets);
                } while (NumOfPetsCheck == false);


                if (NumberOfPets == 1)
                {
                    Console.WriteLine("Awesome! A pet is always nice to have around.");
                    Console.WriteLine("So your name is " + UserFirstName + " " + UserLastName + ",\nYour favorite number is " + FavNumber + ",\n" +
                    "and lastly you have " + NumOfPets + " pet!");
                    Console.WriteLine("Well met friend! It was nice getting to know you! Have a good day:)");
                }
                else if (NumberOfPets >= 2)
                {

                    Console.WriteLine("Sweet! Pets are always nice to have around.");
                    Console.WriteLine("So your name is " + UserFirstName + " " + UserLastName + ",\nYour favorite number is " + FavNumber + ",\n" +
                "and lastly you have " + NumOfPets + " pets!");
                    Console.WriteLine("Well met friend! It was nice getting to know you! Have a good day:)");
                }
            }

            else if (HasPets == "n")
            {
                    Console.WriteLine("That's a bummer. Pets are amazing companions.\nYou should think about getting one!\n");
                    Console.WriteLine("So your name is " + UserFirstName + " " + UserLastName + ",\nYour favorite number is " + FavNumber + ",\n" +
                "and lastly you have no pets.");
                    Console.WriteLine("Well met friend! It was nice getting to know you! Have a good day:)");
            }


        }
    }
}
