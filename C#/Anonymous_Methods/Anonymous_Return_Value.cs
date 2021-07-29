ystem;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    class Program
    {
        //normal integer delegate creation
        public delegate int gate();

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
                return a;
            };
            int b=GATE();
            Console.WriteLine(b);
        }
    }
}
