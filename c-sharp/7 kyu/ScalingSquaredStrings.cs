// https://www.codewars.com/kata/56ed20a2c4e5d69155000301/

using System.Linq;

public class Scaling
{
  public static string Scale(string s, int k, int n)
  {
    return string.Join('\n', s.Split('\n').Select(x => x.Any()
        ? string.Join('\n', Enumerable.Repeat(string.Concat(x.Select(c => new string(c, k))), n))
        : ""));
  }
}