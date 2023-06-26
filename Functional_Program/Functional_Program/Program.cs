using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****************Functional Programs*****************");

            //*****************Day - 5 Assignments********************

            Console.WriteLine("Welcome to Functional Programs :- ");

            Console.WriteLine("Please select an option for the program to Execute");

            Console.WriteLine("1. Flip Coin And Print Percentage");
            Console.WriteLine("2. Leap Year");
            Console.WriteLine("3. Power of 2");
            Console.WriteLine("4. Harmonic Number");
            Console.WriteLine("5. Factors");
            Console.WriteLine("6. Quotient and Remainder");
            Console.WriteLine("7. Swap Two Numbers");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //First Problem
                    Console.WriteLine("Please Press Enter to Flip a Coin");
                    Console.ReadLine();
                    Flip_Coin_Program flip_Coin = new Flip_Coin_Program();
                    flip_Coin.Flip_Coin();
                    break;

                case 2:
                    //Second Problem
                    Console.WriteLine("Please Enter the Year");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Leap_Year leap_Year = new Leap_Year();
                    leap_Year.LeapYr(year);
                    break;

                case 3:
                    //Third Problem
                    Console.WriteLine("Please Enter the Value to find the Power of Two");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Power_Of_Two power = new Power_Of_Two();
                    power.PowerofTwo(number);
                    break;

                case 4:
                    //Fourth Problem
                    Console.WriteLine("Please Enter the Number to Find the Harmonic Value");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Harmonic_Number harmonic = new Harmonic_Number();
                    harmonic.Harmonic_Number_Prog(num);
                    break;

                case 5:
                    //Fifth Problem
                    Console.WriteLine("Please Enter the Number to Find the Factors of Numbers");
                    int numTwo = Convert.ToInt32(Console.ReadLine());
                    Factors_Of_Numbers factors_Of_Numbers = new Factors_Of_Numbers();
                    factors_Of_Numbers.Factors(numTwo);
                    break;

                case 6:
                    //Sixth Problem
                    Console.WriteLine("Quotient and Remainder Program");
                    Console.WriteLine("Enter the Dividend Value: ");
                    int dividend = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Divisor Value: ");
                    int divisor = Convert.ToInt32(Console.ReadLine());
                    Quotient_Remainder quotient_Remainder = new Quotient_Remainder();
                    quotient_Remainder.Quotient_And_Remainder(dividend, divisor);
                    break;

                case 7:
                    //Seventh Problem
                    Console.WriteLine("Swapping Two Values Program");
                    Console.WriteLine("Enter the First Value: ");
                    int fVal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Second Value: ");
                    int sVal = Convert.ToInt32(Console.ReadLine());
                    Swap_Two_Values swap_Two_Values = new Swap_Two_Values();
                    swap_Two_Values.Swapping_Values(fVal, sVal);
                    break;

                default:
                    Console.WriteLine("Please Enter the Correct Option : ");
                    break;
            }

            Console.ReadLine() ;
        }
    }
}
