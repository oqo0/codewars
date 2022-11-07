// https://www.codewars.com/kata/515e271a311df0350d00000f/

using System.Linq;

public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    return numbers.Select(x => x * x).Sum();
  }
}