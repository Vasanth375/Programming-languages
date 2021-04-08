using System;using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5

 namespace Dcoder
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       //jagged array declaration
       int[][] arr= new int[][]
       {
              new int[]{10,20},
              new int[]{100,200,300},
              new int[]{10,20,30,40},
              new int[]{1},
              new int[]{0}
       };
       
       //array size is 5
       //Row highest size is 3
       int i,j;
       
       //printing array size
       Console.WriteLine("length of actual array {0} ",arr.Length);
       //prints 5 because no of columns are 5
       
       for( i=0;i<arr.Length;i++)
       {
         
         int len=arr[i].Length;
         //assigning each row length to len variable
         
         for( j=0;j<len;j++)
         {
           
           Console.Write("{0} ",arr[i][j]);
           
         }
         
         Console.WriteLine("");
         //takes new line
       }
     }
   }
 }
