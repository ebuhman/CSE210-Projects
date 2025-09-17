using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        if (number >= 70)
        {
            string letter;
            string passing = "You passed!";
            if (number >= 90)
            {
                letter = "A";
                Console.WriteLine($"You got a {letter}, {passing}");
            }

            else if (number >= 80 && number >= 90)
            {
                letter = "B";
                Console.WriteLine($"You got a {letter}, {passing}");
            }

            else if (number >= 70 && number >= 80)
            {
                letter = "C";
                Console.WriteLine($"You got a {letter}, {passing}");
            }
        }

        if (number < 70)
        {
            string letter;
            string failing = "I hope next time you succeed, try your best!";
            if (number < 70 && number >= 60)
            {
                letter = "D";
                Console.WriteLine($"You got a {letter}, {failing}");
            }

            else if (number < 60)
            {
                letter = "F";
                Console.WriteLine($"You got a {letter}, {failing}");
            }
        }
    }
}