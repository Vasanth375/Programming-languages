using System;

namespace Program
{
  class Program1
  {
    static void Main()
    {
            Console.WriteLine("enter a number to generate random number ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            Console.WriteLine(random.Next(0, n)+" is Random number from "+0+" to "+n);
            Console.ReadKey();
     }
   }
}
