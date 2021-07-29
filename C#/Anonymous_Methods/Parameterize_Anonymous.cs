using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    class Program
    {
        //normal delegate creation
        public delegate void gate(int x);

        static void fun(gate g,int x)
        {
            //calling anonymous method
            g(x);
        }

        static void Main(string[] args)
        {
            //creating anonymous method
            //delegate_name object = delegate(){  };
            gate GATE = delegate(int a)
            {
                Console.WriteLine("Anonymous method called");
                a += 1;
                a *= a;
                Console.WriteLine(a);
            };
            fun(GATE, 2);
        }
    }
}
