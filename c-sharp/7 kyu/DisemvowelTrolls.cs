// https://www.codewars.com/kata/52fba66badcd10859f00097e/

using System;
using System.Linq;

public static class Kata
{
  public static string Disemvowel(string str)
  {
    return String.Concat(str.Where(x => !"aeiou".Contains(Char.ToLower(x))));
  }
}