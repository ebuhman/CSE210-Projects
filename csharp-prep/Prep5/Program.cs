using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareResult(userNumber);
        int birthYear = PromptUserBirthYear();

        DisplayResult(userName, squaredNumber, birthYear);

        static void DisplayWelcome()

        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());

            return number;

        }

        static int PromptUserBirthYear()
        {
            Console.Write("Please enter your birth year ");
            int birthYear = int.Parse(Console.ReadLine());
            return birthYear;
        }

        static int SquareResult(int number)
        {
            int square = number * number;
            return square;
        }


        static void DisplayResult(string name, int square, int birthYear)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
            Console.WriteLine($"{name}, you will turn {2025 - birthYear} years old this year.");
        }

    }
}