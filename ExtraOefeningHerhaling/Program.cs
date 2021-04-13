using System;

namespace ExtraOefeningHerhaling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deel 1
            //ShowWholeNumbersFromOne(20);
            //Console.WriteLine();
            //ShowWholeNumbersToOne(20);
            //Console.WriteLine();
            //ShowEvenNumbers(1, 20);
            //Console.WriteLine();
            //ShowUnevenNumbers(1, 20);
            //Console.WriteLine();
            //SumAll(20);
            //Console.WriteLine();
            //SumAllEven(20);
            //Console.WriteLine();
            //SumAllUneven(20);
            //Console.WriteLine();
            //CountDigits(10);
            //Console.WriteLine();
            //WriteFullNumber(123456);
            //Console.WriteLine();
            //ShowAsciiTo(250);
            //Console.WriteLine();
            //ShowAlfabet();
            //Console.WriteLine();
            //Console.WriteLine(PowerTo(2, 6));
            //Console.WriteLine();
            //ShowFactors(100);
            //Console.WriteLine();
            //Console.Write(IsPrime(97));
            //Console.WriteLine();
            //ShowAllPrimeNumbersTo(100);
            //Console.WriteLine();
            //ShowFibonacciTo(15);
            //Console.WriteLine();

            // Deel 2 
            //ShowUnevenMultiplesOfThree();
            //Console.WriteLine();
            //ShowPowTOFiveFor(10);
            //Console.WriteLine();
            //ShowTablesTo(10);
            //Console.WriteLine();
            //ShowHarmonicSeries(10);
            //Console.WriteLine();
            //Console.WriteLine(LargeSumLoop(5));
            //Console.WriteLine();
            //AverageInput();
        }

        static void ShowWholeNumbersFromOne(int max)
        {
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void ShowWholeNumbersToOne(int max)
        {
            for (int i = max; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void ShowEvenNumbers(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ShowUnevenNumbers(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void SumAll(int max)
        {
            int sum = 0;
            for (int i = 1; i <= max; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }

        static void SumAllEven(int max)
        {
            int sum = 0;
            for (int i = 1; i <= max; i++)
            {
                if(i % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }

        static void SumAllUneven(int max)
        {
            int sum = 0;
            for (int i = 1; i <= max; i++)
            {
                if(i % 2 != 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }

        static void CountDigits(int number)
        {
            int digits = 1;
            int num = number;
            while(num != 1)
            {
                num /= 10;
                digits++;
            }

            Console.WriteLine($"The amount of digits in the number {number} is {digits}.");
        }

        static void WriteFullNumber(int number)
        {
            string sNumber = number.ToString();
            string name = "";
            int exponent = 0;
            int currentNumber = number;

            for (int i = 0; i < sNumber.Length; i++)
            {
                exponent = (int)Math.Pow(10, sNumber.Length - i);

                int digit = currentNumber / exponent;
                name += IntToWord(digit);
                name += " ";
                name += IntToWord(exponent);
                name += " ";

                currentNumber -= digit * exponent;
            }

            Console.WriteLine(name);
        }

        // Converts numbers with unique names into its name
        static string IntToWord(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
                case 20:
                    return "twenty";
                case 30:
                    return "thirty";
                case 40:
                    return "fourty";
                case 50:
                    return "fifty";
                case 60:
                    return "sixty";
                case 70:
                    return "seventy";
                case 80:
                    return "eighty";
                case 90:
                    return "ninety";
                case 100:
                    return "hundred";
                case 1000:
                    return "thousand";
                case 1000000:
                    return "million";
                case 1000000000:
                    return "billion";
                default:
                    return "";
            }
        }

        static void ShowAsciiTo(int max)
        {
            int indicator = 10;
            do
            {
                Console.WriteLine(Convert.ToChar(indicator));
                indicator++;
            } while (indicator <= max);
        }

        static void ShowAlfabet()
        {
            int indicator = Convert.ToInt32('a');
            do
            {
                Console.WriteLine(Convert.ToChar(indicator));
                indicator++;
            } while (indicator <= Convert.ToInt32('z'));
        }

        static int PowerTo(int number, int power)
        {
            int result = number;
            for (int i = 0; i < power-1; i++)
            {
                result *= number;
            }
            return result;
        }

        static void ShowFactors(int number)
        {
            int indicator = 1;
            while (indicator <= number)
            {
                if(number%indicator == 0)
                {
                    Console.WriteLine(indicator);
                }
                indicator++;
            }
        }

        static bool IsPrime(int number)
        {
            int indicator = 1;
            while (indicator <= number)
            {
                if(number%indicator == 0 && (indicator != 1 && indicator != number))
                {
                    return false;
                }
                indicator++;
            }

            return true;
        }

        static void ShowAllPrimeNumbersTo(int max)
        {
            int indicator = 1;
            while (indicator <= max)
            {
                if(IsPrime(indicator))
                {
                    Console.WriteLine(indicator);
                }
                indicator++;
            }
        }

        static void ShowFibonacciTo(int max)
        {
            if(max <= 0)
            {
                max = 1;
            }

            int indicator = 2;
            int lastNumber = 0;
            int currentNummber = 1;
            int nextNumber = 0;
            Console.Write($"{lastNumber}, {currentNummber}, ");

            while(indicator < max)
            {
                nextNumber = currentNummber + lastNumber;
                Console.Write($"{nextNumber}, ");
                lastNumber = currentNummber;
                currentNummber = nextNumber;
                indicator++;
            }
        }

        static void ShowUnevenMultiplesOfThree()
        {
            for (int i = 0; i <= 100; i++)
            {
                if(i%3 == 0 && i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ShowPowTOFiveFor(int number)
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(Math.Pow(number, i));
            }
        }
        static void ShowTablesTo(int max)
        {
            for (int i = 0; i <= max; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write($"{i} X {j} = {i*j}, ");
                }
                Console.WriteLine();
            }
        }

        static void ShowHarmonicSeries(int max)
        {
            double sum = 0.0;
            for (int i = 1; i <= max; i++)
            {
                double div = 1.0 / i;
                sum += div;
                if(i < max)
                {
                    Console.Write($"1/{i} + ");
                }
                else
                {
                    Console.Write($"1/{i}\n");
                }
            }

            Console.WriteLine($"Sum = {sum:F3}");
        }

        static int LargeSumLoop(int max)
        {
            int sum = 0;
            for (int i = 1; i <= max; i++)
            {
                sum += (int)Math.Pow(10, i)-1;
            }

            return sum;
        }

        static void AverageInput()
        {
            int input = 0;
            int sum = 0, index = -1;
            while (input != -1)
            {
                sum += input;
                index++;
                input = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Everage = {sum/index}");
        }

    }
}
