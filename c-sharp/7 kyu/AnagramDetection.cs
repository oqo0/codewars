// https://www.codewars.com/kata/529eef7a9194e0cbc1000255/

using System;
using System.Linq;

public class Kata
{
  public static bool IsAnagram(string test, string orig)
  {
    return Sort(test) == Sort(orig);
  }
  private static string Sort(string str)
  {
    return String.Concat(str.ToLower().OrderBy(c => c));
  }
}