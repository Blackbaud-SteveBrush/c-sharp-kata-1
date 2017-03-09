using System;

namespace Kata1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The use of 'var' is a more flexible approach to setting variables, 
            // in case the type returned from the method changes in the future.
            var player = new Player("Lindsey", "Rix");

            // String interpolation is now the recommended way to concatenate strings:
            Console.WriteLine($"Hello, {player.GetFullName()}!");
        }
    }
}
