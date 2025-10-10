class Menu
{
    public void Display()
    {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }

    public int userInput()
    {
        Console.Write("What would you like to do? ");
        int input = int.Parse(Console.ReadLine());
        return input;
    }
}