using System;

namespace CodingProblem1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] testArray = new int[] { 1, 30, 2, 360, 16, 120 };

                // Get the 2nd highest from our testArray;
                int nthHighest = 2;

                // Use our class method to get nth highest (in this case the 2nd highest).
                var highestNumber = new HighestNumber();
                var result = highestNumber.Get(testArray, nthHighest);

                // Output the result.
                Console.WriteLine($"The 2nd highest is {result}.");
            }
            catch
            {
                Console.WriteLine("An error was encountered.");
            }

            Console.ReadKey();
        }

    }
}
