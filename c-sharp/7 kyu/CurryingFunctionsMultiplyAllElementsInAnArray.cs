// https://www.codewars.com/kata/586909e4c66d18dd1800009b/

using System;
using System.Linq;

class Kata
{
  public static Func<int, int[]> MultiplyAll(int[] a) => i => a.Select(x => x * i).ToArray();
}