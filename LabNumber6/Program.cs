using System;

namespace LabNumber6
{
    class Program
    {
        static void Main(string[] args)
        {


            //***INPUT***

            Console.Write("Welcome to the Grand Circus Casino! Roll the dice? (y/n): ");
            string userInput = UserResponseChecker();

            Console.WriteLine("How many sides should each die have? ");
            int sidesOfDice = int.Parse(Console.ReadLine());

            //***PROCESSING***

            Console.WriteLine(RollDice(sidesOfDice, "Roll 1"));
            Console.WriteLine(RollDice(sidesOfDice, "Roll 2"));

            //***OUTPUT***



        }

        public static string UserResponse()
        {
            string response = Console.ReadLine().ToLower();
            return response;

        }

        public static string UserResponseChecker()
        {
            string input = UserResponse();

            while (input != "y" && input != "n" && input != "yes" && input != "no")
            {
                Console.WriteLine("Error! Input not recognized. Please try again...");
            }

            return input;
        }

        public static int RollDice(int sidesOfDice, string message)
        {
            int randomNumb = RandomNumber.Randomness.getNextInt(1, sidesOfDice);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(message);

            return randomNumb;
        }
    }
}
