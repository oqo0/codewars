// https://www.codewars.com/kata/5886d65e427c27afeb0000c1/

using System.Collections.Generic;

namespace myjinxin;

public class Kata
{
  public int SquareDigitsSequence(int a0)
  {
    var lastValues = new List<int>();
    int currentValue = a0;
    
    while (!lastValues.Contains(currentValue))
    {
      lastValues.Add(currentValue);
      currentValue = GetSumOfSquaredDigits(currentValue);
    }
    
    return lastValues.Count + 1;
  }
  
  private int GetSumOfSquaredDigits(int num)
  {
    int sum = 0;
    
    while (num > 0)
    {
      int lastDigit = num % 10;
      sum += lastDigit * lastDigit;
      num /= 10;
    }
    
    return sum;
  }
}