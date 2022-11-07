// https://www.codewars.com/kata/5583090cbe83f4fd8c000051/

using System;
using System.Linq;
using System.Collections.Generic;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
      return n.ToString()
        .Select(x => Convert.ToInt64(Char.GetNumericValue(x)))
        .Reverse().
        ToArray();
    }
  }
}