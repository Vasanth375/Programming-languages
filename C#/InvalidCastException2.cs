using System;
namespace Program
{
  class main
  {
    static void Main()
    {
      bool flag = true;
      try
      {
        Char ch = Convert.ToChar(flag);
        Console.WriteLine("Conversion succeeded.");
      }
      catch (InvalidCastException e)
      {
        Console.WriteLine("Cannot convert a Boolean to a Char." + e.Message);
      }

      Console.ReadKey();
    }
  }
}
