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

                default:
                    Console.WriteLine("Please Enter the Correct Option : ");
                    break;
            }

            Console.ReadLine() ;
        }
    }
}
