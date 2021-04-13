using System;

namespace TafelsVanVermenigvuldigen
{
    class Program
    {
        static void Main(string[] args)
        {
            int table = AskForInt("table");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} * {table} = {i * table}");
            }
        }

        static int AskForInt(string name)
        {
            Console.WriteLine($"Give a value for {name}: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
