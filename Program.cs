using System;

namespace Decimal_To_Binary_Vice_Versa
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Write an app that inputs an integer containing only 0s and 1s (i.e., a binary integer) and displays its decimal equivalent. 
               [Hint: In the decimal number system, the rightmost digit has a positional value of 1 and the next digit to the left has a positional value of 10, then 100, then 1000 and so on. 
               The decimal number 234 can be interpreted as 4 * 1 + 3 * 10 + 2 * 100.
               In the binary number system, the rightmost digit has a positional value of 1, the next digit to the left has a positional value of 2,
               then 4, then 8 and so on. The decimal equivalent of binary 1101 is 1 * 1 + 0 * 2 + 1 * 4 + 1 * 8, or 1 + 0 + 4 + 8, or 13.]
             */

            string Number_Input;
            int Decimal = 0;
            int Binary = 0;
            int index = 0;
            int Multiplier = 1;

            Console.WriteLine("Please enter a number you want to convert it to binary or vice versa");
            Number_Input = Console.ReadLine();

            index = Number_Input.Length; // Length of the user input .

            // This is for decimal Operation .

            while (index > 0)
            {
                Binary = Convert.ToInt32(Number_Input.Substring(index - 1, 1));
                Decimal += Binary * Multiplier;
                index--;
                Multiplier *= 2;
            }
            Console.WriteLine("the decimal of {0} is: {1:N0}", Number_Input, Decimal);
            Console.ReadLine();

            // This is for the Binary operation .


        }
    }
}
