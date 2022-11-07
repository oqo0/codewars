// https://www.codewars.com/kata/5a63948acadebff56f000018/

using System.Linq;

public class Kata 
{
  public static int MaxProduct(int[] arr, int size) 
  {
    return arr.OrderBy(i => -i).Take(size).Aggregate((x, y) => x * y);
  }
}