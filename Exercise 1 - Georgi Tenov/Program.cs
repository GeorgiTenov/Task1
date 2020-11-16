using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___Georgi_Tenov
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = IsValidExpression("Abba");
            Console.ReadKey();
        }

        private static bool IsValidExpression(string expression)
        {
            var charArray = expression.ToCharArray();

            if (!IsInvalidExpression(expression))
            {
                if (char.IsUpper(charArray[0])
                    && char.IsLower(charArray[charArray.Length - 1]))
                {
                    return true;
                }
            }
          
            return false;
        }


        //Method to check whether there is  a word different than the task requirment
        private static bool IsInvalidExpression(string expression)
        {
            string invalidChars = "D dE eF fG gH hI iJ jK kL lM mN nO oP pQ qR rS sT tU uV vW wX xY yZ z";

            char[] invalidCharsArray = invalidChars.ToCharArray();

            foreach(var invalidChar in invalidCharsArray)
            {
                if (expression.Contains(invalidChar))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
