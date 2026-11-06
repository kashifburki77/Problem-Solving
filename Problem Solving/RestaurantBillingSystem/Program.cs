using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBillingSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            double OrderAmount = 0;
            double DiscountAmount = 0;
            double FinalBillAmount = 0;

            Console.WriteLine("Enter the Original Amount");
            OrderAmount = int.Parse(Console.ReadLine());

            if(OrderAmount > 5000)
            {
                DiscountAmount = OrderAmount * 15; 
                FinalBillAmount = OrderAmount - 750.15;

                Console.WriteLine("The Total Order Amount is " + FinalBillAmount);
            }

            else if(OrderAmount > 3000)
            {
                 DiscountAmount = OrderAmount * 10;
                 FinalBillAmount = OrderAmount - 300.1;

                Console.WriteLine("The Totol Order Amount is " + FinalBillAmount);
            }

            else if(OrderAmount > 1000)
            {
                 DiscountAmount = OrderAmount * 5;
                 FinalBillAmount = OrderAmount - 50;

                 Console.WriteLine("The Total Order Amount is " + FinalBillAmount);
            }           

            else if(OrderAmount <= 1000)
            {
                  FinalBillAmount = OrderAmount;

                  Console.WriteLine("The Total Order Amount is " + FinalBillAmount);
            }

            else if(OrderAmount > 4000)
            {
                  DiscountAmount = OrderAmount * 20 ;
                  FinalBillAmount = OrderAmount - 800;

                  Console.WriteLine("The Total Order Amount is " + FinalBillAmount);
                    
            }

            else
            {
                Console.WriteLine("Invalid Operation");
            }

            
        }
    }
}
