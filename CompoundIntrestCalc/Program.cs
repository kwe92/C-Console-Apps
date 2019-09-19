using static System.Console;
using static System.Math;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompoundInterestCalc
{
    class Interest
    {

        static double CompoundInterest(double amount, double rate, double numberOfYears = 1)
        {
            return Round(amount * Pow(rate + 1, numberOfYears) - amount, 2);

        }

        static void Main(string[] args)
        {

            double result1;
            double result2;
            double result3;

            WriteLine("Enter amount invested");
            string s1 = ReadLine();

            while (double.TryParse(s1, out result1) == false)
            {
                WriteLine($"{s1} is not a number, please enter a valid amount.");
                s1 = ReadLine();
            }

            WriteLine("Enter rate, example 0.05 = 5%.");
            string s2 = ReadLine();

            while (double.TryParse(s2, out result2) == false || result2 > 1)
            {
                if (result2 > 1)
                {
                    WriteLine("rate can not exceed 1 (100%), example 0.05 = 5%, please enter a valid rate.");
                    s2 = ReadLine();
                }
                else if (double.TryParse(s2, out result2) == false)
                {
                    WriteLine($"{s2} is not a number, please enter a valid rate.");
                    s2 = ReadLine();
                }
                else;

            }

            WriteLine("Enter years invested");
            string s3 = ReadLine();

            while (double.TryParse(s3, out result3) == false)
            {
                WriteLine($"{s3} is not a number, Please enter a valid number of years.");
                s3 = ReadLine();
            }

            WriteLine(CompoundInterest(result1, result2, result3));
        }
    }
}
