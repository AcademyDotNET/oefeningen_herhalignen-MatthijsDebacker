using System;

namespace ForDoordenker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for input and check if it is a valid whole number
            Console.WriteLine("Enter a whole number:");
            int width = 0;

            string sInput = Console.ReadLine();
            while(!int.TryParse(sInput, out width))
            {
                Console.Clear();
                Console.WriteLine("Invalid number, please try again.");
                sInput = Console.ReadLine();
            }

            for (int i = 1; i < width*2; i++)
            {
                int j = width * 2 - i;
                if (j > width)
                {
                    Console.WriteLine(new string('*', i));
                }
                else
                {
                    Console.WriteLine(new string('*', j));
                }
            }
        }
    }
}
