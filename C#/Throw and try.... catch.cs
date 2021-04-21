using System;

namespace UserDefinedException
{
   class Program : Exception
//To throw user defined exception 
//we need to inherit Exception class to a class
  
   {
      
      Program(int p)
      {
        Console.WriteLine("error you can't fit "+p);
      }
      
      static void Main(string[] args) 
      {
        int point=5;
        for(point=0; point<7; point++)
        {
         try 
         {
           
           if(point > 4) 
           {
               throw new Program(point);
               //passing point variable to Program()constructor to
               //know in which iteration it gets error

          //when exception raises it goes throw and catch block
         //first it goes throw constructor and then catch block
           } 
           else 
           {
               Console.WriteLine("passed the fitness test! "+point);
           }
         } 
         catch
         {
            Console.WriteLine("User can't fit "+point);
         }
       }
         Console.ReadKey();
      }
   }
}
