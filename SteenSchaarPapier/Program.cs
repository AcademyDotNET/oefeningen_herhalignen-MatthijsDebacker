using System;

namespace SteenSchaarPapier
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0, pcScore = 0;
            Random rand = new Random();

            while(playerScore < 10 && pcScore < 10)
            {
                Console.WriteLine("Papier, steen of schaar?");
                string input = Console.ReadLine().ToLower();
                Console.Clear();

                int pcGuess = rand.Next(0, 3);
                int point = DeterminePoint(pcGuess, input);
                if (point > 0)
                {
                    playerScore++;
                    Console.WriteLine("De speler wint deze ronde!");
                }
                else if (point < 0)
                {
                    pcScore++;
                    Console.WriteLine("De pc wint deze ronde!");
                }
                else
                {
                    Console.WriteLine("Niemand won deze ronde.");
                }

                Console.WriteLine($"De huidige stand is: {playerScore} punten voor de speler, {pcScore} punten voor de pc.");
            }

            Console.Clear();
            if(playerScore > pcScore)
            {
                Console.WriteLine("De speler heeft gewonnen!");
            }
            else
            {
                Console.WriteLine("De pc heeft gewonnen!");
            }
            Console.WriteLine($"De einscore: {playerScore} punten voor de speler, {pcScore} punten voor de pc.");


        }

        // For pc 0 = papier, 1 = steen and 2 = schaar
        // If player wins return 1, if pc wins return -1 else return 0
        // If niether enters a valid option, no one gains points / return 0
        static int DeterminePoint(int pc, string player)
        {
            switch (pc)
            {
                case 0:
                    switch (player)
                    {
                        case "papier":
                            return 0;
                        case "steen":
                            return -1;
                        case "schaar":
                            return 1;
                        default:
                            return 0;
                    }
                case 1:
                    switch (player)
                    {
                        case "papier":
                            return 1;
                        case "steen":
                            return 0;
                        case "schaar":
                            return -1;
                        default:
                            return 0;
                    }
                case 2:
                    switch (player)
                    {
                        case "papier":
                            return -1;
                        case "steen":
                            return 1;
                        case "schaar":
                            return 0;
                        default:
                            return 0;
                    }
                default:
                    return 0;
            }
        }
    }
}
