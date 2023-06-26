using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Program
{
    public class Quotient_Remainder
    {
        public void Quotient_And_Remainder(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("The Quotient is : " + quotient);
            Console.WriteLine("The Remainder is : " + remainder);
        }
    }
}
