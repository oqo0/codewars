// https://www.codewars.com/kata/5514e5b77e6b2f38e0000ca9/

namespace Kata;

public static class Kata
{
  public static int[] UpArray(int[] num)
  {
    if (!IsArrayValid(num))
      return null;
    
    return PlusOne(num);
  }
  
  private static int[] PlusOne(int[] num)
  {
    for (int i = num.Length - 1; i >= 0; i--)
    {
      num[i] += 1;
      
      if (num[i] < 10)
        return num;
      else
        num[i] = 0;
    }
    
    return NewDigit(num);
  }
  
  private static bool IsArrayValid(int[] num)
  {
    if (num == null || num.Length == 0)
     return false;
    
    foreach (int n in num)
    {
      if (n < 0)
        return false;
      
      if (n > 9)
        return false;
    }
    
    return true;
  }
  
  private static int[] NewDigit(int[] num)
  {
    var newNum = new int[num.Length + 1];
    
    newNum[0] = 1;
    FillWithZeros(newNum, 1, newNum.Length - 1);
    
    return newNum;
  }
  
  private static void FillWithZeros(int[] num, int startIndex, int endIndex)
  {
    for (int i = startIndex; i <= endIndex; i++)
      num[i] = 0;
  }
}