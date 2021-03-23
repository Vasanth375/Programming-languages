using System;

using System.Collections.Generic;

using System.Linq;

using System.Text.RegularExpressions;

 // Compiler version 4.0, .NET Framework 4.5

 namespace Dcoder

 {

    class Car

   {//class 1

       public string name;     //public specifier

       public int id;          //public 

       public void Man()       //public method

       {

         Console.WriteLine(name+" "+id);

       }

   }//end of class 1

   

   class con

   {//class 2

     static void Main()

     {//main method

       Car obj=new Car();      //creating obj

       obj. name="vasanth";    //inserting string

       obj.id=68;           //inserting integer

       obj. Man();         //calling using object

     }

   }//end of class 2

   

  /* class of

   {//experimental class

     void the

     {

       /*The object scope is within the class 

        only it is not acceptable to use 

        outside of the class*

       obj.Man();

       //Error!!

     }

   }*/

}//end of namespace 
