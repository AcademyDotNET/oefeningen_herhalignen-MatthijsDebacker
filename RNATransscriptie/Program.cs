using System;

namespace RNATransscriptie
{
    class Program
    {
        static void Main(string[] args)
        {
            string dna = "";
            string rna = "";
            char dnaN = 'G';
            char rnaN = 'C';

            do
            {
                // Welcoming message
                Console.WriteLine("Enter a DNA nucleotide, enter Q or q to quit:");

                // Check user input for empty strings
                string input = Console.ReadLine();
                if(input != string.Empty)
                {
                    dnaN = Convert.ToChar(input);
                    Console.Clear();

                    // Convert nucliotide and check its return value to proceed
                    rnaN = ConvertToRNANucliotide(dnaN);
                    if (rnaN == 'X')
                    {
                        Console.WriteLine("A valid DNA nucliotide is required.");
                    }
                    else if (rnaN != 'Q')
                    {
                        rna += rnaN;
                        dna += dnaN;

                        Console.WriteLine($"DNA: {dna}");
                        Console.WriteLine($"RNA: {rna}");
                    }
                }
                else
                {
                    Console.Clear();
                }
            } while (dnaN != 'Q' && dnaN != 'q') ;
        }

        static char ConvertToRNANucliotide(char dnaNucleotide)
        {
            switch (dnaNucleotide)
            {
                case 'G':
                    return 'C';
                case 'C':
                    return 'G';
                case 'T':
                    return 'A';
                case 'A':
                    return 'U';
                case 'Q':
                case 'q':
                    return 'Q';
                default:
                    return 'X';
            }
        }
    }
}
