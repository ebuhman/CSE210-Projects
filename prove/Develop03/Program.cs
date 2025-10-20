using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.ShowRandomScripture();

        Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            bool wordsLeft = scripture.HideMoreWords();

            if (wordsLeft == false)
            {
                break;
            }
        }
    }
}