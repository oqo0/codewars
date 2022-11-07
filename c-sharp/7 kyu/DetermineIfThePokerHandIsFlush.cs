// https://www.codewars.com/kata/5acbc3b3481ebb23a400007d/

using System.Linq;

public class Kata
{
  public static bool CheckIfFlush(string[] cards)
  {
    return cards.All(x => x.Contains(cards[0][^1]));
  }
}