using System;

namespace Beersong
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 100;
            int nrOfBottles = 0;

            while (nrOfBottles < max)
            {
                if(max - nrOfBottles != 1)
                {
                    Console.WriteLine($"{max - nrOfBottles} bottles of beer on the wall, {max - nrOfBottles} bottles of beer.");
                }
                else
                {
                    Console.WriteLine($"{max - nrOfBottles} bottle of beer on the wall, {max - nrOfBottles} bottle of beer.");
                }
                
                if(max - nrOfBottles - 1 > 1)
                {
                    Console.WriteLine($"Take one down and pass it around, {max - nrOfBottles - 1} bottles of beer on the wall.");
                }
                else if( max - nrOfBottles - 1 == 1)
                {
                    Console.WriteLine($"Take one down and pass it around, {max - nrOfBottles - 1} bottle of beer on the wall.");
                }
                else if (max - nrOfBottles - 1 == 0)
                {
                    Console.WriteLine("Take it down and pass it around, no more bottles of beer on the wall.");
                }
                Console.WriteLine();
                nrOfBottles++;
            }

            Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer.");
            Console.WriteLine("Go to the store and buy some more, 99 bottles of beer on the wall.");
        }
    }
}
