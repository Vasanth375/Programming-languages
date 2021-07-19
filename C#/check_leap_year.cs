using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a year to check if it is leap year or not");
            int year = Convert.ToInt32(Console.ReadLine());

            //any year which is divisible by 4 is zero then year is leap year
            if(year%4==0)
            {
                Console.WriteLine("Yes, year is leap year");
            }
            else
            {
                Console.WriteLine("Oops!!, year is not leap year");
            }
        }
    }
}
