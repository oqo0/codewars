// https://www.codewars.com/kata/5b853229cfde412a470000d0/

using System;

namespace Solution
{
  public class TwiceAsOldSolution
  {
    public static int TwiceAsOld(int dadYears, int sonYears) => Math.Abs(2 * sonYears - dadYears);
  }
}