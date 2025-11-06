using System;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listening activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                Breathing breathing = new Breathing();
                Console.WriteLine(breathing.DisplayIntro());
                breathing.GetSecondsCount();
                breathing.DisplayBreath();

                Console.Clear();
            }
            else if (input == "2")
            {
                Console.Clear();
                Reflecting reflecting = new Reflecting();
                Console.WriteLine(reflecting.DisplayIntro());
                reflecting.GetSecondsCount();
                reflecting.DisplayReflection();

                Console.Clear();
            }
            else if (input == "3")
            {
                Console.Clear();
                Listing listing = new Listing();
                Console.WriteLine(listing.DisplayIntro());
                listing.GetSecondsCount();
                listing.DisplayListing();

                Console.Clear();
            }
            else if (input == "4")
            {
                Console.WriteLine("Goodbye!");
                isRunning = false; // exit the loop
            }
            else
            {
                Console.WriteLine("Invalid choice. Press any key to try again.");
                Console.ReadKey();
            }
        }
    }
}
