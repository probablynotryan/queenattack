
namespace Queen.Location
{
  public class Go
  {
    public static string CheckLoc(int x, int y)
    {
      if (((x == 4) && (y >= 1) && (y <= 8)) || ((y == 1) && (x >= 1) && (x <= 8)))
      {
        return "That's a hit.";
      } 
      else if (((x == 3) && (y == 2)) || ((x == 2) && (y == 3)) || ((x == 1) && (y == 4)) || ((x == 5) && (y == 2)) || ((x == 6) && (y == 3)) || ((x == 7) && (y == 4)) || ((x == 8) && (y == 5)))
      {
        return "That's a hit also!";
      }
      else
      {
        return "That's a miss.";
      }
    }
  }
}