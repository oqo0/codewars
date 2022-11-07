// https://www.codewars.com/kata/56f3a1e899b386da78000732/


using System.Linq;

public class PartList
{
  public static string[][] Partlist(string[] arr)
  {
    return arr.Select((s, i) => new[] {string.Join(" ", arr.Take(i)), string.Join(" ", arr.Skip(i))}).Skip(1).ToArray();
  }
}