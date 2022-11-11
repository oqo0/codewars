// https://www.codewars.com/kata/5818d00a559ff57a2f000082/

using System.Numerics;

namespace Kata 
{
  public class Pell
  {
    public BigInteger Get(int n)
    {
      BigInteger[] nums = new BigInteger[n + 1];
      
      nums[0] = 0;
      nums[1] = 1;
      
      for (int i = 2; i < n + 1; i++)
        nums[i] = 2 * nums[i - 1] + nums[i - 2];
      
      return nums[n];
    }
  }
}