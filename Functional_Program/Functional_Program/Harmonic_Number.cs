using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Program
{
    public class Harmonic_Number
    {
        public void Harmonic_Number_Prog(int n)
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += 1 + 1 / i;
            }
            Console.WriteLine("The " + n + "th Harmonic Value is " + result);
        }
    }
}
