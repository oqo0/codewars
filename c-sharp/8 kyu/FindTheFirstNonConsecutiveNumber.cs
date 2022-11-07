// https://www.codewars.com/kata/58f8a3a27a5c28d92e000144/

public class Kata
{
  public static object FirstNonConsecutive(int[] arr)
  {
    for (int i = 0; i < arr.Length - 1; i++)
      if (arr[i] + 1 != arr[i + 1]) return arr[i + 1];
    
    return null;
  }
}