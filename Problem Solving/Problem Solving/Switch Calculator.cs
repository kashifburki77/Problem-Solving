using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Write a program that Calculates 2 numbers for ( Sum, Subtract, Div, Multiply)
             * using Switch */

            double a = 2;
            double b = 3;

            char operation1 = '+';
            char operation2 = '-';
            char operation3 = '/';
            char operation4 = '*';


            switch(operation1)
            {
                case '+':
                    Console.WriteLine(a + b);
                    break;

            }

            switch(operation2)
            {
                case '-':
                    Console.WriteLine(a - b);
                    break;
            }

            switch(operation3)
            {
                case '/':
                    Console.WriteLine(a / b);
                    break;
            }

            switch(operation4)
            {
                case '*':
                    Console.WriteLine(a * b);
                    break;

                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }
        }
    }
}
