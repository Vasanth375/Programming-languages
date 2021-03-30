/* write c# on multilevel inheritance and
   protected access specifier*/
     
using System;
namespace ConsoleApplication7
{
    class Android1    //Base class
    { 
      protected void feature1()  
      {
        Console.WriteLine("Andriod1 feature1");
      } 
    } 

    class Android2:Android1  //subclass inheritance
    { 
      protected void feature2() 
      { 
        Console.WriteLine("Andriod2 feature2 ");
      } 
    }
     
    class Mobile:Android2   //second subclass
    {
        static void Main()
        {
            // creating object
            Mobile B = new Mobile();
            
            //calling method of Base class
            B.feature1();
            
            //Calling method of sub class
            B.feature2();
        }
    }
}
/*-------------------------–--------------------------
  |Multilevel inheritance : In c# inheritance means   |
  |a class can inhert from another base class.        |
  |In multilevel, inheritance allows transitive and it|
  |allows you to define hierarchical inheritance.     |
  -----------------------------------------------------
  -----------------------------------------------------
  |Protected access specifier : Its scope is within   |
  |Class and inherited class itself,its doesn't have  |
  |to access other class which is not inherited.      |
  -----------------------------------------------------
*/
