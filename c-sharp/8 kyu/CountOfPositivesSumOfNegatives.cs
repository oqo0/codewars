// https://www.codewars.com/kata/576bb71bbbcf0951d5000044/

using System.Linq;

public class Kata
{
  public static int[] CountPositivesSumNegatives(int[] input)
  {
    if (input == null || input.Length == 0)
      return new int[0];
    
    return new int[] {
      input.Count(x => x > 0),
      input.Sum(x => x < 0 ? x : 0)
    };
  }
}