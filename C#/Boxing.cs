using System;

 // Compiler version 4.0, .NET Framework 4.5

 namespace Dcoder

 {

   class Program

   {

     static void Main()

     {

       int number=12;//declaring int

       object obj1;//object type

       obj1=(object)number;//explicit boxing

       Console.WriteLine(obj1.GetType());
/* boxing is nothing but converting value type
to object type*/
     }

   }

 }

