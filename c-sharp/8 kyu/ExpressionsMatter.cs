// https://www.codewars.com/kata/5ae62fcf252e66d44d00008e/

using System.Linq;

public class Kata
{
  public static int ExpressionsMatter(params int[] n)
  { 
    int[] exp = new int[]
    {
      n[0] + n[1] + n[2],
      n[0] * n[1] + n[2],
      n[0] + n[1] * n[2],
      n[0] * n[1] * n[2],
      (n[0] * n[1]) + n[2],
      n[0] * (n[1] + n[2]),
      (n[0] + n[1]) * n[2],
      n[0] + (n[1] * n[2]),
    };
    
    return exp.Max();
  }
}