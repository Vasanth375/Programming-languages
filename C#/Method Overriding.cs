/*Sample example
  program of function overriding or Dynamic (run time)
  Polymorphism*/

using System;

namespace ConsoleApplication7
{
class Andriod1      //base class
{ 
  public void feature()
  {
    Console.WriteLine("Andriod1 feature1");
  } 
} 

class Andriod2:Andriod1  //sub class inheritance
{ 
  public void feature()   //over riden method
   {
      Console.WriteLine("Andriod2 feature2");
      
      //calling base class method
      base.feature();
   } 
}

class Mobile
{
   static void Main()
   {
      //creating object
      Andriod2 M=new Andriod2();
      
      //calling overridden method
      M.feature();

    }
}
}
