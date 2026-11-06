using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Tax_Detector
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Salary = 0;

            int Bonus = 0;

            double IncomeTax = 0;

            double NetSalary = 0;

            Console.WriteLine("Enter the Salary of a Employee ");
            Salary = int.Parse(Console.ReadLine());

            if(Salary > 40000)
            {
                IncomeTax = Salary * 7;
                NetSalary = Salary - 2800;

                Console.WriteLine("The Salary of the Employee After Tax Detection is " + NetSalary);
            }

            else if(Salary > 20000 && Salary < 40000)
            {
                 IncomeTax = Salary * 5;
                 NetSalary =  Salary - 1000;

                Console.WriteLine("The Salary of the Employee After Tax Detection is " + NetSalary);
            }

            else if(Salary > 15000 && Salary < 20000)
            {
                  IncomeTax = Salary * 2;
                  NetSalary =  Salary - 300;

                  Console.WriteLine("The Salary of the Employee After Tax Detection is " + NetSalary);
            }

            else if(Salary < 15000)
            {
                  Bonus = Salary * 5;
                  NetSalary =  Salary + 750;

                  Console.WriteLine("The Salary of the Employee After Tax Detection is " + NetSalary);
            }

            else
            {
                Console.WriteLine("Invalid Wrong Operation");
            }
        }
    }
}
