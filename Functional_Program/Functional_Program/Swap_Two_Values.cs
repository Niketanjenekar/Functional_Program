using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Program
{
    public class Swap_Two_Values
    {
        public void Swapping_Values(int fVal, int sVal)
        {
            Console.WriteLine("Before Swapping, Value 1 is" + fVal);
            Console.WriteLine("Before Swapping, Value 2 is " + sVal);
            int temp = fVal;
            fVal = sVal;
            sVal = temp;
            Console.WriteLine("The Swapped Value 1 is : " + fVal);
            Console.WriteLine("The Swapped Value 2 is : " + sVal);
        }
    }
}
