using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Program
{
    public class Largest_Of_Three
    {
        public void Largest(int firstVal, int secondVal, int thirdVal)
        {
            if (firstVal > secondVal && firstVal > thirdVal)
            {
                Console.WriteLine("The First Number " + firstVal + " is Greatest Number");
            }
            else if (secondVal > thirdVal && secondVal > firstVal)
            {
                Console.WriteLine("The Second Number " + secondVal + " is Greatest Number");
            }
            else if (thirdVal > firstVal && thirdVal > secondVal)
            {
                Console.WriteLine("The Third Number " + thirdVal + " is the Greatest Number");
            }
            else
            {
                Console.WriteLine("Please Enter the Valid Numbers to Compare");
            }
        }
    }
}
