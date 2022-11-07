// https://www.codewars.com/kata/542c0f198e077084c0000c2e/

using System.Linq;

public class Kata
{
  public static int Divisors(int n)
  {
    return Enumerable.Range(1, n + 1).Count(x => n % x == 0);
  }
}