using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {

        List<int> number = new List<int>();

        int myNumber = -1;

        while (myNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished" );

            string numbers = Console.ReadLine();
            myNumber = int.Parse(numbers);

            if (myNumber != 0)
            {
                number.Add(myNumber);
            }
        }

        int sum = 0;

        foreach (int i in number)
        {
            sum += i;
        }

        float average = ((float)sum) / number.Count;

        int max = number[0];

        foreach (int i in number)
        {
            if (i > max)
            {
                max = i;
            }
        }

        Console.WriteLine($"The sum of the numbers is {sum}");
        Console.WriteLine($"The average of the numbers is {average}");
        Console.WriteLine($"The max of the numbers is {max}");

    }
}