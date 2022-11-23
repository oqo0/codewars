// https://www.codewars.com/kata/56582133c932d8239900002e/

using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int MostFrequentItemCount(int[] collection)
  {
    var counter = new Dictionary<int, int>();
    
    foreach (var num in collection)
    {
      if (counter.ContainsKey(num))
        counter[num]++;
      else
        counter.Add(num, 1);
    }
    
    return counter.Count() == 0 ? 0 : counter.Values.Max();
  }
}