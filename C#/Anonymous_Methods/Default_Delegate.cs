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
        public delegate void gate();

        static void Main(string[] args)
        {
            //creating anonymous method
            //delegate_name object = delegate(){  };
            gate GATE = delegate()
            {
                int a = 1;
                Console.WriteLine("Anonymous method called");
                a += 1;
                a *= a;
                Console.WriteLine(a);
            };
            GATE();
        }
    }
}
