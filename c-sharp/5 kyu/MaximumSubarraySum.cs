// https://www.codewars.com/kata/54521e9ec8e60bc4de000d6c/

using System.Linq;

public static class Kata
{
  public static int MaxSequence(int[] arr) 
  { 
    int res = 0;
    
    for (int i = 0, loc = 0; i < arr.Length; i++, loc = 0)
    {
      for (int j = i; j < arr.Length; j++)
      {
        if ((loc += arr[j]) > res)
          res = loc;
      }
    }
    
    return res;
  }
}