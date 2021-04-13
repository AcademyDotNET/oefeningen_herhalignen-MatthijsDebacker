using System;

namespace RaadHetGetal
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            int poging = 0;
            int aantalPogingen = 0;
            int maxAantalPogingen = 0;
            int onderGrens = 0, bovenGrens = 100;
            string pogingString;
            bool gevonden = false;
            Random rand = new Random();
            getal = rand.Next(onderGrens, bovenGrens);

            int midden = bovenGrens;
            while (midden > 1)
            {
                midden /= 2;
                maxAantalPogingen++;
            }

            while (aantalPogingen < maxAantalPogingen && !gevonden)
            {
                aantalPogingen++;
                Console.WriteLine($"Geef een getal tussen {onderGrens} en {bovenGrens}");
                pogingString = Console.ReadLine();
                poging = int.Parse(pogingString);

                if(poging <= onderGrens || poging >= bovenGrens)
                {
                    Console.WriteLine("Deze waarde ligt niet binnen het huidige interval, probeer opnieuw.");
                }
                else if (getal > poging)
                {
                    onderGrens = poging;
                    Console.WriteLine("Het gezochte getal is groter, probeer opnieuw.");
                }
                else if (getal < poging)
                {
                    bovenGrens = poging;
                    Console.WriteLine("Het gezochte getal is kleiner, probeer opnieuw.");
                }
                else
                    gevonden = true;

                Console.WriteLine($"Het resterende interval is nu: {onderGrens} tot {bovenGrens}");
            }

            if (gevonden)
            {
                Console.WriteLine($"Gevonden! Het te zoeken getal was inderdaad {getal} je had er {aantalPogingen} pogingen voor nodig.");
            }
            else
            {
                Console.WriteLine($"Het maxiamaal aantal pogingen is bereikt, het getal was {getal}.");
            }
        }
    }
}
