using System.Diagnostics.Contracts;

namespace Till;

class Program
{
    static void Main(string[] args)
    {
        Bin twentyBin = new Bin("Twenties", 20.00, 5);
        Bin tenBin = new Bin("Ten", 10.00, 10);
        Bin pennyBin = new Bin("Penny", 0.01, 50);

        pennyBin.Alter(11);
        Console.WriteLine(pennyBin.GetDemonination());
        Console.WriteLine(pennyBin.GetCount());
    }
}
