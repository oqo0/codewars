// https://www.codewars.com/kata/523f5d21c841566fde000009/

using System.Linq;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    return a.Where(n => !b.Contains(n)).ToArray();
  }
}