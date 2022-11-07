// https://www.codewars.com/kata/5a523566b3bfa84c2e00010b/

using System;
using System.Linq;

class Kata
{
  public static int MinSum(int[] a)
  {
    Array.Sort(a);
    return Enumerable.Range(0, a.Length / 2).Select(i => a[i] * a[^(i + 1)]).Sum();
  }
}