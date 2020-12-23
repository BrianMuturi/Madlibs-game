using System;

namespace Madlibs_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Color:");
            string color = Console.ReadLine();
            Console.Write("Plural noun:");
            string noun = Console.ReadLine();
            Console.Write("Celebrity:");
            string celebrity = Console.ReadLine();
            Console.WriteLine("Roses are "+ color);
            Console.WriteLine(noun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();
        }
    }
}
