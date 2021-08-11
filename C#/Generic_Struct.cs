using System;
using System.Collections.Generic;
namespace Dcoder
{
    struct Book<T>//structure creation and defination and its generic struct
    {
        public T X, Y, Z;
        public Book(T x, T y, T z)///struct constructor
        {
            X = x;
            Y = y;
            Z = z;
        }
    };
    class Derived
    {  
        static void Main(string[] args)
        {
            Book<int> book = new Book<int>(1, 2, 3);//passing values and data type as arguments
            Console.WriteLine(book.X);
            Console.WriteLine("Method executed");
        }
    }
}
