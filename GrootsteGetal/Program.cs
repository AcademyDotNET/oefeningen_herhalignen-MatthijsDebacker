using System;

namespace GrootsteGetal
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int largest = 0;
            do
            {
                y += x;
                Console.WriteLine("Voer gehele waarden in (32767 = stop)");

                string inString = Console.ReadLine();
                x = Convert.ToInt32(inString);
                
                if (x >= largest)
                {
                    largest = x;
                }
                Console.WriteLine($"De grootste waarde die ingegeven werd is {largest}.");

            } while (x != 32767);
            Console.WriteLine($"De som is {y}.");
        }
    }
}
