using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Program
{
    public class Leap_Year
    {
        public void LeapYr(int year)
        {
            Console.WriteLine("Leap Year Problem");

            if (year % 4 == 0)
            {
                Console.WriteLine("It is a Leap Year");
            }
            else
            {
                Console.WriteLine("It is Not a Leap Year");
            }
        }
    }
}
