using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Program
{
    public class Flip_Coin_Program
    {
        public void Flip_Coin() 
        {
            Random random = new Random();

            int heads = 0;
            int tails = 0;
            int flip = 101;
            for (int i = 0; i < 10; i++)
            {
                int result = random.Next(2);
                if (result == 0)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            double percentHeads = (double)heads / flip * 100;
            double percentTails = (double)tails / flip * 100;
            Console.WriteLine("Percentage of Heads are : " + percentHeads + " %");
            Console.WriteLine("Percentage of Tails are : " + percentTails + " %");
        }
    }
}
