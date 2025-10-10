using System;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompt prompt = new Prompt();
        Menu menu = new Menu();

        while (true)
        {
            menu.Display();
            int choice = menu.userInput();

            if (choice == 1)
            {
                journal.AddEntry(prompt);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                journal.LoadFromFile();
            }
            else if (choice == 4)
            {
                journal.SaveToFile();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.\n");
            }
        }
    }
}
