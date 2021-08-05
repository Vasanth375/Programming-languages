using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxing value type to object type
            string a = "vasanth";
            a = "Hello " + a;
            Console.WriteLine("String value is " + a);
            Console.WriteLine(a.GetType());
            
            //unboxing object type to value type 
            object n = a;
            Console.WriteLine(n.GetType());
            Console.WriteLine("\n\n");
            object b = 12;
            Console.WriteLine("object before unboxing"+b.GetType());

            int num = Convert.ToInt32(b);
            Console.WriteLine("num datatype "+num.GetType());
            Console.WriteLine("object after unboxing"+b.GetType());
        }
    }
}

