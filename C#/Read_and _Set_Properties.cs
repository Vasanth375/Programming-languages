using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class student
    {
        private
            int num=34;
        public int Num
        {
            //set
            //{
            //    num = value;
            //}
            get
            {
                return num;
            }
        }
         
        public student()
        {
            Console.WriteLine("Constructor called");
        }
        ~student()
        {
            Console.WriteLine("Destructor called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student obj = new student();
            //obj.Num = 12;
            //if we uncomment this line a compilation error will happen
            //its just reading the value not setting it. so it doesn't make sense to set 12 value 
            Console.WriteLine(obj.Num);
        }
    }
}
