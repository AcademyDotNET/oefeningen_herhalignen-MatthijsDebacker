using System;

namespace EulerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }

            Console.WriteLine($"The sum of all plurals of 3 and 5 between 0 and 1000 is {total}.");
        }
    }
}
