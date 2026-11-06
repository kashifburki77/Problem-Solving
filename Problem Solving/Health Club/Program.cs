using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Club
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Health Club Using Switch Case */

            char StandardAdultMemberShip = '1';
            char ChildMembership = '2';
            char SeniorCitizen = '3';
            char SeniorArchitect = '4';
            char SeniorArchitectPlus = '5';
            char MiddleLevelEngineer = '6';

            switch(StandardAdultMemberShip)
            {
                case '1':
                    Console.WriteLine("The Standard Adult Membership is $40 Per Month");
                    break;

                case '2':
                    Console.WriteLine("The Child Membership is $20 Per Month");
                    break;

                case '3':
                    Console.WriteLine("The Senior Citizen Membership is $30 Per Month");
                    break;

                case '4':
                    Console.WriteLine("The Senior Architect Membership is $50 Per Month");
                    break;

                case '5':
                    Console.WriteLine("The Senior Architect Plus Membership is $60 Per Month");
                    break;

                case '6':
                    Console.WriteLine("The Middle Level Engineer Membership is $70 Per Month");
                    break;

                  default:
                     Console.WriteLine("There is no Membership for this Category");
                     break;


            }

        }
    }
}
