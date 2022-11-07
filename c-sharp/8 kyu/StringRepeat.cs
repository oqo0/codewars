// https://www.codewars.com/kata/57a0e5c372292dd76d000d7e/

using System;
using System.Linq;

namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
      return String.Concat(Enumerable.Repeat(s, n));
    }
  }
}