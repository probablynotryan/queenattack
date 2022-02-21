using System;
using System.Collections.Generic;
using Queen.Location;

namespace Program
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter an X coordinate: ");
      int x = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a Y coordinate: ");
      int y = int.Parse(Console.ReadLine());
      Console.WriteLine(Go.CheckLoc(x, y));
    }
  }
}