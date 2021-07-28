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
            int num;
        public int Num
        {
            set
            {
                num = value;
            }
            //get
            //{
            //    return num;
            //}
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
            obj.Num = 12;
            //Console.WriteLine(obj.Num);
            //if we uncomment this line a compilation error will happen
            //because, its performing illegel proccess, that means it performing setting property
            //before it reading that. Thats why it gets error when we try to display it 
            //we didn't reading the variable then how we can display it.
        }
    }
}
