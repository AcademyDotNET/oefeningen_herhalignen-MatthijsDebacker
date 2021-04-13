using System;

namespace ArmstrongNummer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for input and check if it is a valid whole number
            Console.WriteLine("Enter a whole number:");
            int iNumber = 0;

            string sNumber = Console.ReadLine();
            while (!int.TryParse(sNumber, out iNumber))
            {
                Console.Clear();
                Console.WriteLine("Invalid number, please try again.");
                sNumber = Console.ReadLine();
            }

            // Initialise required variables
            int currentNumber = iNumber;
            int armstrongNumber = 0;

            // Loop through the number and perform armstrong calculations
            for (int i = 0; i < sNumber.Length; i++)
            {
                int multiplier = (int)Math.Pow(10, sNumber.Length - i - 1);
                int remainder = currentNumber / multiplier;
                currentNumber -= remainder * multiplier;
                armstrongNumber += (int)Math.Pow(remainder, sNumber.Length);
            }

            // Check with the initial number and respond accordingly
            Console.WriteLine($"Number: {iNumber} <==> \"Armstrong\"Number {armstrongNumber}");
            if(iNumber == armstrongNumber)
            {
                Console.WriteLine("This is an armstrong number!");
            }
            else
            {
                Console.WriteLine("This is not an armstrong number!");
            }
        }
    }
}
