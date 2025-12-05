using System;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Level level = new Level("First level", player);
        level.StartLevel();
    }
}