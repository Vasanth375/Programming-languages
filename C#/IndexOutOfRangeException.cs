using System;
namespace ConsoleApplication7
{
    class main
    {
        static void Main()
        {
            int[] array = new int[5];
            //array declaration and creation
            int n = array.Length;
            //getting length of an array using Length property

            for(int i=0;i<8;i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
