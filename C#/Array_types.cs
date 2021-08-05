using System;

namespace Practise
{
    class Program
    {
        
        static void Main(string[] args)
        {

            int[] data = new int[3];//one dimensional array
            Console.WriteLine("Enter the array");
            for (int i=0;i<3;i++)
            {
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("OneD array");
            foreach(int i in data)
            {
                Console.WriteLine(i);
            }
         
            int[,] twod = new int[3,3];
            Console.WriteLine("Enter the two d array..");
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    twod[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Two D array......");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(twod[i, j]);
                }
            }

           //jagged array not learned //5-8-21//
        }
    }
}

