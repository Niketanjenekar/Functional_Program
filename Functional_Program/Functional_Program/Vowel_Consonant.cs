using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Program
{
    public class Vowel_Consonant
    {
        public void Vowel_Or_Consonant(char alph)
        {
            if (alph == 'A' || alph == 'E' || alph == 'I' || alph == 'O' || alph == 'U' ||
                alph == 'a' || alph == 'e' || alph == 'i' || alph == 'o' || alph == 'u')
            {
                Console.WriteLine("The Alphabet is a Vowel");
            }
            else
            {
                Console.WriteLine("The Alphabet is a Consonant");
            }
        }
    }
}
