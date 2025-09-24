using System;

class Program
{
    static void Main(string[] args)
    {
        // User input magic number
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Creates random number generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guess = -1;

        // While loop to continue guessing until correct
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string number = Console.ReadLine();
            int number2 = int.Parse(number);

            if (number2 > magicNumber)
            {
                Console.WriteLine("Lower ");
            }

            else if (number2 < magicNumber)
            {
                Console.WriteLine("Higher ");
            }

            else
            {
                Console.WriteLine("You guessed it!");
                guess = magicNumber;
            }

        }
    }
}