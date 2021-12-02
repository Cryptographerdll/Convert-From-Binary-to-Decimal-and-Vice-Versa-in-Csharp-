using System;

namespace Decimal_To_Decimal
{
    class Program
    {
        static void method1()
        {
            int decimalNumber = Convert.ToInt32(Console.ReadLine());
            int remainder;
            string binary = string.Empty;

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                binary = remainder.ToString() + binary;
            }
            Console.WriteLine("Binary:  {0}", binary);
        }
        static void Main(string[] args)
        {
            method1();
        }
    }
}
