// https://www.codewars.com/kata/5a2fd38b55519ed98f0000ce/

using System.Linq;

public static class Kata
{
  public static string MultiTable(int number)
  {
    return string.Join("\n", Enumerable.Range(1, 10).Select(i => $"{i} * {number} = {i * number}"));
  }
}