// https://www.codewars.com/kata/5715eaedb436cf5606000381/

using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    return arr.Where(x => x > 0).Sum();
  }
}
