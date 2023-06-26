using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Program
{
    public class Factors_Of_Numbers
    {
        public void Factors(int num)
        {
            for (int i = 2; i * i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.Write(i + " ");
                    num /= i;
                }
            }

            if (num > 1)
            {
                Console.Write(num + " ");
            }
        }
    }
}
