// https://www.codewars.com/kata/5601409514fc93442500010b/

using System.Linq;

public class Kata
{
  public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
  {
    return (ClassPoints.Sum() / ClassPoints.Length) < YourPoints;
  }
}