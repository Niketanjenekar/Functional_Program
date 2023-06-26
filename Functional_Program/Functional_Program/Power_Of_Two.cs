using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Program
{
    public class Power_Of_Two
    {
        public void PowerofTwo(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                double product = Math.Pow(2, i);
                Console.WriteLine("The 2 to the Power of " + i + " is equal to :" + product);
            }
        }
    }
}
