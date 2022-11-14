// https://www.codewars.com/kata/57b06f90e298a7b53d000a86/

using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static long QueueTime(int[] c, int n)
  {
    var queue = new Queue<int>(c);
    var tills = Enumerable.Repeat(0, n).ToArray();
    
    long totalTime = 0;
    
    while (queue.Count > 0 || tills.Sum() > 0)
    {
      for (int i = 0; i < tills.Length; i++)
      {
        if (tills[i] == 0 && queue.Count > 0)
          tills[i] = queue.Dequeue();
        
        if (tills[i] > 0)
          tills[i]--;
      }
      
      totalTime++;
    }
    
    return totalTime;
  }
}