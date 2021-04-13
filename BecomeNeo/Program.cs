using System;

namespace BecomeNeo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rangen = new Random();

            // Lower and higher empty threshold determines within what range the characters get ignored
            int let = 75;
            int het = 350;

            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                //Genereer nieuw random teken:
                int next = rangen.Next(62, 400);
                if(next < let || next > het)
                {
                    char teken = Convert.ToChar(next);
                    //Zet teken op scherm
                   Console.Write(teken);
                }
                else
                {
                    Console.Write(' ');
                }

                //Ietwat vertragen
                System.Threading.Thread.Sleep(0); //dit getal is in milliseconden. Speel er gerust mee.

                //Af en toe een ander kleurtje
                Console.ForegroundColor = (ConsoleColor)rangen.Next(0, 16);
            }
        }
    }
}
