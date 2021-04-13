using System;

namespace BoekHouder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialise all relevant variables
            double posSum = 0, negSum = 0, total = 0, average = 0;
            int index = 0;

            do
            {
                // Ask for input and check if it is a valid whole number
                Console.WriteLine("Enter a number:");
                double iNumber = 0;

                string sNumber = Console.ReadLine();
                while (!double.TryParse(sNumber, out iNumber))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid number, please try again.");
                    sNumber = Console.ReadLine();
                }

                // Calculate all variables
                index++;
                if(iNumber >= 0)
                {
                    posSum += iNumber;
                }
                else if(iNumber < 0)
                {
                    negSum += iNumber;
                }

                total += iNumber;
                average = total / index;

                // Clear console and show current values
                Console.Clear();
                Console.WriteLine($"The total value is: {total}.");
                Console.WriteLine($"The total of all positive entries is: {posSum}.");
                Console.WriteLine($"The total of all negative entries is: {negSum}.");
                Console.WriteLine($"The average entry is:{average}.");

                // End the loop after 1000 entries
            } while (index <= 1000);

        }
    }
}
