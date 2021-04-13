using System;

namespace ForDoordenkerExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for input and check if it is a valid whole number
            Console.WriteLine("Enter a whole number:");
            int height = 0;

            string sInput = Console.ReadLine();
            while (!int.TryParse(sInput, out height))
            {
                Console.Clear();
                Console.WriteLine("Invalid number, please try again.");
                sInput = Console.ReadLine();
            }

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(new string(' ', height - i) + new string('*', i * 2 + 1));
            }
        }
    }
}
