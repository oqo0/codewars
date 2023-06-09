// https://www.codewars.com/kata/56bdd0aec5dc03d7780010a5/

using System;
using System.Linq;

namespace smile67Kata
{
  public class Kata 
  {
    public int nextHigher(int value)
    {
      int amountOfBits = Convert.ToString(value, 2).Count(x => x == '1');
      
      for (int i = value + 1; i < int.MaxValue; i++)
      {
        int amount = Convert.ToString(i, 2).Count(x => x == '1');
        
        if (amountOfBits == amount)
          return i;
      }
      
      return 0;
    }
  }
}
