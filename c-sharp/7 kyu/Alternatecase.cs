// https://www.codewars.com/kata/57a62154cf1fa5b25200031e/

using System.Linq;

namespace Solution;

public static class Program
{
  public static string alternateCase(string str)
  {
    return new string(
      str.Select(
        c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)
      ).ToArray()
    );
  }
}