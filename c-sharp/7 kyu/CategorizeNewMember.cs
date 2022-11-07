// https://www.codewars.com/kata/5502c9e7b3216ec63c0001aa/

using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static IEnumerable<string> OpenOrSenior(int[][] data)
  {
    return data.Select(x => (x[0] >= 55 && x[1] > 7) ? "Senior" : "Open");
  }
}