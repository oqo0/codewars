// https://www.codewars.com/kata/58ca658cc0d6401f2700045f

using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static List<int> FindMultiples(int integer, int limit)
  {
    return Enumerable.
        Range(integer, limit).
        Where(x => x % integer == 0 && x <= limit).
        ToList();
  }
}