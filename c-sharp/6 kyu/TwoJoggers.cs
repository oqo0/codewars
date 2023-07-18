// https://www.codewars.com/kata/5274d9d3ebc3030802000165/

using System;

public class Kata
{
  public static Tuple<int, int> NbrOfLaps(int x, int y)
  {
    int greatestDivisor = FindGreatestDivisor(x, y);
    
    while (greatestDivisor > 1)
    {
      x /= greatestDivisor;
      y /= greatestDivisor;
      
      greatestDivisor = FindGreatestDivisor(x, y);
    }
    
    return new Tuple<int, int>(y, x);
  }
  
  // Euclidean algorithm
  private static int FindGreatestDivisor(int a, int b)
  {
    while (a != 0 && b != 0)
    {
      if (a > b)
        a %= b;
      else
        b %= a;
    }

    return a | b;
  }
}